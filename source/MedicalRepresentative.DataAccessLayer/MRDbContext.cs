using System.Data.Entity;
using MedicalRepresentative.DataAccessLayer.Entities;

namespace MedicalRepresentative.DataAccessLayer
{
    public class MRDbContext: DbContext
    {
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Worker> Workers { get; set; }
        
        public MRDbContext() : base("MRConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Institute>()
                .Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Occupation>()
                .Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Worker>()
                .Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Worker>()
                .HasRequired(x => x.Institute)
                .WithMany()
                .HasForeignKey(x => x.InstituteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Worker>()
                .HasRequired(x => x.Occupation)
                .WithMany()
                .HasForeignKey(x => x.OccupationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Report>()
                .HasRequired(x => x.Worker)
                .WithMany()
                .HasForeignKey(x => x.WorkerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Report>()
                .Property(x => x.Date)
                .IsRequired();
        }
    }
}
