namespace WebApplication1.Models;

public abstract class Person
{
    protected string NameValue;
    protected string SurnameValue;
    protected int AgeValue;
    protected Person(string name, string surname, int age)
    {
        NameValue = Required(name, nameof(name)); SurnameValue = Required(surname, nameof(surname));
        if (age is < 15 or > 70) throw new ArgumentOutOfRangeException(nameof(age), "Возраст должен быть от 15 до 70 лет.");
        AgeValue = age;
    }
    public string Name { get => NameValue; set { NameValue = Required(value, nameof(value)); } }
    public string Surname { get => SurnameValue; set { SurnameValue = Required(value, nameof(value)); } }
    public int Age { get => AgeValue; set { if (value is < 15 or > 70) throw new ArgumentOutOfRangeException(nameof(value)); AgeValue = value; } }
    protected string DisplayBasicInfo() => $"{NameValue} {SurnameValue}, {AgeValue} лет";
    protected internal string GetFullName() => $"{NameValue} {SurnameValue}";
    private protected int CalculateStatistics() => AgeValue;
    private static string Required(string value, string field) => string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Поле обязательно.", field) : value.Trim();
}
