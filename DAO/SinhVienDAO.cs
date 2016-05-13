using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SinhVienDAO
    {
        public SinhVien getOneSV(string MSSV)
        {
            DataContext db = new DataContext();

            var p = from k in db.SinhViens
                    where k.MSSV == MSSV
                    select k;
            return p.ToArray()[0];

        }

        public bool login(string MSSV, string pass)
        {
            DataContext db = new DataContext();
            bool check = false;
            var a = (from l in db.SinhViens select l.MSSV);
            foreach (var login1 in a)
                if (login1.ToString() == MSSV) check = true;  // Kiểm tra MSSV
            if (check == false) return false;
            else
            {
                var p = (from k in db.SinhViens where k.MSSV == MSSV select k.password);
                if (p.ToArray()[0].ToString() == pass) return true;  // Kiểm tra Pass
                else return false;
            }
        }

        public SinhVien show_SVDAO(string MSSV)
        {
            DataContext db = new DataContext();
            var p = from k in db.SinhViens where k.MSSV == MSSV select k;
            return p.ToArray()[0];
        }

        public bool add_SinhVien(string MSSV, string pass, string ho_Ten, bool gioi_Tinh, DateTime ngay_Sinh, string khoa, string lop, string id_Phong,bool dk_Int)
        {
            try
            {
                DataContext db = new DataContext();
                if (db.SinhViens.FirstOrDefault(x => x.MSSV == MSSV) != null)
                {
                    return false;
                }
                SinhVien sinhvien = new SinhVien(MSSV, pass, ho_Ten, gioi_Tinh, ngay_Sinh, khoa, lop, id_Phong,dk_Int);
                db.SinhViens.Add(sinhvien);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public void login()
        {
            throw new NotImplementedException();
        }
    }
}
