using System;
using System.ComponentModel.DataAnnotations;

public class MyModel {
    public Int32? Id { get; set; }

    [Required]
    public String Name { get; set; }

    [Required]
    [Range(18, 50, ErrorMessage = "Age: from 18 to 50")]
    public Int32 Age { get; set; }

    [Required]
    public DateTime? OrderDate { get; set; }
}