namespace WebApplication1.Models;

public class Subject
{
    private string _name;
    private int _hours;
    private Teacher? _teacher;
    public string Name => _name;
    public int Hours => _hours;
    public Teacher? AssignedTeacher => _teacher;
    public Subject(string name, int hours) { _name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentException("Укажите предмет.") : name.Trim(); _hours = hours > 0 ? hours : throw new ArgumentOutOfRangeException(nameof(hours)); }
    public void AssignTeacher(Teacher teacher) => _teacher = teacher ?? throw new ArgumentNullException(nameof(teacher));
}
