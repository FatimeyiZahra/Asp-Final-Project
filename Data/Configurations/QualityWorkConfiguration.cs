using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class QualityWorkConfiguration : IEntityTypeConfiguration<QualityWork>
    {
        public void Configure(EntityTypeBuilder<QualityWork> builder)
        {
            builder
             .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
              .Property(m => m.Status)
              .IsRequired()
              .HasDefaultValue(true);

            builder
               .Property(m => m.Name)
               .HasMaxLength(50)
               .IsRequired();


            builder.ToTable("QualityWorks");


        }
    }
}

//builder
//              .HasOne(m => m.Category)
//               .WithMany(m => m.News)
//               .HasForeignKey(m => m.CategoryId);