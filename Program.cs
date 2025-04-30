using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        public enum MENU
        {
            Consultar=1, Agregar, Actualizar,Eliminar
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (Menu())
                {
                    case MENU.Consultar:
                        var lista = acciones.Consultar();
                        foreach(var l in lista)
                        {
                            Console.WriteLine("________________");
                            Console.WriteLine($"Nombre:{l.Name}");
                            Console.WriteLine($"Edad:{l.Edad}");
                            Console.WriteLine($"Matricula:{l.Matricula}");
                            Console.WriteLine("________________");
                        }
                        break;
                    case MENU.Agregar:
                        break;
                    case MENU.Actualizar:
                        break;
                    case MENU.Eliminar:
                        break;
                }
            }
        }
        static MENU Menu()
        {
            Console.WriteLine("1)Consultar");
            Console.WriteLine("2)Agregar");
            Console.WriteLine("3)Actualizar");
            Console.WriteLine("4)Eliminar");
            MENU opc = (MENU)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
