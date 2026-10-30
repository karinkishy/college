namespace WebApplication1.Models;

public class Student : Person
{
    private string _group;
    public int StudentId { get; }
    public string Group { get => _group; set => _group = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Укажите группу.") : value.Trim(); }
    public Student(string name, string surname, int age, string group, int studentId = 0) : base(name, surname, age)
    { _group = group; StudentId = studentId; ValidateStudentData(); }
    public void SetAge(int age) => Age = age;
    public string GetStudentInfo() => $"{StudentId}: {DisplayBasicInfo()}, группа {_group}";
    private void ValidateStudentData() { if (string.IsNullOrWhiteSpace(_group)) throw new ArgumentException("Укажите группу.", nameof(Group)); }
}
