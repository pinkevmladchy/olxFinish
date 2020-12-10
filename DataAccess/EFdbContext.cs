using DataAccess.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    class EFdbContext:IdentityDbContext<User>
    {
        public EFdbContext(DbContextOptions<EFdbContext> options) : base(options)
        {

        }

        public DbSet<Tovar> Tovars { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Tovar_Image> Tovar_Images { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<UserAdditionalInfo> AdditionalInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasOne(x => x.UserAdditionalInfo)
                .WithOne(x => x.User)
                .HasForeignKey<UserAdditionalInfo>(x => x.Id);

            base.OnModelCreating(builder);
        }
    }
}
