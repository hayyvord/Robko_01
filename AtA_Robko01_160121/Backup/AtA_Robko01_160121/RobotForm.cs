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

        private void btnBaseCW_Click(object sender, EventArgs e)
        {
            this.myRobko.CW(Varibles.Base, Convert.ToInt32(tbBaseSteps));
        }

        private void btnBaseCCW_Click(object sender, EventArgs e)
        {
            this.myRobko.CWW(Varibles.Base, Convert.ToInt32(tbBaseSteps));
        }

        private void btnShoulderCW_Click(object sender, EventArgs e)
        {
            this.myRobko.CW(Varibles.Shoulder, Convert.ToInt32(tbShoulderSteps));
        }

        private void btnShoulderCCW_Click(object sender, EventArgs e)
        {
            this.myRobko.CWW(Varibles.Shoulder, Convert.ToInt32(tbShoulderSteps));
        }

        private void btnElbowCW_Click(object sender, EventArgs e)
        {
            this.myRobko.CW(Varibles.Elbow, Convert.ToInt32(tbElbowSteps));
        }

        private void btnElbowCCW_Click(object sender, EventArgs e)
        {
            this.myRobko.CWW(Varibles.Elbow, Convert.ToInt32(tbElbowSteps));
        }

        private void btnGripperCW_Click(object sender, EventArgs e)
        {
            this.myRobko.CW(Varibles.Gripper, Convert.ToInt32(tbElbowSteps));
        }

        private void btnGripperCCW_Click(object sender, EventArgs e)
        {
            this.myRobko.CWW(Varibles.Gripper, Convert.ToInt32(tbElbowSteps));
        }

        private void btnPrUP_Click(object sender, EventArgs e)
        {
            this.myRobko.UpDown("+",Convert.ToInt32(tbPrSteps));
        }

        private void btnPrDown_Click(object sender, EventArgs e)
        {
            this.myRobko.UpDown("-",Convert.ToInt32(tbPrSteps));
        }

        private void btnPrCW_Click(object sender, EventArgs e)
        {
            this.myRobko.CW(Varibles.PitchRoll, Convert.ToInt32(tbPrSteps));            
        }

        private void btnPrCWW_Click(object sender, EventArgs e)
        {
            this.myRobko.CWW(Varibles.PitchRoll, Convert.ToInt32(tbPrSteps));
        }

    }
}
