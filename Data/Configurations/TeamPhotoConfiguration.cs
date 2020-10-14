using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    class TeamPhotoConfiguration : IEntityTypeConfiguration<TeamPhoto>
    {
        public void Configure(EntityTypeBuilder<TeamPhoto> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasOne(m => m.Team)
                .WithMany(m => m.TeamPhotos)
                .HasForeignKey(m => m.TeamId);

            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();

            builder.ToTable("TeamPhotos");
        }
    }
}