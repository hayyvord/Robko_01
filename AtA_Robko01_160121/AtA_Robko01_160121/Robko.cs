using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO.Ports;
using System.Threading;
 
namespace AtA_Robko01_160121
{
    class Robko
    {
  
        #region Variables

        /// <summary>
        /// 
        /// </summary>
        private int timeOut;

        /// <summary>
        /// Comunication port.
        /// </summary>
        private SerialPort RobotPort;

        /// <summary>
        /// Comunication lock object.
        /// </summary>
        private Object requestLock = new Object();

        /// <summary>
        /// When is connected to the robot.
        /// </summary>
        private bool isConnected = false;

        private string portName = String.Empty;

        /// <summary>
        /// Delimiting characters.
        /// </summary>
        private char[] delimiterChars = {',', ':', '\t', ';' };

        #endregion

        #region Properties

        /// <summary>
        /// Maximum timeout.
        /// </summary>
        public int MaxTimeout { get; set; }

        /// <summary>
        /// If the board is correctly connected.
        /// </summary>
        public bool IsConnected
        {
            get
            {
                return this.isConnected;
            }
        }

        #endregion

        #region Constructor / Destructor
     
        public Robko(string portName)
        {
            this.MaxTimeout = 30000;

            this.portName = portName;
        }

        ~Robko()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            this.Disconnect();
        }

        #endregion

        #region Public

        public void Connect()
        {
            while (!this.isConnected)
            {
                try
                {
                    if (!this.isConnected)
                    {
                        this.RobotPort = new SerialPort(this.portName);
                        this.RobotPort.BaudRate = 9600;
                        this.RobotPort.DataBits = 8;
                        this.RobotPort.StopBits = StopBits.One;
                        this.RobotPort.Parity = Parity.None;
                        this.RobotPort.Open();

                        this.timeOut = 0;
                        this.isConnected = true;
                    }
                }
                catch (Exception exception)
                {
                    this.timeOut += 1000;
                    Thread.Sleep(timeOut);
                    this.isConnected = false;
                }
                finally
                {
                    if (timeOut > this.MaxTimeout)
                    {
                        throw new InvalidOperationException("Could not connect to the robot.");
                    }
                }
            }
        }

        public void Disconnect()
        {
            if (this.isConnected)
            {
                this.RobotPort.Close();
            }
            this.isConnected = false;
        }

        public void Reset()
        {
            lock (this.requestLock)
            {
                if (this.isConnected && this.RobotPort.IsOpen)
                {
                    this.RobotPort.DtrEnable = true;
                    Thread.Sleep(200);
                    this.RobotPort.DtrEnable = false;
                }
            }
        }

        public void SendRequest(string command) 
        {
            lock (this.requestLock)
            {
                if (this.isConnected && this.RobotPort.IsOpen)
                {
                    this.RobotPort.WriteLine(command);
                }
            }

        }

        #endregion

        public void Move(int joint, string direction, int steps, int speed)
        {
             //?M3-1230:0200$A0
            string command = string.Format("?M{0}{1}{2:D4}:{3:D4}", joint, direction, steps, speed);
            this.SendRequest(command);
        }

    }
}
