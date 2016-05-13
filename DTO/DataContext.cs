using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DataContext: DbContext
    {
        public DbSet<SinhVien> SinhViens { set; get; }
        public DbSet<phongKTX> phongKTXs { set; get; }
        public DataContext():base("name = Database")
        {
            Database.SetInitializer<DataContext>(new TaoDataBase());
        }
        public class TaoDataBase: CreateDatabaseIfNotExists<DataContext>
        {
            protected override void Seed(DataContext context)
            {
                context.SinhViens.Add(new SinhVien ( "102130213", "123", "Lê Ngọc Tân", true,new DateTime(1995,6,1), "CNTT", "13TCLC","1",true ));
                context.SinhViens.Add(new SinhVien("102130214", "123", "Nguyễn Công Hường", false, new DateTime(1995, 6, 1), "CNTT", "13TCLC","2",false));
                context.phongKTXs.Add(new phongKTX("1", 1 , "1000"));
                context.phongKTXs.Add(new phongKTX("2", 2, "2000"));
                context.SaveChanges();
            }
        }

    }
}
