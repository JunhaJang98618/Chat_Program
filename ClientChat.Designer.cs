﻿namespace Chat_Program
{
    partial class ClientChat
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
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_chat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_msg = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.White;
            this.button_Stop.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Stop.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_Stop.Location = new System.Drawing.Point(669, 12);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(114, 42);
            this.button_Stop.TabIndex = 10;
            this.button_Stop.Text = "채팅 종료";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.White;
            this.button_Start.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Start.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_Start.Location = new System.Drawing.Point(533, 12);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(114, 42);
            this.button_Start.TabIndex = 9;
            this.button_Start.Text = "채팅 시작";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_chat
            // 
            this.label_chat.AutoSize = true;
            this.label_chat.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_chat.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_chat.ForeColor = System.Drawing.Color.White;
            this.label_chat.Location = new System.Drawing.Point(7, 5);
            this.label_chat.Name = "label_chat";
            this.label_chat.Size = new System.Drawing.Size(316, 49);
            this.label_chat.TabIndex = 8;
            this.label_chat.Text = "Chat, Chat! 😃😃";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 61);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "메세지";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Noto Sans KR Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(81, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(609, 34);
            this.textBox1.TabIndex = 13;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_id.Font = new System.Drawing.Font("Noto Sans KR", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_id.ForeColor = System.Drawing.Color.Silver;
            this.label_id.Location = new System.Drawing.Point(320, 9);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(112, 39);
            this.label_id.TabIndex = 14;
            this.label_id.Text = "User ID";
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.White;
            this.button_send.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_send.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_send.Location = new System.Drawing.Point(707, 69);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(76, 38);
            this.button_send.TabIndex = 15;
            this.button_send.Text = "전송";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Noto Sans KR", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(625, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 17;
            // 
            // listBox_msg
            // 
            this.listBox_msg.FormattingEnabled = true;
            this.listBox_msg.ItemHeight = 15;
            this.listBox_msg.Location = new System.Drawing.Point(16, 113);
            this.listBox_msg.Name = "listBox_msg";
            this.listBox_msg.Size = new System.Drawing.Size(767, 319);
            this.listBox_msg.TabIndex = 19;
            // 
            // ClientChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.listBox_msg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_chat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClientChat";
            this.Text = "Chat, Chat! 😃😃";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_chat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_msg;
    }
}