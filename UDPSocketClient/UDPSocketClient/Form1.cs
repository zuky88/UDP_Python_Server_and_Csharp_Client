using System.Net.Sockets;
using System.Net;
using System.Text;
using UDPSocketClient;

namespace UDPSocketClient
{
    public partial class Form1 : Form
    {
        bool start_flg = false;
        const string ipAddress = "127.0.0.1";
        const Int32 port = 50010;

        UdpClient client = new UdpClient();
        IPEndPoint directEp = new IPEndPoint(IPAddress.Parse(ipAddress), port);

        SockModel sockmodel = new SockModel();

        public Form1()
        {
            InitializeComponent();
            client.Connect(directEp);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (start_flg == false)
            {
                start_flg = true;
                this.backgroundWorker1.RunWorkerAsync();
            }

        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            if (start_flg == true)
            {
                start_flg = false;
                this.backgroundWorker1.CancelAsync();
            }
        }

        public void loop()
        {
            while (start_flg)
            {
                string recv = sockmodel.loop(client);
                tbMessage.Invoke(new Action(() =>{
                    tbMessage.Text = recv;
                }));
                btAlive.Invoke(new Action(() =>
                {
                    btAlive.BackColor = sockmodel.update_alive();
                }));
                lbTime.Invoke(new Action(() =>
                {
                    lbTime.Text = sockmodel.get_time();

                }));

                Thread.Sleep(100);

            }

        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            this.loop();
        }
    }
}
