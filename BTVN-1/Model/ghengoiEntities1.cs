using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTVN_1.Model
{
    public partial class ghengoiEntities1 : DbContext
    {
        public ghengoiEntities1()
            : base("name=ghengoiEntities11")
        {
        }

        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<Table_2> Table_2 { get; set; }
        public virtual DbSet<Table_3> Table_3 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_1>()
                .Property(e => e.TenGhe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.LoaiGhe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Table_2>()
                .Property(e => e.LoaiGhe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Table_3>()
                .Property(e => e.GheDaDat)
                .IsUnicode(false);
        }
    }
}
