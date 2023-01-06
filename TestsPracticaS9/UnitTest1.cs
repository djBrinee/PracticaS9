using PracticaS9.Models;
namespace TestsPracticaS9
{
    public class UnitTest1
    {
        [Fact]
        public void TestAprobadaTrue()
        {
            Asignatura asignatura = new Asignatura()
            {
                codigo = "codigo", nombre = "nombre", creditos = 6
            };
            Calificaciones calificaciones = new Calificaciones()
            {
                puntuacion = 70,
                asignatura = asignatura
            };

            bool aprobada = calificaciones.Aprobada();
            
            Assert.True(aprobada);           
        }
        [Fact]
        public void TestAprobadaFalse()
        {
            Asignatura asignatura = new Asignatura()
            {
                codigo = "codigo",
                nombre = "nombre",
                creditos = 6
            };
            Calificaciones calificaciones = new Calificaciones()
            {
                puntuacion = 60,
                asignatura = asignatura
            };

            bool aprobada = calificaciones.Aprobada();

            Assert.False(aprobada);
        }

        [Fact]
        public void TestInscribirse()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();
            List<Calificaciones> listaCalificaciones= new List<Calificaciones>();
            Estudiante estudiante = new Estudiante()
            {
                asignaturas = listaAsignaturas,Nombre= "Hugo", Apellido="Chavez",calificaciones = listaCalificaciones,carrera= "Ingenieria de Software", creditosMaximos = 20, Edad = 21   
            };
            Asignatura asignatura = new Asignatura()
            {
                codigo = "codigo",
                nombre = "nombre",
                creditos = 6
            };
            int countAsignaturas = estudiante.inscribir(asignatura);
            Assert.True(countAsignaturas == 1);
        }
    }
}