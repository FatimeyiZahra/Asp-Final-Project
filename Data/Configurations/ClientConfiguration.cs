using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
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
                .Property(m => m.FullName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Comment)
                .HasMaxLength(500)
                .IsRequired();
            builder
               .Property(m => m.WorkPosition)
               .HasMaxLength(50)
               .IsRequired();


            builder.ToTable("Clients");
        }
    }
}
