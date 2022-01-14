using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionesDeFuncionesSobreListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alumnos> alumnos = new List<Alumnos>()
            {
                new Alumnos() {Codigo = 441, Nombres = "Mero Javier", Edad = 20},
                new Alumnos() {Codigo = 222, Nombres = "Gonzalo Karla", Edad = 20},
                new Alumnos() {Codigo = 321, Nombres = "Lopez Jose", Edad = 23},
                new Alumnos() {Codigo = 216, Nombres = "Zambrano Katherine", Edad = 24},
                new Alumnos() {Codigo = 196, Nombres = "Alvarado Michael", Edad = 23},
            };

            // Para usar la funcion de recorrido se utiliza el comando foreach
            
            foreach (var a in alumnos) 
                
            {

                Console.WriteLine($"Codigo: {a.Codigo}, Nombre: {a.Nombres}, Edad: {a.Edad}");
            }


            // Para la funcion de busqueda se utiliza el metodo Find

            //var EncontrarDato = alumnos.Find(x => x.Nombres.Equals("Gonzalo Karla")); // Se utiliza para datos de tipo String
            var EncontrarDato = alumnos.Find(x => x.Edad == 20); // Se utiliza para datos de tipo int

            
            // Para la funcion filtrar se utiliza el metodo Where.

            
           var EdadesAlumnos = alumnos.Where(x => x.Edad >= 23).ToList();
            

            // Para la funcion de ordenamiento se usa los metodos OrderBy y ThenBy

            

            var ListaAscendete = alumnos.OrderBy(x => x.Edad).ToList();
            //var ListaDescendete = alumnos.OrderByDescending(x => x.Codigo).ToList();
            //var ListaAscendete = alumnos.OrderBy(x =>x.Edad).ThenBy(x => x.Nombres).ToList();

            Console.Read();
        }
    }
}