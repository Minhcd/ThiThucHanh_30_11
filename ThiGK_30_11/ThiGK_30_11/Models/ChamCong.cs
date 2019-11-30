using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThiGK_30_11.Models
{
    public class ChamCong
    {
        [Key]
        public int MaCC { get; set; }
        [Column("nvarchar(100)")]
        public string TenNV { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int SoNgayLamTrongThang { get; set; }
        public float TongLuong { get; set; }
        public int? MaPB { get; set; }
        [ForeignKey("MaPB")]
        public PhongBan phongban { get; set; }
        public int? MaNV { get; set; }
        [ForeignKey("MaNV")]
        public NhanVien nhanvien { get; set; }
    }
}
