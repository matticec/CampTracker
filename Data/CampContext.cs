using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTracker.Models;

namespace CampTracker.Data
{
    public class CampContext : DbContext
    {
        public CampContext (DbContextOptions<CampContext> options)
            : base(options)
        {
        }

        public DbSet<CampTracker.Models.Camp> Camp { get; set; }
    }
}
