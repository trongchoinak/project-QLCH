<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLCH.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int CTDHId { get; set; }

        public int DonHangId { get; set; }

        public int SanPhamId { get; set; }

        [Required]
        public int SoLuong { get; set; }

        [Required]
        public int Gia { get; set; }

        public DateTime NgayTao { get; set; }

        [ForeignKey("DonHangId")]
        public DonHang DonHang { get; set; }

        [ForeignKey("SanPhamId")]
        public SanPham SanPham { get; set; }
    }
}
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLCH.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int CTDHId { get; set; }

        public int DonHangId { get; set; }

        public int SanPhamId { get; set; }

        [Required]
        public int SoLuong { get; set; }

        [Required]
        public int Gia { get; set; }

        public DateTime NgayTao { get; set; }

        [ForeignKey("DonHangId")]
        public DonHang DonHang { get; set; }

        [ForeignKey("SanPhamId")]
        public SanPham SanPham { get; set; }
    }
}
>>>>>>> 2cd039424233f099f062a952f82ef6ddcda03b12
