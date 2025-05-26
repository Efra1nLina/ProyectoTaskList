using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaskList
{
    internal class Actividad
    {
        public Actividad(string? nombre, string? descripcion, string? duracion, int? prioridad)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Duracion = duracion;
            Prioridad = prioridad;
        }

        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Duracion { get; set; }
        public int? Prioridad { get; set; }
    }
}
