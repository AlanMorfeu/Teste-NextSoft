using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNextSoftMVC.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        
        public  DbSet<Condominio> Condominio { get; set; }
        public  DbSet<Familia> Familia { get; set; }
        public  DbSet<Morador> Morador { get; set; }
    }
}
