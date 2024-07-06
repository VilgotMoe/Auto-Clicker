namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            txtSeconds = new TextBox();
            label4 = new Label();
            txtMilliseconds = new TextBox();
            label3 = new Label();
            txtMinutes = new TextBox();
            label2 = new Label();
            txtHours = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            cmbClickAction = new ComboBox();
            cmbClickType = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            label11 = new Label();
            numericUpDownRepeatCount = new NumericUpDown();
            rbRepeatUntilStopped = new RadioButton();
            rbRepeat = new RadioButton();
            label7 = new Label();
            panel6 = new Panel();
            radioButton1 = new RadioButton();
            label8 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRepeatCount).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSeconds);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMilliseconds);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMinutes);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtHours);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 83);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 39);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 8;
            label5.Text = "secs";
            // 
            // txtSeconds
            // 
            txtSeconds.BorderStyle = BorderStyle.FixedSingle;
            txtSeconds.Location = new Point(243, 37);
            txtSeconds.Name = "txtSeconds";
            txtSeconds.RightToLeft = RightToLeft.Yes;
            txtSeconds.Size = new Size(49, 23);
            txtSeconds.TabIndex = 7;
            txtSeconds.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 39);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "milliseconds";
            // 
            // txtMilliseconds
            // 
            txtMilliseconds.BorderStyle = BorderStyle.FixedSingle;
            txtMilliseconds.Location = new Point(355, 37);
            txtMilliseconds.Name = "txtMilliseconds";
            txtMilliseconds.RightToLeft = RightToLeft.Yes;
            txtMilliseconds.Size = new Size(49, 23);
            txtMilliseconds.TabIndex = 5;
            txtMilliseconds.Text = "100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 37);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "mins";
            // 
            // txtMinutes
            // 
            txtMinutes.BorderStyle = BorderStyle.FixedSingle;
            txtMinutes.Location = new Point(131, 35);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.RightToLeft = RightToLeft.Yes;
            txtMinutes.Size = new Size(49, 23);
            txtMinutes.TabIndex = 3;
            txtMinutes.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 37);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "hours";
            // 
            // txtHours
            // 
            txtHours.BorderStyle = BorderStyle.FixedSingle;
            txtHours.Location = new Point(12, 35);
            txtHours.Name = "txtHours";
            txtHours.RightToLeft = RightToLeft.Yes;
            txtHours.Size = new Size(49, 23);
            txtHours.TabIndex = 1;
            txtHours.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Click interval";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(16, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cmbClickAction);
            panel3.Controls.Add(cmbClickType);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 112);
            panel3.TabIndex = 2;
            // 
            // cmbClickAction
            // 
            cmbClickAction.BackColor = Color.LightGray;
            cmbClickAction.FormattingEnabled = true;
            cmbClickAction.Location = new Point(106, 62);
            cmbClickAction.Name = "cmbClickAction";
            cmbClickAction.Size = new Size(91, 23);
            cmbClickAction.TabIndex = 4;
            // 
            // cmbClickType
            // 
            cmbClickType.BackColor = Color.LightGray;
            cmbClickType.FormattingEnabled = true;
            cmbClickType.Location = new Point(106, 29);
            cmbClickType.Name = "cmbClickType";
            cmbClickType.Size = new Size(91, 23);
            cmbClickType.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(8, 65);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 2;
            label10.Text = "Click type:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 29);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 1;
            label9.Text = "Mouse button:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, -1);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 0;
            label6.Text = "Click options";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label11);
            panel5.Controls.Add(numericUpDownRepeatCount);
            panel5.Controls.Add(rbRepeatUntilStopped);
            panel5.Controls.Add(rbRepeat);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(295, 121);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 100);
            panel5.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(153, 34);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 7;
            label11.Text = "times";
            // 
            // numericUpDownRepeatCount
            // 
            numericUpDownRepeatCount.Location = new Point(82, 29);
            numericUpDownRepeatCount.Name = "numericUpDownRepeatCount";
            numericUpDownRepeatCount.Size = new Size(54, 23);
            numericUpDownRepeatCount.TabIndex = 6;
            numericUpDownRepeatCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // rbRepeatUntilStopped
            // 
            rbRepeatUntilStopped.AutoSize = true;
            rbRepeatUntilStopped.Checked = true;
            rbRepeatUntilStopped.Location = new Point(15, 62);
            rbRepeatUntilStopped.Name = "rbRepeatUntilStopped";
            rbRepeatUntilStopped.Size = new Size(134, 19);
            rbRepeatUntilStopped.TabIndex = 5;
            rbRepeatUntilStopped.TabStop = true;
            rbRepeatUntilStopped.Text = "Repeat until stopped";
            rbRepeatUntilStopped.UseVisualStyleBackColor = true;
            // 
            // rbRepeat
            // 
            rbRepeat.AutoSize = true;
            rbRepeat.Location = new Point(15, 30);
            rbRepeat.Name = "rbRepeat";
            rbRepeat.Size = new Size(61, 19);
            rbRepeat.TabIndex = 4;
            rbRepeat.Text = "Repeat";
            rbRepeat.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 1;
            label7.Text = "Click repeat";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(radioButton1);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(12, 239);
            panel6.Name = "panel6";
            panel6.Size = new Size(499, 62);
            panel6.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(7, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Current location";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 2;
            label8.Text = "Cursor position";
            // 
            // btnStart
            // 
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Location = new Point(12, 350);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(220, 62);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start (F6)";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // btnStop
            // 
            btnStop.FlatStyle = FlatStyle.Popup;
            btnStop.Location = new Point(276, 350);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(220, 62);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop (F6)";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(523, 454);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Clicker";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRepeatCount).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox txtSeconds;
        private Label label4;
        private TextBox txtMilliseconds;
        private Label label3;
        private TextBox txtMinutes;
        private Label label2;
        private TextBox txtHours;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Button btnStart;
        private Button btnStop;
        private Label label6;
        private ComboBox cmbClickType;
        private Label label10;
        private Label label9;
        private Label label7;
        private RadioButton radioButton1;
        private Label label8;
        private ComboBox cmbClickAction;
        private Label label11;
        private NumericUpDown numericUpDownRepeatCount;
        private RadioButton rbRepeatUntilStopped;
        private RadioButton rbRepeat;
    }
}
