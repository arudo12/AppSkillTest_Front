using Microsoft.EntityFrameworkCore;

namespace App_Front.Models.DbModel
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ms_storage_location> ms_storage_location { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=SkillTestMCF;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<ms_storage_location>(entity =>
            {
                entity.ToTable("ms_storage_location", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.location_id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.location_name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
