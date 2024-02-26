using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public interface IDesarrollador
    {
        string Nombre { get; set; }
        string Fechaingreso { get; set; }
        string Email { get; set; }
        int Categoria { get; set; }
        void Mensaje(string nombre, string fechaingreso, string email, int categoria);
    }
}
