using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using universidad.Models;
using universidad.Controllers;

namespace universida.Data
{
    public class UniversidadContext : DbContext
    {
        public UniversidadContext (DbContextOptions<UniversidadContext> options)
            : base(options)
        {
        }

        public DbSet<universidad.Models.Student> Student { get; set; } = default!;
        public DbSet<universidad.Controllers.Course> Course { get; set; } = default!;
    }
}
