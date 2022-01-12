using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF05DbContextOptionsBuilder
{
    public class ApplicationContext2 : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext2(DbContextOptions<ApplicationContext2> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
