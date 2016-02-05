namespace AtA_Robko01_160121
{
    partial class RobotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBaseSteps = new System.Windows.Forms.TextBox();
            this.tbBaseSpeed = new System.Windows.Forms.TextBox();
            this.btnBaseCW = new System.Windows.Forms.Button();
            this.btnBaseCCW = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrCWW = new System.Windows.Forms.Button();
            this.btnPrCW = new System.Windows.Forms.Button();
            this.btnGripperCCW = new System.Windows.Forms.Button();
            this.btnGripperCW = new System.Windows.Forms.Button();
            this.tbGripperSteps = new System.Windows.Forms.TextBox();
            this.btnPrDown = new System.Windows.Forms.Button();
            this.btnPrUP = new System.Windows.Forms.Button();
            this.btnShoulderCCW = new System.Windows.Forms.Button();
            this.tbPrSteps = new System.Windows.Forms.TextBox();
            this.tbShoulderSteps = new System.Windows.Forms.TextBox();
            this.btnShoulderCW = new System.Windows.Forms.Button();
            this.btnElbowCCW = new System.Windows.Forms.Button();
            this.tbElbowSteps = new System.Windows.Forms.TextBox();
            this.btnElbowCW = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBaseSteps
            // 
            this.tbBaseSteps.Location = new System.Drawing.Point(7, 20);
            this.tbBaseSteps.Name = "tbBaseSteps";
            this.tbBaseSteps.Size = new System.Drawing.Size(80, 20);
            this.tbBaseSteps.TabIndex = 3;
            this.tbBaseSteps.Text = "0";
            this.tbBaseSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBaseSpeed
            // 
            this.tbBaseSpeed.Location = new System.Drawing.Point(7, 46);
            this.tbBaseSpeed.Name = "tbBaseSpeed";
            this.tbBaseSpeed.Size = new System.Drawing.Size(622, 20);
            this.tbBaseSpeed.TabIndex = 4;
            this.tbBaseSpeed.Text = "30";
            this.tbBaseSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBaseCW
            // 
            this.btnBaseCW.Location = new System.Drawing.Point(7, 72);
            this.btnBaseCW.Name = "btnBaseCW";
            this.btnBaseCW.Size = new System.Drawing.Size(80, 23);
            this.btnBaseCW.TabIndex = 5;
            this.btnBaseCW.Text = "CW";
            this.btnBaseCW.UseVisualStyleBackColor = true;
            this.btnBaseCW.Click += new System.EventHandler(this.btnBaseCW_Click);
            // 
            // btnBaseCCW
            // 
            this.btnBaseCCW.Location = new System.Drawing.Point(7, 101);
            this.btnBaseCCW.Name = "btnBaseCCW";
            this.btnBaseCCW.Size = new System.Drawing.Size(80, 23);
            this.btnBaseCCW.TabIndex = 6;
            this.btnBaseCCW.Text = "CCW";
            this.btnBaseCCW.UseVisualStyleBackColor = true;
            this.btnBaseCCW.Click += new System.EventHandler(this.btnBaseCCW_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrCWW);
            this.groupBox2.Controls.Add(this.btnPrCW);
            this.groupBox2.Controls.Add(this.btnBaseCCW);
            this.groupBox2.Controls.Add(this.btnGripperCCW);
            this.groupBox2.Controls.Add(this.btnGripperCW);
            this.groupBox2.Controls.Add(this.tbGripperSteps);
            this.groupBox2.Controls.Add(this.tbBaseSteps);
            this.groupBox2.Controls.Add(this.btnBaseCW);
            this.groupBox2.Controls.Add(this.tbBaseSpeed);
            this.groupBox2.Controls.Add(this.btnPrDown);
            this.groupBox2.Controls.Add(this.btnPrUP);
            this.groupBox2.Controls.Add(this.btnShoulderCCW);
            this.groupBox2.Controls.Add(this.tbPrSteps);
            this.groupBox2.Controls.Add(this.tbShoulderSteps);
            this.groupBox2.Controls.Add(this.btnShoulderCW);
            this.groupBox2.Controls.Add(this.btnElbowCCW);
            this.groupBox2.Controls.Add(this.tbElbowSteps);
            this.groupBox2.Controls.Add(this.btnElbowCW);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 134);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Base";
            // 
            // btnPrCWW
            // 
            this.btnPrCWW.Location = new System.Drawing.Point(497, 72);
            this.btnPrCWW.Name = "btnPrCWW";
            this.btnPrCWW.Size = new System.Drawing.Size(46, 52);
            this.btnPrCWW.TabIndex = 8;
            this.btnPrCWW.Text = "CWW";
            this.btnPrCWW.UseVisualStyleBackColor = true;
            this.btnPrCWW.Click += new System.EventHandler(this.btnPrCWW_Click);
            // 
            // btnPrCW
            // 
            this.btnPrCW.Location = new System.Drawing.Point(360, 72);
            this.btnPrCW.Name = "btnPrCW";
            this.btnPrCW.Size = new System.Drawing.Size(46, 52);
            this.btnPrCW.TabIndex = 7;
            this.btnPrCW.Text = "CW";
            this.btnPrCW.UseVisualStyleBackColor = true;
            this.btnPrCW.Click += new System.EventHandler(this.btnPrCW_Click);
            // 
            // btnGripperCCW
            // 
            this.btnGripperCCW.Location = new System.Drawing.Point(549, 101);
            this.btnGripperCCW.Name = "btnGripperCCW";
            this.btnGripperCCW.Size = new System.Drawing.Size(80, 23);
            this.btnGripperCCW.TabIndex = 6;
            this.btnGripperCCW.Text = "Close";
            this.btnGripperCCW.UseVisualStyleBackColor = true;
            this.btnGripperCCW.Click += new System.EventHandler(this.btnGripperCCW_Click);
            // 
            // btnGripperCW
            // 
            this.btnGripperCW.Location = new System.Drawing.Point(549, 72);
            this.btnGripperCW.Name = "btnGripperCW";
            this.btnGripperCW.Size = new System.Drawing.Size(80, 23);
            this.btnGripperCW.TabIndex = 5;
            this.btnGripperCW.Text = "Open";
            this.btnGripperCW.UseVisualStyleBackColor = true;
            this.btnGripperCW.Click += new System.EventHandler(this.btnGripperCW_Click);
            // 
            // tbGripperSteps
            // 
            this.tbGripperSteps.Location = new System.Drawing.Point(549, 20);
            this.tbGripperSteps.Name = "tbGripperSteps";
            this.tbGripperSteps.Size = new System.Drawing.Size(80, 20);
            this.tbGripperSteps.TabIndex = 3;
            this.tbGripperSteps.Text = "0";
            this.tbGripperSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrDown
            // 
            this.btnPrDown.Location = new System.Drawing.Point(412, 101);
            this.btnPrDown.Name = "btnPrDown";
            this.btnPrDown.Size = new System.Drawing.Size(80, 23);
            this.btnPrDown.TabIndex = 6;
            this.btnPrDown.Text = "Down";
            this.btnPrDown.UseVisualStyleBackColor = true;
            this.btnPrDown.Click += new System.EventHandler(this.btnPrDown_Click);
            // 
            // btnPrUP
            // 
            this.btnPrUP.Location = new System.Drawing.Point(412, 72);
            this.btnPrUP.Name = "btnPrUP";
            this.btnPrUP.Size = new System.Drawing.Size(80, 23);
            this.btnPrUP.TabIndex = 5;
            this.btnPrUP.Text = "Up";
            this.btnPrUP.UseVisualStyleBackColor = true;
            this.btnPrUP.Click += new System.EventHandler(this.btnPrUP_Click);
            // 
            // btnShoulderCCW
            // 
            this.btnShoulderCCW.Location = new System.Drawing.Point(139, 101);
            this.btnShoulderCCW.Name = "btnShoulderCCW";
            this.btnShoulderCCW.Size = new System.Drawing.Size(80, 23);
            this.btnShoulderCCW.TabIndex = 6;
            this.btnShoulderCCW.Text = "CCW";
            this.btnShoulderCCW.UseVisualStyleBackColor = true;
            this.btnShoulderCCW.Click += new System.EventHandler(this.btnShoulderCCW_Click);
            // 
            // tbPrSteps
            // 
            this.tbPrSteps.Location = new System.Drawing.Point(412, 20);
            this.tbPrSteps.Name = "tbPrSteps";
            this.tbPrSteps.Size = new System.Drawing.Size(80, 20);
            this.tbPrSteps.TabIndex = 3;
            this.tbPrSteps.Text = "0";
            this.tbPrSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbShoulderSteps
            // 
            this.tbShoulderSteps.Location = new System.Drawing.Point(139, 20);
            this.tbShoulderSteps.Name = "tbShoulderSteps";
            this.tbShoulderSteps.Size = new System.Drawing.Size(80, 20);
            this.tbShoulderSteps.TabIndex = 3;
            this.tbShoulderSteps.Text = "0";
            this.tbShoulderSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShoulderCW
            // 
            this.btnShoulderCW.Location = new System.Drawing.Point(139, 72);
            this.btnShoulderCW.Name = "btnShoulderCW";
            this.btnShoulderCW.Size = new System.Drawing.Size(80, 23);
            this.btnShoulderCW.TabIndex = 5;
            this.btnShoulderCW.Text = "CW";
            this.btnShoulderCW.UseVisualStyleBackColor = true;
            this.btnShoulderCW.Click += new System.EventHandler(this.btnShoulderCW_Click);
            // 
            // btnElbowCCW
            // 
            this.btnElbowCCW.Location = new System.Drawing.Point(274, 101);
            this.btnElbowCCW.Name = "btnElbowCCW";
            this.btnElbowCCW.Size = new System.Drawing.Size(80, 23);
            this.btnElbowCCW.TabIndex = 6;
            this.btnElbowCCW.Text = "CCW";
            this.btnElbowCCW.UseVisualStyleBackColor = true;
            this.btnElbowCCW.Click += new System.EventHandler(this.btnElbowCCW_Click);
            // 
            // tbElbowSteps
            // 
            this.tbElbowSteps.Location = new System.Drawing.Point(274, 20);
            this.tbElbowSteps.Name = "tbElbowSteps";
            this.tbElbowSteps.Size = new System.Drawing.Size(80, 20);
            this.tbElbowSteps.TabIndex = 3;
            this.tbElbowSteps.Text = "0";
            this.tbElbowSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnElbowCW
            // 
            this.btnElbowCW.Location = new System.Drawing.Point(274, 72);
            this.btnElbowCW.Name = "btnElbowCW";
            this.btnElbowCW.Size = new System.Drawing.Size(80, 23);
            this.btnElbowCW.TabIndex = 5;
            this.btnElbowCW.Text = "CW";
            this.btnElbowCW.UseVisualStyleBackColor = true;
            this.btnElbowCW.Click += new System.EventHandler(this.btnElbowCW_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSearch);
            this.groupBox7.Controls.Add(this.btnReset);
            this.groupBox7.Controls.Add(this.btnDisconnect);
            this.groupBox7.Controls.Add(this.btnConnect);
            this.groupBox7.Controls.Add(this.cbPorts);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(636, 41);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SerialPort";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(139, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(549, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(412, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(80, 23);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(274, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(7, 14);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(80, 21);
            this.cbPorts.TabIndex = 0;
            // 
            // RobotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 208);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Name = "RobotForm";
            this.Text = "Robko01";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbBaseSteps;
        private System.Windows.Forms.TextBox tbBaseSpeed;
        private System.Windows.Forms.Button btnBaseCW;
        private System.Windows.Forms.Button btnBaseCCW;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShoulderCCW;
        private System.Windows.Forms.Button btnShoulderCW;
        private System.Windows.Forms.Button btnElbowCCW;
        private System.Windows.Forms.Button btnElbowCW;
        private System.Windows.Forms.Button btnPrDown;
        private System.Windows.Forms.Button btnPrUP;
        private System.Windows.Forms.Button btnGripperCCW;
        private System.Windows.Forms.Button btnGripperCW;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrCWW;
        private System.Windows.Forms.Button btnPrCW;
        private System.Windows.Forms.TextBox tbGripperSteps;
        private System.Windows.Forms.TextBox tbPrSteps;
        private System.Windows.Forms.TextBox tbShoulderSteps;
        private System.Windows.Forms.TextBox tbElbowSteps;
    }
}

