using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlConnection.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=127.0.0.1;user id=root; password=@root987; persistsecurityinfo=True;database=gestaocaixa",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }

        public DbSet<Usuarios> Usuario { get; set; }
    }
}
