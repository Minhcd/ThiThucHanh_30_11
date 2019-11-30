using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThiGK_30_11.Models
{
    public class NhanVien
    {
        [Key]
        public int MaNV { get; set; }
        [Column("nvarchar(100)")]
        [Required]
        public string TenNV { get; set; }
        public float Luong { get; set; }
        public int? MaPB { get; set; }
        [ForeignKey("MaPB")]
        public PhongBan phongban { get; set; }
    }
}
