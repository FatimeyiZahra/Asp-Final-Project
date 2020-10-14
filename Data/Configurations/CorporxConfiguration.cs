using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class CorporxConfiguration : IEntityTypeConfiguration<Corporx>
    {
        public void Configure(EntityTypeBuilder<Corporx> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder
             .Property(m => m.Adress)
             .HasMaxLength(50)
             .IsRequired();
            builder
             .Property(m => m.PhoneNumber)
             .HasMaxLength(50)
             .IsRequired();
            builder
             .Property(m => m.Email)
             .HasMaxLength(50)
             .IsRequired();

            builder
                .Property(m => m.Logo)
                .HasMaxLength(100)
                .IsRequired();

            builder.ToTable("Corporx");
        }
    }
}
