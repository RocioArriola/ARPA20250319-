using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ARPA20250319.AppWebMVC.Models;

public partial class Brand
{
    [Display(Name = "MarcaId")]
    public int BrandId { get; set; }

    [Display(Name = "Nombre")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string BrandName { get; set; } = null!;

    [Display(Name = "País")]
    [Required(ErrorMessage = "El pais es obligatorio.")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
