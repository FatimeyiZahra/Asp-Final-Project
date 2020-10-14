using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class ClientPhotoConfiguration : IEntityTypeConfiguration<ClientPhoto>
    {
        public void Configure(EntityTypeBuilder<ClientPhoto> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasOne(m => m.Client)
                .WithMany(m => m.ClientPhotos)
                .HasForeignKey(m => m.ClientId);

            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();

            builder.ToTable("ClientPhotos");
        }
    }
}
