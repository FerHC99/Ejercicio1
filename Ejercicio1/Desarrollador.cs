using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Desarrollador : IDesarrollador
    {
        public string Nombre { get; set; }
        public string Fechaingreso { get; set; }
        public string Email { get; set; }
        public int Categoria { get; set; }
        public Desarrollador()
        {
           
        }
        public virtual void Mensaje(string nombre, string fechaingreso, string email, int categoria)
        {
            Console.WriteLine($"{nombre} es desarrollador, ingreso en la fecha {fechaingreso}, su coctacto es: {email} y categoria: {categoria}");
        }
    }
}
