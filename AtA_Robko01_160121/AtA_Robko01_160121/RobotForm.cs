using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtA_Robko01_160121
{
    public partial class RobotForm : Form
    {
        Robko myRobko = new Robko("COM4");

        public RobotForm()
        {
            InitializeComponent();
        }

        private void SearchForPorts()
        {
            cbPorts.Items.Clear();

            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();

            if (portNames.Length == 0)
            {
                cbPorts.Text = "No Ports";
                return;
            }

            foreach (string item in portNames)
            {
                cbPorts.Items.Add(item);
            }

            cbPorts.Text = cbPorts.Items[0].ToString();
       } 

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.myRobko = new Robko(cbPorts.Text);
            this.myRobko.Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.myRobko.Disconnect();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForPorts();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.myRobko.Reset();
        }

        private void btnBaseCcw_Click(object sender, EventArgs e)
        {
 
            myRobko.Move(Varibles.Base, Varibles.CWW,Int32.Parse(tbBaseSteps.Text),Int32.Parse(tbBaseSpeed.Text));
        }

        private void btnBaseCw_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Base, Varibles.CW, Int32.Parse(tbBaseSteps.Text), Int32.Parse(tbBaseSpeed.Text));
        }

        private void btnSoulderUp_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Shoulder, Varibles.CW, Int32.Parse(tbSoulderSteps.Text), Int32.Parse(tbShoulderSpeed.Text));
        }

        private void btnSoulderDown_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Shoulder, Varibles.CWW, Int32.Parse(tbSoulderSteps.Text), Int32.Parse(tbShoulderSpeed.Text));
        }

        private void btnElbowUp_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Elbow, Varibles.CW, Int32.Parse(tbElbowSteps.Text), Int32.Parse(tbElbowSpeed.Text));
        }

        private void btnElbowDown_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Elbow, Varibles.CWW, Int32.Parse(tbElbowSteps.Text), Int32.Parse(tbElbowSpeed.Text));
        }

        private void btnPitchUp_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Pitch, Varibles.CW, Int32.Parse(tbPitchRollSteps.Text), Int32.Parse(tbPitchRollSpeed.Text));
        }

        private void btnPitchDown_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Pitch, Varibles.CWW, Int32.Parse(tbPitchRollSteps.Text), Int32.Parse(tbPitchRollSpeed.Text));
        }

        private void btnRollCcw_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Roll, Varibles.CW, Int32.Parse(tbPitchRollSteps.Text), Int32.Parse(tbPitchRollSpeed.Text));
        }

        private void btnRollCw_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Roll, Varibles.CWW, Int32.Parse(tbPitchRollSteps.Text), Int32.Parse(tbPitchRollSpeed.Text));
        }

        private void btnGripperOpen_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Gripper, Varibles.CWW, Int32.Parse(tbGripperSteps.Text), Int32.Parse(tbGripperSpeed.Text));
        }

        private void btnGripperClose_Click(object sender, EventArgs e)
        {
            myRobko.Move(Varibles.Gripper, Varibles.CW, Int32.Parse(tbGripperSteps.Text), Int32.Parse(tbGripperSpeed.Text));
        }


    }
}
