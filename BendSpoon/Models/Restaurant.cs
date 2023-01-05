using System.Collections.Generic;

namespace BendSpoon.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string RestName { get; set; }
    public string Type { get; set; }
    public List<Employee> Employees { get; set; }
  }
}