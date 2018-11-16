using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas
{
    class Program
    {
        public class Coordenadas
        {
            public Double latitud { get; set; }
            public Double longitud { get; set; }
           
        }
        static void Main(string[] args)
        {
            bool continua = true;
            Console.WriteLine("Hola,Ingresa Coordenadas(latitud,longitud),X para salir");
            Console.WriteLine("Ejemplo: 12.3444,14.2333");
            List<Coordenadas> coordenada = new List<Coordenadas>();
            while (continua)
            {
                String input = Console.ReadLine();
                if (input.ToLower().Equals("x"))
                {
                    continua = false;
                    continue;
                }
                if (input.Split(',').Length != 2)
                {

                    continue;
                }
                Double latitud;
                Double longitud;

                Coordenadas micoordenada = new Coordenadas()
                {
                    latitud = Double.TryParse(input.Split(',')[0], out latitud) ? latitud : 0,
                    longitud = Double.TryParse(input.Split(',')[1], out longitud) ? longitud : 0,
                };
                coordenada.Add(micoordenada);


                Console.Write(latitud + ",00000000"); Console.Write(",  "); Console.Write(longitud + ",0000000");
                Console.ReadKey();
            }
            
        }
    }
}
