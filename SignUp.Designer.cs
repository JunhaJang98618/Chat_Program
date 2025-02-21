namespace Chat_Program
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.label_PW = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_Signup = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_signup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_PW
            // 
            this.textBox_PW.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_PW.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox_PW.Location = new System.Drawing.Point(291, 204);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(200, 30);
            this.textBox_PW.TabIndex = 10;
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Font = new System.Drawing.Font("Noto Sans KR", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_PW.ForeColor = System.Drawing.Color.CadetBlue;
            this.label_PW.Location = new System.Drawing.Point(206, 204);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(55, 36);
            this.label_PW.TabIndex = 9;
            this.label_PW.Text = "PW";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_ID.Location = new System.Drawing.Point(291, 140);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(200, 30);
            this.textBox_ID.TabIndex = 8;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Noto Sans KR", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_ID.ForeColor = System.Drawing.Color.CadetBlue;
            this.label_ID.Location = new System.Drawing.Point(206, 140);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(41, 36);
            this.label_ID.TabIndex = 7;
            this.label_ID.Text = "ID";
            // 
            // button_Signup
            // 
            this.button_Signup.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Signup.ForeColor = System.Drawing.Color.CadetBlue;
            this.button_Signup.Location = new System.Drawing.Point(188, 290);
            this.button_Signup.Name = "button_Signup";
            this.button_Signup.Size = new System.Drawing.Size(131, 40);
            this.button_Signup.TabIndex = 13;
            this.button_Signup.Text = "회원가입";
            this.button_Signup.UseVisualStyleBackColor = true;
            this.button_Signup.Click += new System.EventHandler(this.button_Signup_Click_1);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Cancel.ForeColor = System.Drawing.Color.CadetBlue;
            this.button_Cancel.Location = new System.Drawing.Point(374, 290);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(131, 40);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "취소";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 61);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label_signup
            // 
            this.label_signup.AutoSize = true;
            this.label_signup.BackColor = System.Drawing.Color.CadetBlue;
            this.label_signup.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_signup.ForeColor = System.Drawing.Color.White;
            this.label_signup.Location = new System.Drawing.Point(3, 3);
            this.label_signup.Name = "label_signup";
            this.label_signup.Size = new System.Drawing.Size(151, 49);
            this.label_signup.TabIndex = 16;
            this.label_signup.Text = "회원 가입";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.label_signup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Signup);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_ID);
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Name = "SignUp";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_Signup;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_signup;
    }
}