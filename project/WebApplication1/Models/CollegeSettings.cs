namespace WebApplication1.Models;

internal class CollegeSettings
{
    public string CollegeName { get; private set; } = "Колледж";
    public string AcademicYear { get; private set; } = "2026–2027";
    internal void Update(string name, string year) { CollegeName = name; AcademicYear = year; }
}
