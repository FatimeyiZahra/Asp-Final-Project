using Data.Configurations;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new ClientPhotoConfiguration());
            builder.ApplyConfiguration(new CorporxConfiguration());
            builder.ApplyConfiguration(new NewsConfiguration());
            builder.ApplyConfiguration(new QualityWorkConfiguration());
            builder.ApplyConfiguration(new QualityPhotoConfiguration());
            builder.ApplyConfiguration(new ServicesConfiguration());
            builder.ApplyConfiguration(new TeamConfiguration());
            builder.ApplyConfiguration(new TeamPhotoConfiguration());
            builder.ApplyConfiguration(new NewsCategoryConfiguration());
            builder.ApplyConfiguration(new QualityWorkCategoryConfiguration());

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ClientPhoto> ClientPhotos { get; set; }
        public DbSet<Corporx> Corporxes { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<QualityPhoto> QualityPhotos { get; set; }
        public DbSet<QualityWork> QualityWorks { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamPhoto> TeamPhotos { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<QualityWorkCategory> QualityWorkCategories { get; set; }




    }
}

