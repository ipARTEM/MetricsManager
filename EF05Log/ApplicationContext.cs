using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF05Log
{
    public class ApplicationContext : DbContext
    {
        readonly StreamWriter logStream = new StreamWriter("mylog.txt", true);

        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");

            optionsBuilder.LogTo(Console.WriteLine);

            optionsBuilder.LogTo(logStream.WriteLine);

            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));

            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name });
        }

        public override void Dispose()
        {
            base.Dispose();
            logStream.Dispose();
        }

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
}
