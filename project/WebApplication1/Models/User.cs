namespace WebApplication1.Models;

public class User
{
    protected string Username;
    private readonly string _password;
    public string Role { get; }
    public User(string username, string password, string role) { Username = string.IsNullOrWhiteSpace(username) ? throw new ArgumentException("Укажите логин.") : username; _password = password ?? throw new ArgumentNullException(nameof(password)); Role = role; }
    public bool Login(string password) => _password == password;
    public void Logout() { }
    public override string ToString() => $"{Username} ({Role})";
}
public sealed class Admin(string username, string password) : User(username, password, "Администратор");
public sealed class TeacherUser(string username, string password) : User(username, password, "Преподаватель");
public sealed class StudentUser(string username, string password) : User(username, password, "Студент");

public class UserAccount(string login, string password)
{
    private readonly string _login = login;
    private readonly string _password = password;
    public bool IsLoggedIn { get; private set; }
    public bool Login(string login, string password) => IsLoggedIn = _login == login && _password == password;
    public void Logout() => IsLoggedIn = false;
    public override string ToString() => $"Пользователь {_login}";
}
