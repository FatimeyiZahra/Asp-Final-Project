using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class QualityWorkCategoryConfiguration : IEntityTypeConfiguration<QualityWorkCategory>
    {
        public void Configure(EntityTypeBuilder<QualityWorkCategory> builder)
        {
            builder
             .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
               .HasOne<Category>(m => m.Category)
               .WithMany(m => m.QualityWorkCategories)
               .HasForeignKey(m => m.CategoryId);

            builder
              .HasOne<QualityWork>(m => m.QualityWork)
              .WithMany(m => m.QualityWorkCategories)
              .HasForeignKey(m => m.QualityWorkId);

            builder.ToTable("QualityWorkCategories");
        }
    }
}
