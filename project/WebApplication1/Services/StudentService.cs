using WebApplication1.Models;
namespace WebApplication1.Services;

public class StudentService
{
    private readonly List<Student> _students = [];
    public IReadOnlyList<Student> All => _students.AsReadOnly();
    public void Add(Student student) => _students.Add(student);
}
