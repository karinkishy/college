using WebApplication1.Models;
namespace WebApplication1.Services;

public class ReportManager
{
    protected internal string GenerateReport(IEnumerable<Student> students) => $"Отчёт сформирован {DateTime.Now:dd.MM.yyyy HH:mm}. Студентов: {students.Count()}.";
}
