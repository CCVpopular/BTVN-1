namespace BTVN_1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_3
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TenKhachHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(400)]
        public string GheDaDat { get; set; }

        [Key]
        [Column(Order = 2)]
        public double ThanhTien { get; set; }
    }
}
