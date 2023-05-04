namespace Parcial1.Models;

public class Estudiante
{
    public int Id { get; set; }
    public string NombreAlumno { get; set; }
    public string ApellidoAlumno { get; set; }
    public int Dni { get; set; }
    public string CursoElegido { get; set; }
    public virtual List<Curso> Cursos { get; set; }

}