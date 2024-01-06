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

            // ================= (★Model→Viewのデータ受信練習) ============================
            // 非同期処理開始
            Task.Run(() =>
            {
                byte[] buffer = new Byte[256];
                string responseData = string.Empty;
                NetworkStream stream = _client.GetStream();

                while (true)
                {
                    int count = stream.Read(buffer, 0, buffer.Length);
                    responseData = Encoding.UTF8.GetString(buffer, 0, count);

                    Invoke((MethodInvoker)(() =>
                    {
                        _textBoxLog.AppendText($"Received: {responseData}\r\n");
                    }));
                    _panel1.BackColor = Color.FromArgb(int.Parse(responseData));
                }
            });
        }

        /// <summary>
        /// 送信ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendBtn_Click(object sender, EventArgs e)
        {
            var message = "test Message!";
            Byte[] data = Encoding.UTF8.GetBytes(message);
            NetworkStream stream = _client.GetStream();
            stream.Write(data,0,data.Length);
            _textBoxLog.AppendText($"Sent: {message} \r\n");
        }
    }
}
