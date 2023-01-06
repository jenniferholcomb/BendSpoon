using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace BendSpoon.Models
{
  public class Employee
  {
    public int EmployeeId { get; set; }
    public string Name { get; set; }

    [DataType(DataType.Date)] 
    [Required(ErrorMessage="Please enter a valid date.")] 
    [Range(typeof(DateTime), "1/1/2000", "1/1/2024", ErrorMessage = "Please enter a valid start date for employee.")]  
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? StartDate { get; set; }
    public List<Restaurant> Restaurants { get; set; }
  }
}