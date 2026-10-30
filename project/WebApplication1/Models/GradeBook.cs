namespace WebApplication1.Models;

public class GradeBook
{
    private readonly List<Grade> _grades = [];
    public IReadOnlyList<Grade> Grades => _grades.AsReadOnly();
    public void Add(Grade grade) { if (grade.Value is < 2 or > 5) throw new ArgumentOutOfRangeException(nameof(grade), "Оценка должна быть от 2 до 5."); _grades.Add(grade); }
    public bool Remove(int index) => index >= 0 && index < _grades.Count && RemoveAt(index);
    private bool RemoveAt(int index) { _grades.RemoveAt(index); return true; }
}
