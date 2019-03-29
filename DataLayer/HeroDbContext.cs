using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class HeroDbContext : DbContext
    {
        public HeroDbContext(DbContextOptions<HeroDbContext> options) : base(options)
        {

        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<House> Houses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Hero>()
                .HasOne(b => b.House)
                .WithMany()
                .HasForeignKey(a => a.HouseId);

            // https://github.com/aspnet/EntityFrameworkCore/issues/3924
            // EF Core 2 doesnt support Cascade on delete for in Memory Database

            base.OnModelCreating(builder);
        }
    }
}
