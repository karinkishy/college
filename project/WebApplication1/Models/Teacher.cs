namespace WebApplication1.Models;

public class Teacher : Person
{
    private string _subject;
    private int _experience;
    public string Subject { get => _subject; set => _subject = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Укажите предмет.") : value.Trim(); }
    public int Experience => _experience;
    public Teacher(string name, string surname, int age, string subject, int experience) : base(name, surname, age)
    { _subject = subject; UpdateExperience(experience); }
    public void UpdateExperience(int years) { if (years < 0 || years > 55) throw new ArgumentOutOfRangeException(nameof(years)); _experience = years; }
    public string GetTeacherInfo() => $"{DisplayBasicInfo()}, предмет: {Subject}, стаж: {Experience} лет";
}
