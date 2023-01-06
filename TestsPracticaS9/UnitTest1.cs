using PracticaS9.Models;
namespace TestsPracticaS9
{
    public class UnitTest1
    {
        [Fact]
        public void TestAsignaturaAprobada()
        {
            Asignatura asignatura = new Asignatura()
            {
                codigo = "IDS326",
                nombre = "Construccion de software",
                creditos = 6
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
        public void TestAsignaturaReprobada()
        {
            Asignatura asignatura = new Asignatura()
            {
                codigo = "IDS326",
                nombre = "Construccion de software",
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
        public void TestAsignaturaInscrita()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();
            List<Calificaciones> listaCalificaciones= new List<Calificaciones>();
            Estudiante estudiante = new Estudiante()
            {
                asignaturas = listaAsignaturas,Nombre= "Hugo", Apellido="Chavez",calificaciones = listaCalificaciones,carrera= "Ingenieria de Software", creditosMaximos = 20, Edad = 21   
            };
            Asignatura asignatura = new Asignatura()
            {
                codigo = "IDS326",
                nombre = "Construccion de software",
                creditos = 6
            };
            int countAsignaturas = estudiante.inscribir(asignatura);
            Assert.True(countAsignaturas == 1);
        }

        [Fact]
        public void TestRetirarAsignaturaExistente()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();
            List<Calificaciones> listaCalificaciones = new List<Calificaciones>();
            Estudiante estudiante = new Estudiante()
            {
                asignaturas = listaAsignaturas,
                Nombre = "Hugo",
                Apellido = "Chavez",
                calificaciones = listaCalificaciones,
                carrera = "Ingenieria de Software",
                creditosMaximos = 20,
                Edad = 21
            };
            Asignatura asignatura = new Asignatura()
            {
                codigo = "IDS326",
                nombre = "Construccion de software",
                creditos = 6
            };
            int countAsignaturas = estudiante.inscribir(asignatura);
            bool retirada = estudiante.Retirar(asignatura);
            Assert.True(retirada);
            Assert.True(estudiante.asignaturas.Count == 0);
        }

        [Fact]
        public void TestRetirarAsignaturaNoExistente()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();
            List<Calificaciones> listaCalificaciones = new List<Calificaciones>();
            Estudiante estudiante = new Estudiante()
            {
                asignaturas = listaAsignaturas,
                Nombre = "Hugo",
                Apellido = "Chavez",
                calificaciones = listaCalificaciones,
                carrera = "Ingenieria de Software",
                creditosMaximos = 20,
                Edad = 21
            };
            Asignatura asignaturaInscrita = new Asignatura()
            {
                codigo = "IDS326",
                nombre = "Construccion de software",
                creditos = 6
            };
            Asignatura asignaturaARetirar = new Asignatura()
            {
                codigo = "CSH302",
                nombre = "Economia",
                creditos = 6
            };
            int count = estudiante.inscribir(asignaturaInscrita); 
            bool retirada = estudiante.Retirar(asignaturaARetirar);
            Assert.False(retirada);
            Assert.True(estudiante.asignaturas.Count == 1);
        }

        [Fact]
        public void TestEstudianteSinSobrecredito()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();
            List<Calificaciones> listaCalificaciones = new List<Calificaciones>();
            Estudiante estudiante = new Estudiante()
            {
                asignaturas = listaAsignaturas,
                Nombre = "Hugo",
                Apellido = "Chavez",
                calificaciones = listaCalificaciones,
                carrera = "Ingenieria de Software",
                creditosMaximos = 20,
                Edad = 21
            };
            Asignatura asignatura = new Asignatura()
            {
                codigo = "IDS326",
                nombre = "Construccion de software",
                creditos = 6
            };
            int countAsignaturas = estudiante.inscribir(asignatura);
            bool sobrecredito = estudiante.ValidarCreditos();
            Assert.False(sobrecredito);
        }

        [Fact]
        public void TestEstudianteConSobrecredito()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();
            List<Calificaciones> listaCalificaciones = new List<Calificaciones>();
            Estudiante estudiante = new Estudiante()
            {
                asignaturas = listaAsignaturas,
                Nombre = "Hugo",
                Apellido = "Chavez",
                calificaciones = listaCalificaciones,
                carrera = "Ingenieria de Software",
                creditosMaximos = 20,
                Edad = 21
            };
            Asignatura asignatura = new Asignatura()
            {
                codigo = "IDS326",
                nombre = "Construccion de software",
                creditos = 21
            };
            int countAsignaturas = estudiante.inscribir(asignatura);
            bool sobrecredito = estudiante.ValidarCreditos();
            Assert.True(sobrecredito);
        }
    }
}