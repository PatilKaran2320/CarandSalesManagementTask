﻿using System;
using System.ComponentModel.DataAnnotations;

public class CarModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Brand is required")]
    public string Brand { get; set; }

    [Required(ErrorMessage = "Class is required")]
    public string Class { get; set; }

    [Required(ErrorMessage = "Model Name is required")]
    public string ModelName { get; set; }

    [Required(ErrorMessage = "Model Code is required")]
    [RegularExpression("^[a-zA-Z0-9]{10}$", ErrorMessage = "Model Code must be 10 alphanumeric characters")]
    public string ModelCode { get; set; }

    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Features are required")]
    public string Features { get; set; }

    [Required(ErrorMessage = "Price is required")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Date of Manufacturing is required")]
    public DateTime DateOfManufacturing { get; set; }

    public bool Active { get; set; }

    public int SortOrder { get; set; }
}
