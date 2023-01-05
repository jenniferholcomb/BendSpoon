using Microsoft.EntityFrameworkCore;

namespace BendSpoon.Models
{
  public class BendSpoonContext : DbContext
  {
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeRestaurant> EmployeeRestaurants { get; set; }

    public BendSpoonContext(DbContextOptions options) : base(options) { }
  }
}