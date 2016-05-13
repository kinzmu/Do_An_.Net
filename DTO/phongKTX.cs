using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class phongKTX
    {
        [Key]
        public string id_Phong { set; get; }
        public int so_Nguoi { set; get; }
        public string gia_Tien { set; get; }

        public virtual IEnumerable<SinhVien> lkp { set; get; }

        public phongKTX() { }

        public phongKTX(string id_Phong, int so_Nguoi, string gia_Tien)
        {
            this.id_Phong = id_Phong;
            this.so_Nguoi = so_Nguoi;
            this.gia_Tien = gia_Tien;
            
        }
    }   
}
