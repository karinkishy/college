using WebApplication1.Models;
namespace WebApplication1.Services;

public class CollegeRepository
{
    private int _nextId = 4;
    public List<Student> Students { get; } = [new("Алия", "Серикова", 18, "ИС-21", 1), new("Данияр", "Ахметов", 19, "ИС-21", 2), new("Мария", "Иванова", 17, "ДИЗ-11", 3)];
    public List<Teacher> Teachers { get; } = [new("Елена", "Смирнова", 42, "Программирование", 18), new("Руслан", "Омаров", 36, "Математика", 12), new("Анна", "Ким", 31, "История", 8)];
    public List<Group> Groups { get; } = [new("ИС-21", 2), new("ДИЗ-11", 1), new("ЭК-31", 3)];
    public List<Grade> Grades { get; } = [new(1, "Алия Серикова", "Программирование", 5, DateOnly.FromDateTime(DateTime.Today)), new(2, "Данияр Ахметов", "Математика", 4, DateOnly.FromDateTime(DateTime.Today)), new(3, "Мария Иванова", "История", 5, DateOnly.FromDateTime(DateTime.Today))];
    public AttendanceManager Attendance { get; } = new();
    public CollegeRepository() { foreach (var group in Groups) foreach (var student in Students.Where(s => s.Group == group.Name)) group.AddStudent(student); foreach (var student in Students) Attendance.Add(student.StudentId, DateOnly.FromDateTime(DateTime.Today), student.StudentId != 2); }
    public void AddStudent(string name, string surname, int age, string group) { var student = new Student(name, surname, age, group, _nextId++); Students.Add(student); Groups.FirstOrDefault(g => g.Name == group)?.AddStudent(student); }
    public void AddGrade(int studentId, string subject, int value) { if (value is < 2 or > 5) throw new ArgumentOutOfRangeException(nameof(value), "Оценка должна быть от 2 до 5."); var student = Students.FirstOrDefault(s => s.StudentId == studentId) ?? throw new ArgumentException("Студент не найден."); Grades.Add(new Grade(studentId, student.GetFullName(), subject, value, DateOnly.FromDateTime(DateTime.Today))); }
}
