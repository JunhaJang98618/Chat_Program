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
using Google.Protobuf.WellKnownTypes;

namespace Chat_Program
{
    public partial class ClientChat : Form
    {
        private string _user_id;
        public ClientChat(string id)
        {
            InitializeComponent();
            _user_id = id;
            label_id.Text = _user_id;
        }
        private TcpClient client;

        private async void button_Start_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            await client.ConnectAsync(IPAddress.Parse("127.0.0.1"), 8080);

            // 클라이언트 접속 시 user_id 전송
            NetworkStream stream = client.GetStream();
            ChatHub hub = new ChatHub()
            {
                user_id = _user_id,
                message = "" // 메시지를 빈 문자열로 설정하여 접속 알림용으로 사용
            };

            var msg_buffer = Encoding.Default.GetBytes(hub.ToJsonString);
            var length_buffer = BitConverter.GetBytes(msg_buffer.Length);

            await stream.WriteAsync(length_buffer, 0, length_buffer.Length);
            await stream.WriteAsync(msg_buffer, 0, msg_buffer.Length);

            _ = handleClient(client);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            NetworkStream stream = client.GetStream();
            ChatHub hub = new ChatHub()
            {
                user_id = _user_id,
                message = textBox1.Text,

            };
            var msg_buffer = Encoding.Default.GetBytes(hub.ToJsonString);
            var length_buffer = BitConverter.GetBytes(msg_buffer.Length);

            stream.Write(length_buffer, 0, length_buffer.Length);
            stream.Write(msg_buffer, 0, msg_buffer.Length);

        }

        private async Task handleClient(TcpClient client) //클라이언트와 통신
        {

            NetworkStream stream = client.GetStream(); //클라이언트와 데이터 공유
            byte[] size_buffer = new byte[4];
            int read;

            while (true)
            {
                read = await stream.ReadAsync(size_buffer, 0, size_buffer.Length);
                if (read == 0)
                {
                    break;
                }
                int size = BitConverter.ToInt32(size_buffer, 0);
                byte[] msg_buffer = new byte[size];
                int mgs_read = await stream.ReadAsync(msg_buffer, 0, msg_buffer.Length);
                string msg = Encoding.Default.GetString(msg_buffer, 0, mgs_read); //읽은 데이터를 문자열로 변환
                listBox_msg.Items.Add(msg); //리스트박스에 추가

            }
        }
    }
}