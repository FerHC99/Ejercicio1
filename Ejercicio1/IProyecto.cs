using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public interface IProyecto
    {
        string Nombre { get; set; }
        int Categoría { get; set; }
        double Duracion { get; set; }
        string Fechainicio { get; set; }
        void Mensaje(string nombre, int categoria, double duracion, string fechainicio);
    }
}
