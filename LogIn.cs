using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Api.Gax;
using Google.Cloud.Firestore;

namespace Chat_Program
{
    public partial class LogIn : Form
    {
        private FirestoreDb db;
        public LogIn()
        {
            InitializeComponent();
            this.KeyPreview = true; //키 입력 감지
            this.KeyDown += LogInKeyDown;

        }
        private void login_Load(object sender, EventArgs e)
        {
            //파이어 베이스 연결
            string path = AppDomain.CurrentDomain.BaseDirectory + @"chatting-9551e-firebase-adminsdk-fbsvc-0706a4bc04.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("chatting-9551e");
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            SignUp sign_up = new SignUp();
            sign_up.Show();
        }

        private void button_LOGIN_Click(object sender, EventArgs e)
        {
            LogInChat();
        }
        private void LogInKeyDown(object sender, KeyEventArgs e) //엔터키 감지
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInChat();
            }
        }

        private void LogInChat() //로그인 기능 정의 함수
        {
            var user_data = db.Collection("UserData");
            var user_list = user_data.GetSnapshotAsync().Result;

            var userDoc = user_list.Documents.FirstOrDefault(doc => doc.Id == textBox_ID.Text);//입력한 아이디 비교

            if (userDoc != null)
            {
                // 비밀번호 비교
                string password = userDoc.GetValue<string>("PW"); // Firestore에서 비밀번호 가져오기
                if (password.Equals(textBox_PW.Text)) // 비밀번호 비교
                {
                    MessageBox.Show("로그인 성공!"); // 로그인 성공 메시지
                    this.Hide();

                    if (textBox_ID.Text == "관리자")
                    {
                        ServerChat server = new ServerChat();
                        server.Show();
                        server.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        ClientChat client = new ClientChat(textBox_ID.Text);
                        client.Show();
                        client.FormClosed += (s, args) => this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀렸습니다."); // 비밀번호 불일치 메시지
                }

            }
            else
            {
                MessageBox.Show("가입되지 않은 ID입니다. \n회원 가입을 해주세요.");

            }
        }
    }
}


