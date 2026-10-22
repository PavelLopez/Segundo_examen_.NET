using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_2
{
    internal class Taller
    {
        public string Nombre { get; set; } = "";
        public int Cupomaximo { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
