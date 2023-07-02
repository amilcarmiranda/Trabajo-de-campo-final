using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_de_campo_final.Modelo.DataAcces
{
    public class Persona
    {
        public static Trabajo_de_campo_final.Modelo.DTO.Persona devolverPersona()
        {
            return new Trabajo_de_campo_final.Modelo.DTO.Persona { nombre = "Amilcar", apellido = "miranda" };
        }
    }
}
