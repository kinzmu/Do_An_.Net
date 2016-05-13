using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BUS;
using DTO;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace KTX
{
    public partial class Form_TTSV : Form
    {
        public string MSSV1;

        public Form_TTSV()
        {
            InitializeComponent();

        }

        public Form_TTSV(string MSSV)
        {
            InitializeComponent();
            MSSV1 = MSSV; 
        }
        private void Form_TTSV_Load(object sender, EventArgs e)
        {

            // show thông tin SV
            SinhVienBUS a = new SinhVienBUS();
            SinhVien show_SV = a.show_SV(MSSV1);
            txt_MSSV.Text = show_SV.MSSV;
            txt_Name.Text = show_SV.ho_Ten;
            txt_Khoa.Text = show_SV.khoa;
            txt_Lop.Text = show_SV.lop;
            txt_NgaySinh.Text = show_SV.ngay_Sinh.ToString();
            if (show_SV.gioi_Tinh) ck_Nam.Checked = true; else ck_Nu.Checked = true;
            if (show_SV.dk_Int) ck_Int.Checked = true;
            string id_Phong = show_SV.id_Phong;
            // show thông tin phòng ốc.
            PhongKTX_BUS b = new PhongKTX_BUS();
            phongKTX show_PKTX = b.show_PKTX(id_Phong);
            txt_GiaTien.Text = show_PKTX.gia_Tien;
            txt_SoLuong.Text = show_PKTX.so_Nguoi.ToString();
            cb_Phong.Text = show_PKTX.id_Phong.ToString();
            cb_Phong.Items.Add(show_PKTX.id_Phong);

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
