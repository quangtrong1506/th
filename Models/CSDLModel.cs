using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace API_Web_1.Models
{
    public partial class CSDLModel : DbContext
    {
        public CSDLModel()
            : base("name=CSDLModel")
        {
        }

        public virtual DbSet<NV> NV { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NV>()
                .Property(e => e.MNV)
                .IsFixedLength();
        }
    }
}
