using System;
using System.ComponentModel.DataAnnotations;

namespace universidad.Models;

public class Student
{
    public int Id { get; set; }
    [Required]
    public required string FullName { get; set; }

    public int Card { get; set; }

    [EmailAddress]
    public required string Email { get; set; }

}
