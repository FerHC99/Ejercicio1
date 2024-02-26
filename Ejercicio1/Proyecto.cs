using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Proyecto : IProyecto
    {
        public string Nombre { get; set; }
        public int Categoría { get; set; }
        public double Duracion { get; set; }
        public string Fechainicio { get; set; }

        public Proyecto() 
        {

        }
        public virtual void Mensaje(string nombre, int categoria, double duracion, string fechainicio)
        {
            Console.WriteLine($"El proyecto {nombre} que inicio en {fechainicio} con categoria {categoria} y duracion {duracion} hrs.");
        }

    }
}
