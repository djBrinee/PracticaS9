using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS9.Models
{
    internal class Calificaciones
    {
        public int puntuacion { get; set; }
        public Asignatura? asignatura { get; set; }

        public bool Aprobada()
        {
            bool response = puntuacion >= 70 ?  true : false;
            return response;
        }
    }

}
