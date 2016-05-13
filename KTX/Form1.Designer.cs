namespace KTX
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_MSSV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_PassWord = new System.Windows.Forms.TextBox();
            this.link_DK = new System.Windows.Forms.LinkLabel();
            this.link_QMK = new System.Windows.Forms.LinkLabel();
            this.but_login = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ký Túc Xá Đại Học Bách Khoa Đà Nẵng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_MSSV
            // 
            this.text_MSSV.Location = new System.Drawing.Point(79, 19);
            this.text_MSSV.Name = "text_MSSV";
            this.text_MSSV.Size = new System.Drawing.Size(100, 20);
            this.text_MSSV.TabIndex = 1;
            this.text_MSSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_PassWord);
            this.groupBox1.Controls.Add(this.text_MSSV);
            this.groupBox1.Location = new System.Drawing.Point(118, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MSSV       :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_PassWord
            // 
            this.text_PassWord.Location = new System.Drawing.Point(79, 55);
            this.text_PassWord.Name = "text_PassWord";
            this.text_PassWord.PasswordChar = '*';
            this.text_PassWord.Size = new System.Drawing.Size(100, 20);
            this.text_PassWord.TabIndex = 2;
            this.text_PassWord.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // link_DK
            // 
            this.link_DK.AutoSize = true;
            this.link_DK.Location = new System.Drawing.Point(143, 201);
            this.link_DK.Name = "link_DK";
            this.link_DK.Size = new System.Drawing.Size(47, 13);
            this.link_DK.TabIndex = 4;
            this.link_DK.TabStop = true;
            this.link_DK.Text = "Đăng ký";
            this.link_DK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_DK_LinkClicked);
            // 
            // link_QMK
            // 
            this.link_QMK.AutoSize = true;
            this.link_QMK.Location = new System.Drawing.Point(236, 201);
            this.link_QMK.Name = "link_QMK";
            this.link_QMK.Size = new System.Drawing.Size(82, 13);
            this.link_QMK.TabIndex = 5;
            this.link_QMK.TabStop = true;
            this.link_QMK.Text = "Quên Mật Khẩu";
            // 
            // but_login
            // 
            this.but_login.Location = new System.Drawing.Point(185, 174);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(75, 23);
            this.but_login.TabIndex = 6;
            this.but_login.Text = "Đăng Nhập";
            this.but_login.Click += new System.EventHandler(this.but_login_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 303);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.link_QMK);
            this.Controls.Add(this.link_DK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_MSSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_PassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_DK;
        private System.Windows.Forms.LinkLabel link_QMK;
        private DevExpress.XtraEditors.SimpleButton but_login;
    }
}

