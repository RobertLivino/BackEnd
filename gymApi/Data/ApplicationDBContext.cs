using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gymApi.Models;
using Microsoft.EntityFrameworkCore;

namespace gymApi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }
        public DbSet<Exercise> Exercises { get; set; }
    }
}