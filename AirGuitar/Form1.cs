using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace AirGuitar
{
    public partial class Form1 : Form
    {

        private TcpListener tlsClient;
        private TcpClient tcpClient;
        StreamReader srReceiver;
        private Thread ReceiveAndroid;

        public Form1()
        {
            InitializeComponent();
        }

        public void connectAndroid()
        {
            tlsClient = new TcpListener(7777);
            tlsClient.Start();
            tcpClient = tlsClient.AcceptTcpClient();
            srReceiver = new System.IO.StreamReader(tcpClient.GetStream());

            ReceiveAndroid = new Thread(receive);
            ReceiveAndroid.IsBackground = true;
            ReceiveAndroid.Start();
        }
        private void receive()
        {
        }
    }
}
