using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS9.Models
{
    public class Calificaciones
    {
        public int puntuacion { get; set; }
        public Asignatura? asignatura { get; set; }

        public bool Aprobada()
        {
            bool response = puntuacion >= 70 ?  true : false;
            Asignatura asignatura=new Asignatura();
            return response;
        }
    }

}
