using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Persona
    {
        public Persona() { }

        public Persona(string name, int edad)
        {
            Name = name;
            Edad = edad;
        }

        public string Name { get; set; }
        public int Edad { get; set; }
    }

}
