using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Codesweaver.Models;
using CodesWeaverNew.Models;

namespace CodesWeaverNew.Data
{
    public class CodesWeaverNewContext : DbContext
    {
        public CodesWeaverNewContext (DbContextOptions<CodesWeaverNewContext> options)
            : base(options)
        {
        }

        public DbSet<Codesweaver.Models.Sliders> Sliders { get; set; }

        public DbSet<CodesWeaverNew.Models.About> About { get; set; }

     
    }
}
