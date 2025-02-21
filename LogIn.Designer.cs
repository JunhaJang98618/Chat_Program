namespace Chat_Program
{
    partial class LogIn
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ID = new System.Windows.Forms.Label();
            this.button_LOGIN = new System.Windows.Forms.Button();
            this.label_PW = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.label_LoginTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Noto Sans KR", 15F, System.Drawing.FontStyle.Bold);
            this.label_ID.ForeColor = System.Drawing.Color.CadetBlue;
            this.label_ID.Location = new System.Drawing.Point(130, 162);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(41, 36);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            // 
            // button_LOGIN
            // 
            this.button_LOGIN.Font = new System.Drawing.Font("Noto Sans KR", 15F, System.Drawing.FontStyle.Bold);
            this.button_LOGIN.ForeColor = System.Drawing.Color.CadetBlue;
            this.button_LOGIN.Location = new System.Drawing.Point(461, 162);
            this.button_LOGIN.Name = "button_LOGIN";
            this.button_LOGIN.Size = new System.Drawing.Size(143, 88);
            this.button_LOGIN.TabIndex = 4;
            this.button_LOGIN.Text = "로그인";
            this.button_LOGIN.UseVisualStyleBackColor = true;
            this.button_LOGIN.Click += new System.EventHandler(this.button_LOGIN_Click);
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Font = new System.Drawing.Font("Noto Sans KR", 15F, System.Drawing.FontStyle.Bold);
            this.label_PW.ForeColor = System.Drawing.Color.CadetBlue;
            this.label_PW.Location = new System.Drawing.Point(130, 220);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(55, 36);
            this.label_PW.TabIndex = 5;
            this.label_PW.Text = "PW";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_ID.Location = new System.Drawing.Point(215, 162);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(200, 30);
            this.textBox_ID.TabIndex = 2;
            // 
            // textBox_PW
            // 
            this.textBox_PW.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_PW.Location = new System.Drawing.Point(215, 220);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(200, 30);
            this.textBox_PW.TabIndex = 6;
            this.textBox_PW.UseSystemPasswordChar = true;
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_SignUp.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_SignUp.ForeColor = System.Drawing.Color.CadetBlue;
            this.button_SignUp.Location = new System.Drawing.Point(461, 280);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(143, 40);
            this.button_SignUp.TabIndex = 7;
            this.button_SignUp.Text = "회원가입";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // label_LoginTitle
            // 
            this.label_LoginTitle.AutoSize = true;
            this.label_LoginTitle.BackColor = System.Drawing.Color.CadetBlue;
            this.label_LoginTitle.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_LoginTitle.ForeColor = System.Drawing.Color.White;
            this.label_LoginTitle.Location = new System.Drawing.Point(-2, 3);
            this.label_LoginTitle.Name = "label_LoginTitle";
            this.label_LoginTitle.Size = new System.Drawing.Size(112, 49);
            this.label_LoginTitle.TabIndex = 18;
            this.label_LoginTitle.Text = "로그인";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 61);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.label_LoginTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.button_LOGIN);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_ID);
            this.Name = "LogIn";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_LOGIN;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Label label_LoginTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

