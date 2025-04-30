using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Acciones : IAcciones
    {
        private List<Alumno> listaalumno = new List<Alumno>()
        {new Alumno("Cindy",20,112816), new Alumno("Rebe",20,112869)};
        public void Actualizar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        public void Agregar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        
        public List<Alumno> Consultar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int matricula)
        {
            throw new NotImplementedException();
        }

        public void ExportarExcel()
        {
            throw new NotImplementedException();
        }
    }
}
