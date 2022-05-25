using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Personas
{
    class Alumno : Persona
    {
        public short Nota { get; set; }
        public Alumno(int Cedula, byte nota):base(Cedula) {

            this.Cedula = cedula;
            this.Nota = nota;
        }


    }
}
