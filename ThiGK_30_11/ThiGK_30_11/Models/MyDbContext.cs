using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThiGK_30_11.Models;

namespace ThiGK_30_11.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }

        public DbSet<PhongBan> PhongBans { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ChamCong> ChamCongs { get; set; }
        public DbSet<ThiGK_30_11.Models.DiemDanh> DiemDanh { get; set; }
    }
}
