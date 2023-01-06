using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS9.Models
{
    public class Estudiante : Persona
    {
        public string carrera { get; set; }
        public List<Calificaciones>? calificaciones{ get; set; }
        public List<Asignatura>? asignaturas { get; set; }
        public int creditosMaximos { get; set; }

        public int inscribir(Asignatura asignaturaAgregar)
        {
            try
            {
                asignaturas.Add(asignaturaAgregar);
                return asignaturas.Count;
            }
            catch (Exception)
            {
                return asignaturas.Count;
            }
        }
    }

}
