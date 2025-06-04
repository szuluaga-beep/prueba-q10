using System;
using System.ComponentModel.DataAnnotations;

namespace universidad.Controllers;

public class Course
{

    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }

    public required string Code { get; set; }

    public int Credit { get; set; }
}
