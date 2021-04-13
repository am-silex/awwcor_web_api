using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace awwcor_web_api.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Ad> Ad { get; set; }        
    }
}
