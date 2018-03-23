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

namespace KeoBuaBao_Client
{
    public partial class Form1 : Form
    {
        EndPoint remote;
        Socket server;
        IPEndPoint ipep;
        public Form1()
        {
            InitializeComponent();
        }
        public void ketNoiServer()
        {
            IPAddress[] ipaddr = Dns.GetHostAddresses("localhost");
            server = new Socket(ipaddr[1].AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            ipep = new IPEndPoint(ipaddr[1], 9055);
            remote = (EndPoint)ipep;
        }

        private void btnKeo_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "Keo";
            byte[] gui = Encoding.ASCII.GetBytes("0");
            server.SendTo(gui,remote);
            byte[] nhan = new byte[10];
            server.ReceiveFrom(nhan,ref remote);
            txtSVC.Text = Encoding.ASCII.GetString(nhan);

            byte[] nhan1 = new byte[20];
            server.ReceiveFrom(nhan1, ref remote);
            txtKq.Text = Encoding.ASCII.GetString(nhan1);

            //System.Threading.Thread.Sleep(3000);
            //DialogResult kq = MessageBox.Show("Ban co muon choi tiep hay ko?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (kq == DialogResult.OK)
            //{
            //    txtChoice.Text = "";
            //    txtSVC.Clear();
            //    txtKq.Clear();
            //}
            //else
            //{
            //    server.Close();
            //    this.Close();
            //}
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "Bao";
            byte[] gui = Encoding.ASCII.GetBytes("2");
            server.SendTo(gui, remote);
            byte[] nhan = new byte[10];
            server.ReceiveFrom(nhan, ref remote);
            txtSVC.Text = Encoding.ASCII.GetString(nhan);

            byte[] nhan1 = new byte[20];
            server.ReceiveFrom(nhan1, ref remote);
            txtKq.Text = Encoding.ASCII.GetString(nhan1);

            //System.Threading.Thread.Sleep(3000);
            //DialogResult kq = MessageBox.Show( "Ban co muon choi tiep hay ko?", "Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //if(kq==DialogResult.OK)
            //{
            //    txtChoice.Text = "";
            //    txtSVC.Clear();
            //    txtKq.Clear();
            //}
            //else
            //{
            //    server.Close();
            //    this.Close();
            //}
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            txtChoice.Text = "Bua";
            byte[] gui = Encoding.ASCII.GetBytes("1");
            server.SendTo(gui, remote);
            byte[] nhan = new byte[10];
            server.ReceiveFrom(nhan, ref remote);
            txtSVC.Text = Encoding.ASCII.GetString(nhan);

            byte[] nhan1 = new byte[20];
            server.ReceiveFrom(nhan1, ref remote);
            txtKq.Text = Encoding.ASCII.GetString(nhan1);

            //System.Threading.Thread.Sleep(3000);
            //DialogResult kq = MessageBox.Show("Ban co muon choi tiep hay ko?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (kq == DialogResult.OK)
            //{
            //    txtChoice.Text = "";
            //    txtSVC.Clear();
            //    txtKq.Clear();
            //}
            //else
            //{
            //    server.Close();
            //    this.Close();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketNoiServer();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Close();
        }
    }
}
