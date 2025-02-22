<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLCH.Models
{
    [Table("Thongtintaikhoan")]
    public class Thongtintaikhoan
    {
        [Key]
        public int? bankid { get; set; }


        [Column("BankAccount")]
        public string BankAccount { get; set; }
        public int StoreId { get; set; }
        public string AccountName { get; set; }
        public int AcqId { get; set; }
        public string ShortName { get; set; }
    }
}
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLCH.Models
{
    public class Thongtintaikhoan
    {
        [Key]
        public int? bankid { get; set; }
        public string BankAccount { get; set; }
        public string QRCodeUrl { get; set; }
        public int? StoreId { get; set; }
    }
}
>>>>>>> 2cd039424233f099f062a952f82ef6ddcda03b12
