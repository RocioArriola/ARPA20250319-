using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ARPA20250319.AppWebMVC.Models;

public partial class Category
{
    [Display(Name = "CategoriaId")]

    public int CategoryId { get; set; }

    [Display(Name = "Nombre")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string CategoryName { get; set; } = null!;

    [Display(Name = "Descripcion")]
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
