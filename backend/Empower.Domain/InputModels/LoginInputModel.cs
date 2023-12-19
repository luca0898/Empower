using System.ComponentModel.DataAnnotations;

namespace Empower.Domain.InputModels;

public class LoginInputModel
{
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    [MaxLength(255)]
    [Required]
    public string? Email { get; set; }

    [DataType(DataType.Password)]
    [MaxLength(255)]
    [Required]
    public string? Password { get; set; }
}
