using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesAPI.Models
{
    public class SalesAPIContext : DbContext
    {
        public SalesAPIContext (DbContextOptions<SalesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SalesAPI.Models.SalesItem> SalesItem { get; set; }
    }
}
