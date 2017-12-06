using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace TypeHelper
{
    public partial class Form1 : Form
    {
        enum Mod { All, Line, One }
        Mod currentMod;
        int speed = 100;
        bool systemTyping = false;
        int index, inindex;

        bool started = false;
        ManualResetEvent waiter;

        Dictionary<string, string[]> texts;

        public Form1()
        {
            InitializeComponent();

            texts = new Dictionary<string, string[]>();
            foreach (var file in new DirectoryInfo("datas").EnumerateFiles("*.txt"))
            {
                var name = Path.GetFileNameWithoutExtension(file.Name);
                texts.Add(name, File.ReadAllLines(file.FullName));
                combTitle.Items.Add(name);
            }

            waiter = new ManualResetEvent(false);
            combTitle.SelectedIndex = 0;
            trackSpeed.Value = 50;
            KeyboardHook.KeyDown += KeyboardHook_KeyDown;
            KeyboardHook.HookStart();
            trackBar1_Scroll(null, null);
        }

        private bool KeyboardHook_KeyDown(Keys key)
        {
            if (systemTyping) return true;
            if (key == Keys.Back) return true;
            if (key == Keys.F2) Start();
            else if (key == Keys.F3) Finish();
            else if (key == Keys.F10)
            {
                if (ModifierKeys == Keys.Control)
                    Show();
                else Hide();
            }
            if (!started) return true;

            var cur = texts[combTitle.Text];
            switch (currentMod)
            {
                case Mod.All:
                    return false;
                case Mod.Line:
                    systemTyping = true;
                    if (index < cur.Length)
                    {
                        SendKeys.SendWait(cur[index] + "~");
                        SendKeys.SendWait(cur[index+1] + "~");
                        SendKeys.SendWait(cur[index+2] + "~");
                        SendKeys.SendWait(cur[index+3] + "~");
                        SendKeys.SendWait(cur[index+4] + "~");
                    }index += 5;
                    systemTyping = false;
                    break;
                case Mod.One:
                    if (inindex == cur[index].Length)
                    {
                        index++;
                        inindex = 0;
                        systemTyping = true;
                        SendKeys.SendWait("~");
                        systemTyping = false;
                        break;
                    }
                    if (index == cur.Length)
                        break;
                    systemTyping = true;
                    SendKeys.SendWait(cur[index][inindex++].ToString());
                    systemTyping = false;
                    break;
            }
            return false;
        }

        void Start()
        {
            index = 0;
            inindex = 0;
            started = true;
        }

        void Finish()
        {
            started = false;
            systemTyping = false;
        }
        
        private void radMods_CheckedChanged(object sender, EventArgs e)
        {
            if (radAll.Checked) currentMod = Mod.All;
            else if (radLine.Checked) currentMod = Mod.Line;
            else if (radOne.Checked) currentMod = Mod.One;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            KeyboardHook.HookEnd();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value / 100.0;
        }

        private void trackSpeed_Scroll(object sender, EventArgs e)
        {
            speed = trackSpeed.Value;
            label1.Text = $"{speed}타";
        }
    }
}
