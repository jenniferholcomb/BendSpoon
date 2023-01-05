using System.Collections.Generic;
using System;

namespace BendSpoon.Models
{
  public class Employee
  {
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public List<Restaurant> Restaurants { get; set; }
  }
}