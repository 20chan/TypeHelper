namespace TypeHelper
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.radAll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOne = new System.Windows.Forms.RadioButton();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.combTitle = new System.Windows.Forms.ComboBox();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(18, 24);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(126, 25);
            this.radAll.TabIndex = 0;
            this.radAll.TabStop = true;
            this.radAll.Text = "전 부치기";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radMods_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOne);
            this.groupBox1.Controls.Add(this.radLine);
            this.groupBox1.Controls.Add(this.radAll);
            this.groupBox1.Location = new System.Drawing.Point(20, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "모드 선택";
            // 
            // radOne
            // 
            this.radOne.AutoSize = true;
            this.radOne.Location = new System.Drawing.Point(18, 84);
            this.radOne.Name = "radOne";
            this.radOne.Size = new System.Drawing.Size(154, 25);
            this.radOne.TabIndex = 0;
            this.radOne.TabStop = true;
            this.radOne.Text = "한 타당 한자";
            this.radOne.UseVisualStyleBackColor = true;
            this.radOne.CheckedChanged += new System.EventHandler(this.radMods_CheckedChanged);
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Location = new System.Drawing.Point(18, 55);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(168, 25);
            this.radLine.TabIndex = 0;
            this.radLine.TabStop = true;
            this.radLine.Text = "페이지 씩치기";
            this.radLine.UseVisualStyleBackColor = true;
            this.radLine.CheckedChanged += new System.EventHandler(this.radMods_CheckedChanged);
            // 
            // combTitle
            // 
            this.combTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTitle.FormattingEnabled = true;
            this.combTitle.Location = new System.Drawing.Point(237, 21);
            this.combTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combTitle.Name = "combTitle";
            this.combTitle.Size = new System.Drawing.Size(253, 29);
            this.combTitle.TabIndex = 2;
            // 
            // trackSpeed
            // 
            this.trackSpeed.AutoSize = false;
            this.trackSpeed.Location = new System.Drawing.Point(237, 64);
            this.trackSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackSpeed.Maximum = 1000;
            this.trackSpeed.Minimum = 1;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(253, 32);
            this.trackSpeed.TabIndex = 3;
            this.trackSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackSpeed.Value = 50;
            this.trackSpeed.Scroll += new System.EventHandler(this.trackSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(237, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "500타";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(510, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(80, 133);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 80;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 154);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackSpeed);
            this.Controls.Add(this.combTitle);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("굴림", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "TypeHelper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOne;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.ComboBox combTitle;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

