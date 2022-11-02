using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ShoppingCart.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string Description { get; set; }
    [Required] 
    public double Price { get; set; }
    [ValidateNever]
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    [ValidateNever]
    public Category Category { get; set; }

    public string Name { get; set; }
}