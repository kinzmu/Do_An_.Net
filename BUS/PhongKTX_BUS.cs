using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhongKTX_BUS
    {
        public phongKTX show_PKTX(string id_Phong)
        {
            PhongKTX_DAO dao = new PhongKTX_DAO();
            return dao.show_PKTX(id_Phong);
        }
        public void add_SV(string id_Phong)
        {
            PhongKTX_DAO dao = new PhongKTX_DAO();
            dao.add_SV(id_Phong);
        }

        public List<phongKTX> GetAllPhong()
        {
            return new PhongKTX_DAO().GetALLPhong();
        }
    }
}
