using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;

namespace EntityFramework.Data
{
    public class EFIntroContext : DbContext
    {
        public EFIntroContext (DbContextOptions<EFIntroContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFramework.Models.Categories> Categories { get; set; }

        public DbSet<EntityFramework.Models.Employees> Employees { get; set; }
    }
}
