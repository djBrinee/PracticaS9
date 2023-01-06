using PracticaS9.Models;
namespace TestsPracticaS9
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
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
    }
}