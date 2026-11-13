using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practice1.Models;

public partial class Employee
{

    
    public int EmpId { get; set; }


    [Required(ErrorMessage = "Employee Name is required")]
    [StringLength(50 , MinimumLength = 3, ErrorMessage = "Employee Name must be between 3 and 50 characters")]

    public string EmpName { get; set; }
    [Required(ErrorMessage = "Department is required")]

    public string Department { get; set; }
    [Required(ErrorMessage = "Salary is required")]
    [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive number")]
    public decimal Salary { get; set; }
    [Required(ErrorMessage = "Experience Years is required")]
    public int ExprienceYears { get; set; }
    [Required (ErrorMessage = "Join Date is required")]
    public DateOnly JoinDate { get; set; }
}
