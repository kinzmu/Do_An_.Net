using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTX
{
    public partial class FormDK : Form
    {
        public FormDK()
        {
            InitializeComponent();
        }

        private void ck_Nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormDK_Load(object sender, EventArgs e)
        {
            PhongKTX_BUS show_Phong = new PhongKTX_BUS();
            phongKTX phong = new phongKTX();
            LoadComboBoxPhong();

        }

        void LoadComboBoxPhong()
        {
            List<phongKTX> result = new PhongKTX_BUS().GetAllPhong();
            foreach(var item in result)
            {
                cb_Phong.Items.Add(item.id_Phong);
            }
        }

        private void btn_DK_Click(object sender, EventArgs e)
        {
            SinhVienBUS SV = new SinhVienBUS();
            PhongKTX_BUS Phong = new PhongKTX_BUS();
            if (txt_Pass.ToString() != txt_RePass.ToString()) // Kiểm tra khớp Mật khẩu khi Đăng Ký
            {
                MessageBox.Show("Mật Khẩu nhập không khớp!!!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Phong.add_SV(cb_Phong.SelectedItem.ToString());
                if (SV.add_SinhVienBUS(txt_MSSV.Text, txt_Pass.Text, txt_Name.Text, rad_Nam.Checked, DateTime.Parse(ngay_Sinh.Value.ToString()), txt_Khoa.Text, txt_Lop.Text, cb_Phong.SelectedItem.ToString(), ck_Int.Checked))
                {
                    MessageBox.Show("Đăng Ký Thành Công!!!", "Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Đăng Ký không Thành Công!!!", "Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cb_Phong_TextChanged(object sender, EventArgs e)
        {
            PhongKTX_BUS Phong = new PhongKTX_BUS();
            phongKTX Show_P =  Phong.show_PKTX(cb_Phong.Text);
            txt_SoLuong.Text = Show_P.so_Nguoi.ToString();
            txt_GiaTien.Text = Show_P.gia_Tien;
        }

        private void cb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
