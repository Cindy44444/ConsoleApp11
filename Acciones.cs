using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Acciones : IAcciones
    {
        Alumno a = new Alumno();
        private List<Alumno> listaalumno = new List<Alumno>()
        {new Alumno("Cindy",20,112816), new Alumno("Rebe",20,112869)};
        

        public void Actualizar(int matriactu, int mat, string nom, int years)
        {
            var actualizaralumno = listaalumno.FirstOrDefault(x => x.Matricula == matriactu);
            if (actualizaralumno != null)
            {
                listaalumno.Remove(actualizaralumno);
                listaalumno.Add(new Alumno(a.Name = nom, a.Edad = years, a.Matricula = mat));
            }
        }

        public void Actualizar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        public void Agregar(int matricula, string nombre, int edad)
        {
            listaalumno.Add(new Alumno(a.Name = nombre, a.Edad=edad, a.Matricula = matricula));
        }

        public List<Alumno> Consultar()
        {
            return listaalumno;
        }

        public void Eliminar(int matricula)
        {
           var objetoeliminar = listaalumno.FirstOrDefault(x  => x.Matricula == matricula);
            if (objetoeliminar != null)
            {
                listaalumno.Remove(objetoeliminar);
            }
            else
            {
                Console.WriteLine("No se puede eliminar");
            }
        }

        public void ExportarExcel()
        {
            throw new NotImplementedException();
            //no se, no le entendi a chat gpt
        }
    }
}
