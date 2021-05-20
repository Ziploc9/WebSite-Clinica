using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.Entity;

namespace WebClinica.Models
{
    public class MedicoInitializer : DropCreateDatabaseAlways<MedicoDbContext>
    {
        protected override void Seed(MedicoDbContext context)
        {
            base.Seed(context);

            //Craer usuario
            var medicos = new List<Medico>
            {
                new Medico {
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Matricula = "Abc 123",
                    Ciudad = "Mar Carse"
                }
            };
            medicos.ForEach(s => context.Medicos.Add(s));
            context.SaveChanges();
        }
    }
}