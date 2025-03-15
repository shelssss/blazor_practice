using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practice_blazor.Models;

namespace practice_blazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<practice_blazor.Models.Product> Product { get; set; } = default!;
        public DbSet<practice_blazor.Models.Tools> Tools { get; set; } = default!;
        public DbSet<practice_blazor.Models.Appointment> Appointment { get; set; } = default!;
    }
}
