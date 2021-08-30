/*TODO: Arduino - PC bağlantısındaki bağlantı noktasını otomatik al --- x 
 * Bağlantıyı yap ve senkron olarak veri al/yolla
 * Asenkron bağlantı yapısına geç 
 * Fan bilgilerini ve kontrolünü yap
 * Tuşları lehimle ve Arduino bağlantısını yap
 * Tuşlara özellik ata
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using NvAPIWrapper;
using NvAPIWrapper.GPU;
using System.Diagnostics;
using System.IO;
using AudioSwitcher.AudioApi.CoreAudio;

namespace Keyboard
{
    public partial class Form1 : Form
    {
       
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        string data;
        Byte[] buffer = new byte[1024];
        int speed = 50;
        bool isSpeedChanged = true;
        
        public Form1()
        {
            InitializeComponent();
            getAvailableComPorts();
            NVIDIA.Initialize();

            if (ports!=null)
            {
                foreach (string port in ports)
                {
                    comboBox1.Items.Add(port);
                    Console.WriteLine(port);
                    if (ports[0] != null)
                    {
                        comboBox1.SelectedItem = ports[0];
                    }
                }
            }
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

      



        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            button1.Text = "Disconnect";
            connectionStatus.ForeColor = Color.Green;
            connectionStatus.Text = "Bagli";
            pot.Enabled = true;
            //Action kickoffRead = null;
            //kickoffRead = delegate {
            //    port.BaseStream.BeginRead(buffer, 0, buffer.Length, delegate (IAsyncResult ar) {
            //        try
            //        {
            //            int actualLength = port.BaseStream.EndRead(ar);
            //            byte[] received = new byte[actualLength];
            //            Buffer.BlockCopy(buffer, 0, received, 0, actualLength);
            //            Console.WriteLine(Encoding.Default.GetString(buffer));
            //        }
            //        catch (IOException exc)
            //        {
            //            Console.WriteLine(exc.Message);
            //        }
            //        kickoffRead();
            //    }, null);
            //};
            // kickoffRead();
        }


        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            button1.Text = "Connect";
            connectionStatus.ForeColor = Color.Red;
            connectionStatus.Text = "Baglanti Yok";
            pot.Enabled = false;
            

        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#TEXT" + textBox1.Text + "#\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (isConnected)
            {
                disconnectFromArduino();
            }
            else {
                connectToArduino();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected)
                disconnectFromArduino();
           
        }

        private void pot_Tick(object sender, EventArgs e)
        {
            
            if (isConnected)
            {
                try
                {
                    //int receiveddata = Convert.ToInt16(port.ReadExisting());
                      
                    data = port.ReadExisting();


                    if (data.Contains("b"))
                    {
                      
                        MessageBox.Show("Tavşan götünü sikeyim Emirhan", "Emirhan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Console.WriteLine(data.IndexOf("pot"));
                    Console.WriteLine(data.IndexOf("/"));
                    Console.WriteLine(data);
                    data = data.Substring(data.IndexOf("pot")+3, data.IndexOf("/")-3);
                    Console.WriteLine(data);


                    if (speed == int.Parse(data)) isSpeedChanged = false;
                    else isSpeedChanged = true;

                    if (isSpeedChanged)
                    {
                        speed = int.Parse(data);
                        isSpeedChanged = false;
                    }
                    
                    txtPot.Text = data;





                }
                catch
                {
                   
                }
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            //txtSound.Text =  defaultPlaybackDevice.Volume.ToString();
            


            var gpus = PhysicalGPU.GetPhysicalGPUs();
            gbGPU.Text = gpus[0].FullName;

            foreach (var temp in gpus[0].ThermalInformation.ThermalSensors)
            {
                txtTemp.Text = temp.CurrentTemperature.ToString();

            }

            foreach (var cooler in gpus[0].CoolerInformation.Coolers)
            {
                switch (cooler.CoolerId)
                {
                    case 1:
                        txtFan1.Text = cooler.CurrentLevel.ToString();
                        break;
                    case 2:
                        txtFan2.Text = cooler.CurrentLevel.ToString();
                        break;
                }

            }
          
            //foreach (PhysicalGPU physicalGPUs in PhysicalGPU.GetPhysicalGPUs())
            //{
            //    physicalGPUs.CoolerInformation.SetCoolerSettings(2, NvAPIWrapper.Native.GPU.CoolerPolicy.Manual, 99);
            //    // physicalGPUs.CoolerInformation.SetCoolerSettings(0, NvAPIWrapper.Native.GPU.CoolerPolicy.Manual, 99);
            //}
        }

        private void btnSetSpeed_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                var gpus = PhysicalGPU.GetPhysicalGPUs();
                
                gpus[0].CoolerInformation.SetCoolerSettings(1, NvAPIWrapper.Native.GPU.CoolerPolicy.Manual, speed);
                gpus[0].CoolerInformation.SetCoolerSettings(2, NvAPIWrapper.Native.GPU.CoolerPolicy.Manual, speed);
            }

        }

        private void btnSound_Click(object sender, EventArgs e)
        {
           CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
           defaultPlaybackDevice.Volume = int.Parse(txtPot.Text);
        }
    }
}
