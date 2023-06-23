using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infra.Data.DataContext
{
    public class FicheiroContext : DbContext
    {
        public FicheiroContext(DbContextOptions<FicheiroContext> options) : base(options)
        {
            //
        }

        public DbSet<Ficheiro> Ficheiros { get; set; }
    }
    
    
}
