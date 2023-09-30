namespace BTVN_1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STT { get; set; }

        [Required]
        [StringLength(3)]
        public string TenGhe { get; set; }

        [Required]
        [StringLength(1)]
        public string LoaiGhe { get; set; }

        public byte? TrangThai { get; set; }
    }
}
