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
            byte[] msg_buffer = new byte[1024];


            int read;
            while ((read = await stream.ReadAsync(msg_buffer, 0, msg_buffer.Length)) > 0)
            {
                string msg = Encoding.Default.GetString(msg_buffer, 0, read); //읽은 데이터를 문자열로 변환
                listBox_msg.Items.Add(msg); //리스트박스에 추가
            }
        }
    }
}
