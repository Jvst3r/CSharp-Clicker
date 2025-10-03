using Microsoft.EntityFrameworkCore;
using Сsharp_Clicker.Domain;
namespace Сsharp_Clicker.Infastructure.Implementations
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserBoosts>()
                .HasMany(u => u.UserBoosts)
                .WithOne()
                .HasForeignKey(ub => ub.BoostId);

            modelBuilder.Entity<Boost>()
                .HasMany(b => b.UserBoosts)
                .WithOne()
                .HasForeignKey(ub => ub.BoostId)


            base.OnModelCreating(modelBuilder);
        }
    }
}
