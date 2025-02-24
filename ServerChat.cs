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
using System.Security.Cryptography;

namespace Chat_Program
{
    public partial class ServerChat : Form
    {
        public ServerChat()
        {
            InitializeComponent();
        }
        private TcpListener listener;
        private async void button_Start_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Start(); //서버 시작
            //client와 동시에 통신 가능
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                _= handleClient(client);
            }
           
        }

        private async Task handleClient(TcpClient client) //클라이언트와 통신
        {
            NetworkStream stream = client.GetStream(); //클라이언트와 데이터 공유
            byte[] size_buffer = new byte[4];
            int read;

            while (true)
            {
           
                read = await stream.ReadAsync(size_buffer, 0, size_buffer.Length);
                if (read  == 0)
                {
                    break;
                }

                int size = BitConverter.ToInt32(size_buffer, 0);
                byte[] msg_buffer = new byte[size];
                read = await stream.ReadAsync(msg_buffer, 0, msg_buffer.Length);

                string msg = Encoding.Default.GetString(msg_buffer, 0, read); //읽은 데이터를 문자열로 변환

                var hub = ChatHub.Parse(msg);
                listBox1.Items.Add($"{hub.user_id}: {hub.message}"); //리스트박스에 추가
            }
        }
    }
}