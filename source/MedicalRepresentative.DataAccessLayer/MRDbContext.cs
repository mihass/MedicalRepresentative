using System.Data.Entity;
using MedicalRepresentative.DataAccessLayer.Entities;

namespace MedicalRepresentative.DataAccessLayer
{
    public class MRDbContext: DbContext
    {
        public DbSet<Institute> Institutes { get; set; }

        public MRDbContext() : base("MRConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Institute>()
                .Property(x => x.Name)
                .HasMaxLength(255);


        }
    }
}
