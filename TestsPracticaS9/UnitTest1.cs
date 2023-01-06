using PracticaS9.Models;
namespace TestsPracticaS9
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Asignatura asignatura = new Asignatura("codigo", "nombre", 6);
            Calificaciones calificaciones = new Calificaciones( 70, asignatura );

            calificaciones.Aprobado(true);
            
            Assert.True( calificaciones.Aprobado(false));   
          
            
        }
    }
}