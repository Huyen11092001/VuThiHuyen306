using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VuThiHuyen306.Models;

    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }

        public DbSet<VuThiHuyen306.Models.CompanyVTH306> CompanyVTH306 { get; set; } = default!;

        public DbSet<VuThiHuyen306.Models.VTH0306> VTH0306 { get; set; } = default!;
    }
