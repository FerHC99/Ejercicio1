using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            //Console.WriteLine($"El desarrollador: {desarrollador.Nombre} que ingreso en la fecha {desarrollador.Fechaingreso}, su coctacto es {desarrollador.Email} y categoria {desarrollador.Categoria}");
            //Console.WriteLine($"El desarrollador: {desarrollador1.Nombre} que ingreso en la fecha {desarrollador1.Fechaingreso}, su coctacto es {desarrollador1.Email} y categoria {desarrollador1.Categoria}");
            //Console.WriteLine($"{desarrollador.Nombre} desarrollador de categoria {desarrollador.Categoria} lleva el proyecto {proyecto.Nombre}, comenzando el dia {proyecto.Fechainicio} con un total de horas {proyecto.Duracion}");

            IDesarrollador desarrollador = new Desarrollador();
            desarrollador.Mensaje("Alberto", "01/03/20", "Aberto@hotmail.com", 1);

            IDesarrollador desarrollador1 = new Desarrollador();
            desarrollador1.Mensaje("Juan", "26/02/22", "Juan25@gmail.com", 2);

            IProyecto proyecto = new Proyecto();
            proyecto.Mensaje("Coples", 2, 5.5, "26/02/24");

            IProyecto proyecto1 = new Proyecto();
            proyecto1.Mensaje("Aceria", 1, 2, "23/02/24");
        }
    }
}
