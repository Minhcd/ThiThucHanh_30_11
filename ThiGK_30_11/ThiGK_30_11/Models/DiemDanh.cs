using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThiGK_30_11.Models
{
    public class DiemDanh
    {
        [Key]
        public int MaDD { get; set; }
        public int Thang { get; set; }
        public int Tuan { get; set; }
        public string TenNV { get; set; }
        public bool T2 { get; set; }
        public bool T3 { get; set; }
        public bool T4 { get; set; }
        public bool T5 { get; set; }
        public bool T6 { get; set; }
    }
}
