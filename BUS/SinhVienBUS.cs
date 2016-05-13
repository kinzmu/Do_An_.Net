using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVienBUS
    {
        public SinhVien getOneSV(string MSSV)
        {
            SinhVienDAO dao = new SinhVienDAO();
            return dao.getOneSV(MSSV);
            
        }
        public bool Login(string MSSV, string pass)
        {
            SinhVienDAO dao = new SinhVienDAO();
            return dao.login(MSSV,pass);
        }
        public SinhVien show_SV(string MSSV)
        {
            SinhVienDAO dao = new SinhVienDAO();
            return dao.show_SVDAO(MSSV);
        }
        public bool add_SinhVienBUS(string MSSV, string pass, string ho_Ten, bool gioi_Tinh, DateTime ngay_Sinh, string khoa, string lop, string id_Phong, bool dk_Int)
        {
            SinhVienDAO dao = new SinhVienDAO();
            return dao.add_SinhVien(MSSV, pass, ho_Ten, gioi_Tinh, ngay_Sinh, khoa, lop, id_Phong,dk_Int);

        }
        
    }
}
