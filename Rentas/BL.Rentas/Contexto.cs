using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class Contexto: DbContext // Aquí tenemos herencia
    {
        public Contexto(): base() //Con el parentesis hacemos una instancia entre DbContext y base().
        {
            
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
