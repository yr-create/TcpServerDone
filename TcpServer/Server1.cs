using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace TcpServer
{
	public partial class Server1 : Form
	{
		// インスタンス生成
		tcpserver tcp = new tcpserver();
		public Server1()
		{
			InitializeComponent();

			tcp.logtextBox = textBox2;
			tcp.tcpdelegate = invoketextUpdate;

		}

		public delegate void DelegateUpdateText(string word);
		private void textUpdate(string word)
        {
			
			textBox2.Text = word;
        }

		private void invoketextUpdate(string text)
        {
			this.Invoke(new DelegateUpdateText(this.textUpdate), text);
        }


		private void button3_Click(object sender, EventArgs e)
		{
			Server2 server2 = new Server2();
			server2.Show();
		}



		private async void button1_Click(object sender, EventArgs e)
		{
			button1.Enabled = false;
			if (!await tcp.StartListening(int.Parse("1024")))
			{
				button1.Enabled = true;
			}
		}

		public void calltcpMethod()
        {
			
        }

	}
}
