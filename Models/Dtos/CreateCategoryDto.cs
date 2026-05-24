using System;
using System.ComponentModel.DataAnnotations;

namespace DemoDevOps.Models.Dtos;

public class CreateCategoryDto
{
    [Required(ErrorMessage = "The name is required.")]
    [MaxLength(50, ErrorMessage = "The name must be less than 50 characters.")]
    [MinLength(3, ErrorMessage = "The name must be at least 3 characters.")]
    public string Name { get; set; }  = string.Empty;

}
