namespace BendSpoon.Models
{
  public class EmployeeRestaurant
  {
    public int EmployeeRestaurantId { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
  }
}