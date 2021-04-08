using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _PlastSiteMVC.Models
{  
    public class PlastContext : DbContext
    {
        public PlastContext(DbContextOptions<PlastContext>options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
    }
}
