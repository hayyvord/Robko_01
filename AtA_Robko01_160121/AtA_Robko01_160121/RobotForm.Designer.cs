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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBaseSpeed = new System.Windows.Forms.TextBox();
            this.btnBaseCcw = new System.Windows.Forms.Button();
            this.tbBaseSteps = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBaseCw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSoulderDown = new System.Windows.Forms.Button();
            this.btnSoulderUp = new System.Windows.Forms.Button();
            this.tbShoulderSpeed = new System.Windows.Forms.TextBox();
            this.tbSoulderSteps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnElbowDown = new System.Windows.Forms.Button();
            this.btnElbowUp = new System.Windows.Forms.Button();
            this.tbElbowSpeed = new System.Windows.Forms.TextBox();
            this.tbElbowSteps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPitchDown = new System.Windows.Forms.Button();
            this.btnRollCw = new System.Windows.Forms.Button();
            this.btnRollCcw = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPitchUp = new System.Windows.Forms.Button();
            this.tbPitchRollSpeed = new System.Windows.Forms.TextBox();
            this.tbPitchRollSteps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGripperOpen = new System.Windows.Forms.Button();
            this.tbGripperSpeed = new System.Windows.Forms.TextBox();
            this.tbGripperSteps = new System.Windows.Forms.TextBox();
            this.btnGripperClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox7.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBaseCw);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbBaseSteps);
            this.groupBox1.Controls.Add(this.btnBaseCcw);
            this.groupBox1.Controls.Add(this.tbBaseSpeed);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 196);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base";
            // 
            // tbBaseSpeed
            // 
            this.tbBaseSpeed.Location = new System.Drawing.Point(6, 73);
            this.tbBaseSpeed.Name = "tbBaseSpeed";
            this.tbBaseSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbBaseSpeed.TabIndex = 1;
            this.tbBaseSpeed.Text = "100";
            // 
            // btnBaseCcw
            // 
            this.btnBaseCcw.Location = new System.Drawing.Point(6, 100);
            this.btnBaseCcw.Name = "btnBaseCcw";
            this.btnBaseCcw.Size = new System.Drawing.Size(100, 37);
            this.btnBaseCcw.TabIndex = 10;
            this.btnBaseCcw.Text = "LEFT";
            this.btnBaseCcw.UseVisualStyleBackColor = true;
            this.btnBaseCcw.Click += new System.EventHandler(this.btnBaseCcw_Click);
            // 
            // tbBaseSteps
            // 
            this.tbBaseSteps.Location = new System.Drawing.Point(6, 35);
            this.tbBaseSteps.Name = "tbBaseSteps";
            this.tbBaseSteps.Size = new System.Drawing.Size(100, 20);
            this.tbBaseSteps.TabIndex = 0;
            this.tbBaseSteps.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Speed:";
            // 
            // btnBaseCw
            // 
            this.btnBaseCw.Location = new System.Drawing.Point(6, 143);
            this.btnBaseCw.Name = "btnBaseCw";
            this.btnBaseCw.Size = new System.Drawing.Size(100, 37);
            this.btnBaseCw.TabIndex = 11;
            this.btnBaseCw.Text = "RIGHT";
            this.btnBaseCw.UseVisualStyleBackColor = true;
            this.btnBaseCw.Click += new System.EventHandler(this.btnBaseCw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Steps:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbSoulderSteps);
            this.groupBox2.Controls.Add(this.tbShoulderSpeed);
            this.groupBox2.Controls.Add(this.btnSoulderUp);
            this.groupBox2.Controls.Add(this.btnSoulderDown);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(132, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 196);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shoulder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Speed:";
            // 
            // btnSoulderDown
            // 
            this.btnSoulderDown.Location = new System.Drawing.Point(9, 140);
            this.btnSoulderDown.Name = "btnSoulderDown";
            this.btnSoulderDown.Size = new System.Drawing.Size(100, 37);
            this.btnSoulderDown.TabIndex = 13;
            this.btnSoulderDown.Text = "DOWN";
            this.btnSoulderDown.UseVisualStyleBackColor = true;
            this.btnSoulderDown.Click += new System.EventHandler(this.btnSoulderDown_Click);
            // 
            // btnSoulderUp
            // 
            this.btnSoulderUp.Location = new System.Drawing.Point(9, 97);
            this.btnSoulderUp.Name = "btnSoulderUp";
            this.btnSoulderUp.Size = new System.Drawing.Size(100, 37);
            this.btnSoulderUp.TabIndex = 12;
            this.btnSoulderUp.Text = "UP";
            this.btnSoulderUp.UseVisualStyleBackColor = true;
            this.btnSoulderUp.Click += new System.EventHandler(this.btnSoulderUp_Click);
            // 
            // tbShoulderSpeed
            // 
            this.tbShoulderSpeed.Location = new System.Drawing.Point(9, 70);
            this.tbShoulderSpeed.Name = "tbShoulderSpeed";
            this.tbShoulderSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbShoulderSpeed.TabIndex = 3;
            this.tbShoulderSpeed.Text = "100";
            // 
            // tbSoulderSteps
            // 
            this.tbSoulderSteps.Location = new System.Drawing.Point(9, 32);
            this.tbSoulderSteps.Name = "tbSoulderSteps";
            this.tbSoulderSteps.Size = new System.Drawing.Size(100, 20);
            this.tbSoulderSteps.TabIndex = 2;
            this.tbSoulderSteps.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Steps:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbElbowSteps);
            this.groupBox3.Controls.Add(this.tbElbowSpeed);
            this.groupBox3.Controls.Add(this.btnElbowUp);
            this.groupBox3.Controls.Add(this.btnElbowDown);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(256, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 196);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elbow";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Speed:";
            // 
            // btnElbowDown
            // 
            this.btnElbowDown.Location = new System.Drawing.Point(9, 140);
            this.btnElbowDown.Name = "btnElbowDown";
            this.btnElbowDown.Size = new System.Drawing.Size(100, 37);
            this.btnElbowDown.TabIndex = 15;
            this.btnElbowDown.Text = "DOWN";
            this.btnElbowDown.UseVisualStyleBackColor = true;
            this.btnElbowDown.Click += new System.EventHandler(this.btnElbowDown_Click);
            // 
            // btnElbowUp
            // 
            this.btnElbowUp.Location = new System.Drawing.Point(9, 97);
            this.btnElbowUp.Name = "btnElbowUp";
            this.btnElbowUp.Size = new System.Drawing.Size(100, 37);
            this.btnElbowUp.TabIndex = 14;
            this.btnElbowUp.Text = "UP";
            this.btnElbowUp.UseVisualStyleBackColor = true;
            this.btnElbowUp.Click += new System.EventHandler(this.btnElbowUp_Click);
            // 
            // tbElbowSpeed
            // 
            this.tbElbowSpeed.Location = new System.Drawing.Point(9, 70);
            this.tbElbowSpeed.Name = "tbElbowSpeed";
            this.tbElbowSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbElbowSpeed.TabIndex = 5;
            this.tbElbowSpeed.Text = "100";
            // 
            // tbElbowSteps
            // 
            this.tbElbowSteps.Location = new System.Drawing.Point(9, 32);
            this.tbElbowSteps.Name = "tbElbowSteps";
            this.tbElbowSteps.Size = new System.Drawing.Size(100, 20);
            this.tbElbowSteps.TabIndex = 4;
            this.tbElbowSteps.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Steps:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbPitchRollSteps);
            this.groupBox4.Controls.Add(this.tbPitchRollSpeed);
            this.groupBox4.Controls.Add(this.btnPitchUp);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnRollCcw);
            this.groupBox4.Controls.Add(this.btnRollCw);
            this.groupBox4.Controls.Add(this.btnPitchDown);
            this.groupBox4.Location = new System.Drawing.Point(380, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 228);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pitch/Roll";
            // 
            // btnPitchDown
            // 
            this.btnPitchDown.Location = new System.Drawing.Point(75, 179);
            this.btnPitchDown.Name = "btnPitchDown";
            this.btnPitchDown.Size = new System.Drawing.Size(100, 37);
            this.btnPitchDown.TabIndex = 19;
            this.btnPitchDown.Text = "DOWN";
            this.btnPitchDown.UseVisualStyleBackColor = true;
            this.btnPitchDown.Click += new System.EventHandler(this.btnPitchDown_Click);
            // 
            // btnRollCw
            // 
            this.btnRollCw.Location = new System.Drawing.Point(127, 136);
            this.btnRollCw.Name = "btnRollCw";
            this.btnRollCw.Size = new System.Drawing.Size(100, 37);
            this.btnRollCw.TabIndex = 18;
            this.btnRollCw.Text = "RIGHT";
            this.btnRollCw.UseVisualStyleBackColor = true;
            this.btnRollCw.Click += new System.EventHandler(this.btnRollCw_Click);
            // 
            // btnRollCcw
            // 
            this.btnRollCcw.Location = new System.Drawing.Point(21, 136);
            this.btnRollCcw.Name = "btnRollCcw";
            this.btnRollCcw.Size = new System.Drawing.Size(100, 37);
            this.btnRollCcw.TabIndex = 17;
            this.btnRollCcw.Text = "LEFT";
            this.btnRollCcw.UseVisualStyleBackColor = true;
            this.btnRollCcw.Click += new System.EventHandler(this.btnRollCcw_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Speed:";
            // 
            // btnPitchUp
            // 
            this.btnPitchUp.Location = new System.Drawing.Point(75, 93);
            this.btnPitchUp.Name = "btnPitchUp";
            this.btnPitchUp.Size = new System.Drawing.Size(100, 37);
            this.btnPitchUp.TabIndex = 16;
            this.btnPitchUp.Text = "UP";
            this.btnPitchUp.UseVisualStyleBackColor = true;
            this.btnPitchUp.Click += new System.EventHandler(this.btnPitchUp_Click);
            // 
            // tbPitchRollSpeed
            // 
            this.tbPitchRollSpeed.Location = new System.Drawing.Point(75, 66);
            this.tbPitchRollSpeed.Name = "tbPitchRollSpeed";
            this.tbPitchRollSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbPitchRollSpeed.TabIndex = 7;
            this.tbPitchRollSpeed.Text = "100";
            // 
            // tbPitchRollSteps
            // 
            this.tbPitchRollSteps.Location = new System.Drawing.Point(75, 28);
            this.tbPitchRollSteps.Name = "tbPitchRollSteps";
            this.tbPitchRollSteps.Size = new System.Drawing.Size(100, 20);
            this.tbPitchRollSteps.TabIndex = 6;
            this.tbPitchRollSteps.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Steps:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGripperClose);
            this.groupBox5.Controls.Add(this.tbGripperSteps);
            this.groupBox5.Controls.Add(this.tbGripperSpeed);
            this.groupBox5.Controls.Add(this.btnGripperOpen);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(638, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 196);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gripper";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Steps:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Speed:";
            // 
            // btnGripperOpen
            // 
            this.btnGripperOpen.Location = new System.Drawing.Point(6, 100);
            this.btnGripperOpen.Name = "btnGripperOpen";
            this.btnGripperOpen.Size = new System.Drawing.Size(100, 37);
            this.btnGripperOpen.TabIndex = 20;
            this.btnGripperOpen.Text = "OPEN";
            this.btnGripperOpen.UseVisualStyleBackColor = true;
            this.btnGripperOpen.Click += new System.EventHandler(this.btnGripperOpen_Click);
            // 
            // tbGripperSpeed
            // 
            this.tbGripperSpeed.Location = new System.Drawing.Point(6, 74);
            this.tbGripperSpeed.Name = "tbGripperSpeed";
            this.tbGripperSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbGripperSpeed.TabIndex = 9;
            this.tbGripperSpeed.Text = "100";
            // 
            // tbGripperSteps
            // 
            this.tbGripperSteps.Location = new System.Drawing.Point(6, 36);
            this.tbGripperSteps.Name = "tbGripperSteps";
            this.tbGripperSteps.Size = new System.Drawing.Size(100, 20);
            this.tbGripperSteps.TabIndex = 8;
            this.tbGripperSteps.Text = "100";
            // 
            // btnGripperClose
            // 
            this.btnGripperClose.Location = new System.Drawing.Point(6, 143);
            this.btnGripperClose.Name = "btnGripperClose";
            this.btnGripperClose.Size = new System.Drawing.Size(100, 37);
            this.btnGripperClose.TabIndex = 21;
            this.btnGripperClose.Text = "CLOSE";
            this.btnGripperClose.UseVisualStyleBackColor = true;
            this.btnGripperClose.Click += new System.EventHandler(this.btnGripperClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 357);
            this.tabControl1.TabIndex = 10;
            // 
            // RobotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 458);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox7);
            this.Name = "RobotForm";
            this.Text = "Robko01";
            this.groupBox7.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGripperClose;
        private System.Windows.Forms.TextBox tbGripperSteps;
        private System.Windows.Forms.TextBox tbGripperSpeed;
        private System.Windows.Forms.Button btnGripperOpen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPitchRollSteps;
        private System.Windows.Forms.TextBox tbPitchRollSpeed;
        private System.Windows.Forms.Button btnPitchUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRollCcw;
        private System.Windows.Forms.Button btnRollCw;
        private System.Windows.Forms.Button btnPitchDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbElbowSteps;
        private System.Windows.Forms.TextBox tbElbowSpeed;
        private System.Windows.Forms.Button btnElbowUp;
        private System.Windows.Forms.Button btnElbowDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoulderSteps;
        private System.Windows.Forms.TextBox tbShoulderSpeed;
        private System.Windows.Forms.Button btnSoulderUp;
        private System.Windows.Forms.Button btnSoulderDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaseCw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBaseSteps;
        private System.Windows.Forms.Button btnBaseCcw;
        private System.Windows.Forms.TextBox tbBaseSpeed;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

