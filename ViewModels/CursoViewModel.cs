using Parcial1.Models;

namespace Parcial1.ViewModels;

public class CursoViewModel
{
    public List<Curso> Cursos { get; set; } = new List<Curso>();
    public string? NameFilter { get; set; }
}