using Ap1_P1_JoseRivera.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Ap1_P1_JoseRivera.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
        : base(options) { }

        public DbSet<Articulos> Articulos { get; set; }

    }
}
