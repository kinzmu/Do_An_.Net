using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongKTX_DAO
    {
        public phongKTX show_PKTX(string idPhong)
        {
            DataContext db = new DataContext();
            var p = from k in db.phongKTXs where k.id_Phong == idPhong select k;
            return p.ToArray()[0];
        }
        public void add_SV(string idPhong)
        {
            DataContext db = new DataContext();
            //var p =(phongKTX) (from k in db.phongKTXs where k.id_Phong == idPhong select k).Single();
            phongKTX Phong = db.phongKTXs.FirstOrDefault(x => x.id_Phong == idPhong);
            Phong.so_Nguoi += 1;
            db.SaveChanges(); 

        }

        public List<phongKTX> GetALLPhong()
        {
            DataContext db = new DataContext();
            var result = from phong in db.phongKTXs
                         select phong;
            return result.ToList();
        }
        
    }
}
