using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Personas
{
   public abstract class Persona
    {
        //
        public int Cedula { get; set; }
      
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }

        public string primerApellido { get; set; }

        public string segundoApellido { get; set; }

        public int fechaNacimiento { get; set; }
        
        //DIRECCION


        public string Calle { get; set; }
        public int Numero { get; set; }

        public int Interseccion { get; set; }


    }
}
