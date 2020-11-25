using DHP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DHP.Data.DataContext
{
    public class DhpDbContext : DbContext
    {
        public DhpDbContext(DbContextOptions<DhpDbContext> options) 
            : base(options)
        {
            
        }
        public DbSet<Chat> Chat { get; set; }
    }
}
