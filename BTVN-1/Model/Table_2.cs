namespace BTVN_1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_2
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string LoaiGhe { get; set; }

        [Key]
        [Column(Order = 1)]
        public double DonGia { get; set; }
    }
}
