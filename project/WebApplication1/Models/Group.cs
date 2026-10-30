namespace WebApplication1.Models;

public class Group
{
    private readonly List<Student> _students = [];
    public string Name { get; }
    public int Course { get; }
    public IReadOnlyList<Student> Students => _students.AsReadOnly();
    public Group(string name, int course) { Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentException("Укажите группу.") : name.Trim(); Course = course is < 1 or > 6 ? throw new ArgumentOutOfRangeException(nameof(course)) : course; }
    public bool AddStudent(Student student) { ArgumentNullException.ThrowIfNull(student); if (_students.Any(s => s.StudentId == student.StudentId && s.StudentId != 0 || s.GetFullName() == student.GetFullName())) return false; student.Group = Name; _students.Add(student); return true; }
    public bool RemoveStudent(int studentId) => _students.RemoveAll(s => s.StudentId == studentId) > 0;
}
