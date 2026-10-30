using WebApplication1.Models;

namespace WebApplication1.Data;

/// <summary>In-memory college data collections used by this sample application.</summary>
public sealed class CollegeDbContext
{
    public List<Student> Students { get; } = [];
    public List<Teacher> Teachers { get; } = [];
    public List<Group> Groups { get; } = [];
    public List<Subject> Subjects { get; } = [];
    public List<Grade> Grades { get; } = [];
}
