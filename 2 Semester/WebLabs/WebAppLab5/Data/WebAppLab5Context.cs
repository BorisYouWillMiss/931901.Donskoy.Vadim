using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppLab5.Models;

namespace WebAppLab5.Data
{
    public class WebAppLab5Context : DbContext
    {
        public WebAppLab5Context (DbContextOptions<WebAppLab5Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppLab5.Models.Hospital>? Hospital { get; set; }

        public DbSet<WebAppLab5.Models.Lab>? Lab { get; set; }

        public DbSet<WebAppLab5.Models.Doctor>? Doctor { get; set; }

        public DbSet<WebAppLab5.Models.Patient>? Patient { get; set; }
    }
}
