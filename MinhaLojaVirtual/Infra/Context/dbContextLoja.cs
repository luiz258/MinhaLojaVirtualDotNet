
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinhaLojaVirtual.Models;

namespace MinhaLojaVirtual.Infra.Context
{
    public class dbContextLoja: DbContext
    {s
        public dbContextLoja()
        {

        }
        public dbContextLoja(DbContextOptions<dbContextLoja> options) : base(options) { }

        public DbSet<UserModel> Users{ get; set; }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserModel>(Entity =>
            {
                Entity.HasKey(u => u.id);

                Entity.Property(u => u.name)
                    .IsRequired(true);
                    
                Entity.Property(u => u.email)
                    .IsRequired(true);

                Entity.Property(u => u.password)
                    .IsRequired(true);

            });

            builder.Entity<ProductModel>(Entity =>
            {
                Entity.HasKey(u => u.id);

                Entity.Property(u => u.name)
                    .IsRequired(true);

                Entity.Property(u => u.value)
                    .IsRequired(true);

                Entity.Property(u => u.quantity)
                    .IsRequired(true);

                Entity.Property(u => u.isActive)
                    .IsRequired(true);

                Entity.Property(u => u.description)
                    .IsRequired(true);

            });
        }

    }
}
