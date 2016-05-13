using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        [Key]
        public string MSSV { set; get; }
        public string password { set; get; }
        public string ho_Ten { set; get; }
        public bool gioi_Tinh { set; get; }
        public DateTime ngay_Sinh { set; get; }

        public string khoa { set; get; }
        public string lop { set; get; }

        public string id_Phong { set; get; }
        public bool dk_Int { set; get; }



        [ForeignKey("id_Phong")]
        public virtual phongKTX lktx { set; get; }

        public SinhVien() { }

        public SinhVien(string MSSV, string password, string ho_Ten, bool gioi_Tinh, DateTime ngay_Sinh, string khoa, string lop, string id_Phong,bool dk_Int)
        {
            this.MSSV = MSSV;
            this.password = password;
            this.ho_Ten = ho_Ten;
            this.gioi_Tinh = gioi_Tinh;
            this.ngay_Sinh = ngay_Sinh;
            this.khoa = khoa;
            this.lop = lop;
            this.dk_Int = dk_Int;
            this.id_Phong = id_Phong;
            
        }


    }
}
