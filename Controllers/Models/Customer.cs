
using System.ComponentModel.DataAnnotations;

namespace AcxiomCRM.Models;

public class Customer
{
    public int Id { get; set; }

    [Required]
    public string CustomerName { get; set; } = "";

    [Required, EmailAddress]
    public string Email { get; set; } = "";

    [Required]
    public string Phone { get; set; } = "";

    public string CompanyName { get; set; } = "";

    public string Status { get; set; } = "Active";
}
