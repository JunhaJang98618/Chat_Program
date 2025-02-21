using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace Chat_Program
{
    public partial class SignUp : Form
    {
        private FirestoreDb db;
        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            //화면 로드시 파이어 베이스 연결
            string path = AppDomain.CurrentDomain.BaseDirectory + @"chatting-9551e-firebase-adminsdk-fbsvc-520ac91080.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("chatting-9551e");
        }
        private void button_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Signup_Click_1(object sender, EventArgs e)
        {
            var user_data = db.Collection("UserData"); // 컬렉션 이름
            var user_list = user_data.GetSnapshotAsync().Result;
            if (user_list.Documents.Any(doc => doc.Id == textBox_ID.Text))
            {
                MessageBox.Show("중복된 ID가 있습니다. 다른 아이디를 입력하세요.");
            }else if(textBox_PW.Text != "" && textBox_ID.Text != "")
            {
                DocumentReference DOC = db.Collection("UserData").Document(textBox_ID.Text);
                Dictionary<string, object> data1 = new Dictionary<string, object>()
                {
                    {"PW", textBox_PW.Text }
                };
                DOC.SetAsync(data1);
                MessageBox.Show("회원가입이 완료 되었습니다.");
                this.Close();
            }else
            {
                MessageBox.Show("아이디와 비밀번호를 입력해 주세요.");
            }
        }


    }

}
