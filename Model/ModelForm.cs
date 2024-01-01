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

namespace MVC_Trace
{
    public partial class ModelForm : Form
    {
        private const Int32 port = 13000;
        private static IPAddress localAddr = IPAddress.Parse("127.0.0.1");
        private TcpListener _server = new TcpListener(localAddr, port);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ModelForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 待ち受け開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartListenBtn_Click(object sender, EventArgs e)
        {
            // サーバー立ち上げ
            try
            {
                _server.Start();
            }
            catch (SocketException ex)
            {

                _textBoxLog.AppendText($"SocketException: {ex}\r\n");
            }

            // 非同期処理開始
            Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        // UI要素を更新
                        Invoke((MethodInvoker)(() =>
                        {
                            _textBoxLog.AppendText("Waiting for a connection... \r\n");
                        }));

                        // クライアントからの接続を待ち受け
                        using (TcpClient client = _server.AcceptTcpClient()) // クライアントからの接続を待ち受け、それが確立されるとそのクライアントと通信するための TcpClient オブジェクトを返します。このメソッドは、クライアントからの接続を受け入れるまでブロックされます。
                        {
                            // UI要素を更新
                            Invoke((MethodInvoker)(() => 
                            {
                                _textBoxLog.AppendText("Connected!\r\n");
                            }));
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            });
        }
    }
}
