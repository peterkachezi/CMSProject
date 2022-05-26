using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CMS1.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NeoFileAssociations> NeoFileAssociations { get; set; }
        public virtual DbSet<NeoFiles> NeoFiles { get; set; }
        public virtual DbSet<NeoFolders> NeoFolders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NeoFileAssociations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEO_FileAssociations");

                entity.Property(e => e.Active).HasComment("1");

                entity.Property(e => e.Dtcreated)
                    .HasColumnName("DTCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dtmodified)
                    .HasColumnName("DTModified")
                    .HasColumnType("datetime")
                    .HasComment("NULL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<NeoFiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEO_Files");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Cur)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Dtcreated)
                    .HasColumnName("DTCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dtmodified)
                    .HasColumnName("DTModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileHistoryId)
                    .IsRequired()
                    .HasColumnName("FileHistoryID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.Uid).HasColumnName("UID");
            });

            modelBuilder.Entity<NeoFolders>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEO_Folders");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Dtcreated)
                    .HasColumnName("DTCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dtmodified)
                    .HasColumnName("DTModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.FolderId)
                    .HasColumnName("FolderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FolderTreeId)
                    .IsRequired()
                    .HasColumnName("FolderTreeID")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uid).HasColumnName("UID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
