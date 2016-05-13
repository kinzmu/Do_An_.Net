using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BUS;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace KTX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SinhVienBUS a = new SinhVienBUS();
            a.getOneSV("102130213");
        }

        

        private void link_DK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDK Form_DK = new FormDK();
            this.Visible = false;
            Form_DK.ShowDialog();
            this.Visible = true;
        }

        private void but_login_Click_1(object sender, EventArgs e)
        {
            SinhVienBUS a = new SinhVienBUS();
            if (!a.Login(text_MSSV.Text, text_PassWord.Text))
            {
                MessageBox.Show("Thông Tin Đăng Nhập Sai!");
                return;
            }
            else
            {
                Form_TTSV Form_TTSV1 = new Form_TTSV(text_MSSV.Text);
                this.Visible = false;
                Form_TTSV1.ShowDialog();
                this.Visible = true;
            }
        }
    }
}
