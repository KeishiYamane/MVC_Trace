using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ViewForm : Form
    {
        private const Int32 port = 13000;
        private static IPAddress serverAddr = IPAddress.Parse("127.0.0.1");
        private TcpClient _client;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ViewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 接続ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            // サーバーに接続
            _client = new TcpClient(serverAddr.ToString(),port);
        }
    }
}
