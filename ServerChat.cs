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
        private TcpListener _listener;
        private List<TcpClient> clients = new List<TcpClient>(); // 연결된 클라이언트 목록

        private async void button_Start_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = false;
            _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            _listener.Start(); //서버 시작
            //client와 동시에 통신 가능
            while (true)
            {
                TcpClient client = await _listener.AcceptTcpClientAsync();
                _ = HandleClient(client);
            }

        }

        private async Task HandleClient(TcpClient client) //클라이언트와 통신
        {
            clients.Add(client);
            NetworkStream stream = client.GetStream(); //클라이언트와 데이터 공유
            //접속알림
            byte[] size_buffer = new byte[4];
            int read = await stream.ReadAsync(size_buffer, 0, size_buffer.Length);
            if (read == 0)
            {
                return;
            }

            int size = BitConverter.ToInt32(size_buffer, 0);
            byte[] msg_buffer = new byte[size];
            int msg_read = await stream.ReadAsync(msg_buffer, 0, msg_buffer.Length);

            string msg = Encoding.Default.GetString(msg_buffer, 0, msg_read);
            var hub = ChatHub.Parse(msg);

            // 접속 알림 메시지 추가
            string join_message = $"{hub.user_id}님이 접속하였습니다.";
            BroadcastMessage(join_message);
            listBox1.Items.Add(join_message);
            listBox2.Items.Add(hub.user_id);    

            //채팅 메세지 수신
            while (true)
            {
                read = await stream.ReadAsync(size_buffer, 0, size_buffer.Length);
                if (read == 0)
                {
                    string leaveMessage = $"{hub.user_id}님이 나갔습니다.";
                    BroadcastMessage(leaveMessage);
                    listBox1.Items.Add(leaveMessage);
                    listBox2.Items.Remove(hub.user_id);
                    break;
                }

                size = BitConverter.ToInt32(size_buffer, 0);
                msg_buffer = new byte[size];
                int mgs_read = await stream.ReadAsync(msg_buffer, 0, msg_buffer.Length);

                msg = Encoding.Default.GetString(msg_buffer, 0, mgs_read); //읽은 데이터를 문자열로 변환

                hub = ChatHub.Parse(msg);
                if (hub.message == "")
                {
                    continue;
                }

                string chat_message = $"{hub.user_id}: {hub.message}";
                BroadcastMessage(chat_message);
                listBox1.Items.Add(chat_message); //리스트박스에 추가
            }
        }


        private void BroadcastMessage(string message)
        {
            byte[] msg_buffer = Encoding.Default.GetBytes(message);
            byte[] size_buffer = BitConverter.GetBytes(msg_buffer.Length);

            foreach (var client in clients)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(size_buffer, 0, size_buffer.Length);
                    stream.Write(msg_buffer, 0, msg_buffer.Length);
                }
                catch
                {
                    clients.Remove(client);
                }
            }
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}