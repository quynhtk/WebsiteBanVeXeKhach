using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BVXK.Domain.Models
{
    public partial class Xe
    {
        public Xe()
        {
            LichTrinhs = new HashSet<LichTrinh>();
        }

        public int IdXe { get; set; }
        public string? TenTaiXe { get; set; }
        public int? LoaiXe { get; set; }
        [RegularExpression("[0-9]{10}")]
        public string? SoDienThoai { get; set; }
        public int? SoLuongGhe { get; set; }
        public string? BienSo { get; set; }

        public virtual ICollection<LichTrinh> LichTrinhs { get; set; }
    }
}
