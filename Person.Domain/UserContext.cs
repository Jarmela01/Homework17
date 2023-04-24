using Microsoft.EntityFrameworkCore;
using Person.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Domain
{
    public class UserContext : DbContext 
    {
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Homework17;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }
}
