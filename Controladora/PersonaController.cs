using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_de_campo_final.Controladora
{
    public class PersonaController
    {
        public static Trabajo_de_campo_final.Modelo.DTO.Persona devolverPersona()
        {
            return Modelo.DataAcces.Persona.devolverPersona();
        }
    }
}
