using Parcial1.Models;

namespace Viewmodels;

public class EstudianteViewmodel
{
    public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    public string NameFilter { get; set; }
}