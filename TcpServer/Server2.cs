using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpServer
{
    public partial class Server2 : Form
    {
        public Server2()
        {
            InitializeComponent();
            textBox1.Text = "192.168.11.2";
            textBox2.Text = "1024";
        }
    }
}
