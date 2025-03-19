using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ARPA20250319.AppWebMVC.Models;

public partial class User
{
    [Display(Name="UsuarioId")]
    public int UserId { get; set; }

    [Display(Name = "NombreUsuario")]
    [Required(ErrorMessage ="El nombre de usuario es obligatorio")]
    public string Username { get; set; } = null!;

    [Display(Name = "Correo")]
    [Required(ErrorMessage = "El correo es obligatorio")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    public string Email { get; set; } = null!;

    [Display(Name = "Contraseña")]
    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El passowrd debe tener entre 5 y 50 caracteres.")]
    public string PasswordHash { get; set; } = null!;

    [Display(Name = "Rol")]
    public string Role { get; set; } = null!;
}
