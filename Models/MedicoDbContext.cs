using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebClinica.Models
{
    public class MedicoDbContext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
    }
}