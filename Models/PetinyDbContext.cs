using Microsoft.EntityFrameworkCore;
using PetinyAPI.Models;

namespace PetinyAPI.Models
{
    public class PetinyDbContext:DbContext
    {
        public PetinyDbContext(DbContextOptions<PetinyDbContext> options) : base(options) { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Owner> Owners{ get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PetinyAPI.Models.PaymentMethod> PaymentMethod { get; set; }
        public DbSet<PetinyAPI.Models.Shop> Shop { get; set; }
        
       
    
    }
}
