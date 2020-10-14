using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class QualityPhotoConfiguration : IEntityTypeConfiguration<QualityPhoto>

    {
        public void Configure(EntityTypeBuilder<QualityPhoto> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasOne(m => m.QualityWork)
                .WithMany(m => m.QualityPhotos)
                .HasForeignKey(m => m.QualityWorkId);

            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();

            builder.ToTable("QualityPhotos");
        }
    }
}
