using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Catapult
{
    public partial class Form1 : Form
    {
        private bool SerialPortActive = false;
        private SerialPort PortThatIsSerial;
        private int Step = 1;

        private double D_max = 235; // Example distance at max tension (e.g., 100 meters)
        private double D_min = 92;  // Example distance at min tension (e.g., 20 meters)
        private double T_max = 182; // Example max tension value
        private double T_min = 0;  // Example min tension value
        private const double T_min_time = 1.19; // Example minimum time of flight
        private const double T_max_time = 1.42; // Example maximum time of flight

        public Form1()
        {
            InitializeComponent();

            PortThatIsSerial = new SerialPort();
            PortThatIsSerial.DataReceived += SerialReceived;

            string[] SerialPorts = SerialPort.GetPortNames();
            foreach (string portName in SerialPorts)
            {
                ComList.Items.Add(portName);
            }

            TransmitterTimer.Interval = 100; // Adjust the interval as needed
        }

        private void SerialReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string received = PortThatIsSerial.ReadExisting();
            // Process received data if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!SerialPortActive)
            {
                int BaudSelection = Convert.ToInt32(BaudBox.Text);
                int PortSelection = ComList.SelectedIndex;

                if (BaudSelection != 0 && PortSelection != -1)
                {
                    try
                    {
                        PortThatIsSerial.PortName = ComList.Items[PortSelection] as string;
                        PortThatIsSerial.BaudRate = BaudSelection;
                        PortThatIsSerial.Parity = Parity.None;
                        PortThatIsSerial.DataBits = 8;
                        PortThatIsSerial.StopBits = StopBits.One;

                        PortThatIsSerial.Open();
                        BeginSerial.Text = "Close Serial";
                        SerialPortActive = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Invalid port configuration!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    MessageBox.Show("Serial port is ready!", "Yeah!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Baud / Port not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                PortThatIsSerial.Close();
                SerialPortActive = false;
                BeginSerial.Text = "Begin Serial";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateApproximateDistance();
            if (SerialPortActive)
            {
                int value = trackBar1.Value;
                TensionValue.Text = value.ToString();
                PortThatIsSerial.Write("A" + value.ToString() + "\n");
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (SerialPortActive)
            {
                int value = trackBar2.Value;
                ArmingValue.Text = value.ToString();
                PortThatIsSerial.Write("B" + value.ToString() + "\n");
            }
        }

        private void StepSequenceButton_Click(object sender, EventArgs e)
        {
            if (SerialPortActive)
            {
                switch (Step)
                {
                    case 1:
                        PortThatIsSerial.Write("A" + StartPosTARM.Text + "\n");
                        PortThatIsSerial.Write("B" + StartPosET.Text + "\n");
                        Step++;
                        break;
                    case 2:
                        PortThatIsSerial.Write("A" + ClsTriggerTARM.Text + "\n");
                        PortThatIsSerial.Write("B" + ClsTriggerET.Text + "\n");
                        Step++;
                        break;
                    case 3:
                        PortThatIsSerial.Write("A" + MTATARM.Text + "\n");
                        PortThatIsSerial.Write("B" + MTARS.Text + "\n");
                        Step++;
                        break;
                    case 4:
                        PortThatIsSerial.Write("A" + RTMTARM.Text + "\n");
                        PortThatIsSerial.Write("B" + RTMET.Text + "\n");
                        Step++;
                        break;
                    case 5:
                        PortThatIsSerial.Write("A" + FireTARM.Text + "\n");
                        PortThatIsSerial.Write("B" + FireET.Text + "\n");
                        Step = 1;
                        break;
                }
                STEP.Text = Step.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComList.Items.Clear();
            string[] SerialPorts = SerialPort.GetPortNames();
            foreach (string portName in SerialPorts)
            {
                ComList.Items.Add(portName);
            }
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            int value = 180;
            PortThatIsSerial.Write("B" + value.ToString() + "\n");
        }

        private void Lock_Click(object sender, EventArgs e)
        {
            int value = 40;
            PortThatIsSerial.Write("B" + value.ToString() + "\n");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int value = 178;
            PortThatIsSerial.Write("A" + value.ToString() + "\n");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int value = 0;
            PortThatIsSerial.Write("A" + value.ToString() + "\n");
        }

        private void ViewTrajectory_Click(object sender, EventArgs e)
        {
            int value = 180;
            PortThatIsSerial.Write("B" + value.ToString() + "\n");
            // Example values for time of flight and launch angle
            double timeOfFlight = CalculateTimeOfFlightBasedOnTension(trackBar1.Value); // in seconds
            double angleDegrees = 71.2; // in degrees

            // Create and show the Grapher form with parameters
            Grapher grapher = new Grapher(timeOfFlight, angleDegrees);
            grapher.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double timeOfFlight = 1.42; // in seconds
            double angleDegrees = 71.2; // in degrees

            // Create and show the Grapher form with parameters
            Grapher grapher = new Grapher(timeOfFlight, angleDegrees);
            grapher.Show();
        }

        private void UpdateApproximateDistance()
        {
            // Example calculation, replace with your actual formula
            double tension = trackBar1.Value;
            
                double distance = CalculateDistanceBasedOnTension(tension);
                ApproxDistanceLabel.Text = $"Approximate Distance: {distance:F2} centimeters";
            
         
            
            
        }

        private double CalculateDistanceBasedOnTension(double tension)
        {
            // Ensure the tension value is within the valid range
            if (tension < T_min || tension > T_max)
                throw new ArgumentOutOfRangeException("Tension value out of range.");

            // Invert the tension value
            double invertedTension = T_max - tension; // Invert tension to match the desired range

            // Calculate distance based on the inverted tension
            return D_min + (invertedTension / (T_max - T_min)) * (D_max - D_min);
        }

        private void UpdateApproximateTimeOfFlight()
        {
            double tension = trackBar1.Value;
                    double timeOfFlight = CalculateTimeOfFlightBasedOnTension(tension);
                    TimeOfFlightLabel.Text = $"Approximate Time of Flight: {timeOfFlight:F2} seconds";
            
        }
        private double CalculateTimeOfFlightBasedOnTension(double tension)
        {
            // Ensure the tension value is within the valid range
            if (tension < T_min || tension > T_max)
                throw new ArgumentOutOfRangeException("Tension value out of range.");

            // Invert the tension value
            double invertedTension = T_max - tension; // Invert tension to match the desired range

            // Calculate time of flight based on the inverted tension
            return T_min_time + (invertedTension / (T_max - T_min)) * (T_max_time - T_min_time);
        }

        private void ApproxDistanceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
