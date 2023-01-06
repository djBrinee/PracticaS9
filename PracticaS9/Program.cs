using PracticaS9.Models;

Asignatura asignatura = new Asignatura()
{
    codigo = "IDS323",
    nombre = "Hola",
    creditos = 2
};

Calificaciones calificacion = new Calificaciones()
{
    puntuacion = 70,
    asignatura = asignatura
};

Console.WriteLine(calificacion.Aprobada());