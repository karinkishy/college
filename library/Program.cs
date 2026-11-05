using System.Globalization;

namespace LibraryManagement;

public class Book
{
    public string Title { get; private set; }
    public string Author { get; }
    public int Year { get; }
    public bool IsBorrowed { get; private set; }
    public string? BorrowerName { get; private set; }
    public DateTime? BorrowedOn { get; private set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void DisplayInfo()
    {
        string status = IsBorrowed ? $"Выдана читателю: {BorrowerName}" : "Доступна";
        Console.WriteLine($"Название: {Title}\nАвтор: {Author}\nГод: {Year}\nСтатус: {status}");
    }

    public void SetTitle(string title) => Title = title;

    public bool IsBookAvailable() => !IsBorrowed;

    public void Borrow(string readerName)
    {
        IsBorrowed = true;
        BorrowerName = readerName;
        BorrowedOn = DateTime.Today;
    }

    public void Return()
    {
        IsBorrowed = false;
        BorrowerName = null;
        BorrowedOn = null;
    }
}

public class Reader
{
    public string FirstName { get; }
    public string? LastName { get; }
    public string? Phone { get; }
    public string FullName => string.Join(' ', new[] { FirstName, LastName }.Where(x => !string.IsNullOrWhiteSpace(x)));

    public Reader(string firstName, string? lastName = null, string? phone = null)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
    }

    public override string ToString() => string.IsNullOrWhiteSpace(Phone) ? FullName : $"{FullName}, тел.: {Phone}";
}

public class Library
{
    private const decimal FinePerDay = 100m;
    private const int LoanPeriodDays = 14;
    private readonly List<Book> books = new();
    private readonly List<Reader> readers = new();

    public static int TotalBooks { get; private set; }

    public void ShowWelcomeMessage() => Console.WriteLine("Добро пожаловать в библиотеку!");

    public static void ShowLibraryName() => Console.WriteLine("Библиотека знаний");

    public void AddBook(string title, string author, int year)
    {
        books.Add(new Book(title, author, year));
        TotalBooks++;
    }

    public int GetBookCount() => books.Count;

    public void ShowBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("В библиотеке пока нет книг.");
            return;
        }

        foreach (Book book in books)
        {
            Console.WriteLine(new string('-', 35));
            book.DisplayInfo();
        }
    }

    public int GetAvailableBooks() => books.Count(book => book.IsBookAvailable());

    public int CalculateBookAge(int year) => Math.Max(0, DateTime.Today.Year - year);

    public Book? FindBook(string title) => books.FirstOrDefault(book =>
        book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

    // Перегрузки поиска: название, автор, год издания.
    public List<Book> SearchBook(string value) => books.Where(book =>
        book.Title.Contains(value, StringComparison.OrdinalIgnoreCase) ||
        book.Author.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList();

    public List<Book> SearchBook(int year) => books.Where(book => book.Year == year).ToList();

    public List<Book> SearchBook(string value, bool searchByAuthor) => searchByAuthor
        ? books.Where(book => book.Author.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList()
        : books.Where(book => book.Title.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList();

    public void AddReader(string firstName) => readers.Add(new Reader(firstName));
    public void AddReader(string firstName, string lastName) => readers.Add(new Reader(firstName, lastName));
    public void AddReader(string firstName, string phone, bool hasPhone) => readers.Add(new Reader(firstName, phone: phone));

    public bool IsReaderRegistered(string name) => readers.Any(reader =>
        reader.FullName.Equals(name, StringComparison.OrdinalIgnoreCase) ||
        reader.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));

    public void ShowReaders()
    {
        if (readers.Count == 0)
        {
            Console.WriteLine("Зарегистрированных читателей нет.");
            return;
        }

        for (int i = 0; i < readers.Count; i++)
            Console.WriteLine($"{i + 1}. {readers[i]}");
    }

    public bool BorrowBook(string title, string readerName)
    {
        Book? book = FindBook(title);
        if (book is null)
        {
            Console.WriteLine("Книга не найдена.");
            return false;
        }
        if (!IsReaderRegistered(readerName))
        {
            Console.WriteLine("Читатель не зарегистрирован.");
            return false;
        }
        if (!book.IsBookAvailable())
        {
            Console.WriteLine("Эта книга уже выдана.");
            return false;
        }

        book.Borrow(readerName);
        Console.WriteLine("Книга успешно выдана!");
        return true;
    }

    public bool ReturnBook(string title)
    {
        Book? book = FindBook(title);
        if (book is null || book.IsBookAvailable())
        {
            Console.WriteLine("Книга не найдена или не была выдана.");
            return false;
        }

        int overdueDays = Math.Max(0, (DateTime.Today - book.BorrowedOn!.Value.Date).Days - LoanPeriodDays);
        decimal fine = CalculateFine(overdueDays);
        book.Return();
        Console.WriteLine(fine > 0 ? $"Книга возвращена. Штраф: {fine:C0}." : "Книга успешно возвращена!");
        return true;
    }

    public static decimal CalculateFine(int overdueDays) => Math.Max(0, overdueDays) * FinePerDay;

    public static int GetMaxBooks(int first, int second) => Math.Max(first, second);

    public int CountBooksRecursive() => CountBooksRecursive(0);
    private int CountBooksRecursive(int index) => index >= books.Count ? 0 : 1 + CountBooksRecursive(index + 1);

    public void SortBooksByYear() => books.Sort((first, second) => first.Year.CompareTo(second.Year));

    public void ShowStatistics()
    {
        int available = GetAvailableBooks();
        Console.WriteLine($"Всего книг: {GetBookCount()}\nДоступных книг: {available}\nВыданных книг: {GetBookCount() - available}\nЗарегистрированных читателей: {readers.Count}");
    }

    public void ShowMenu()
    {
        Console.WriteLine("\n==============================");
        Console.WriteLine("    УПРАВЛЕНИЕ БИБЛИОТЕКОЙ");
        Console.WriteLine("==============================");
        Console.WriteLine("1. Добавить книгу\n2. Показать все книги\n3. Найти книгу\n4. Добавить читателя\n5. Показать читателей\n6. Выдать книгу\n7. Вернуть книгу\n8. Статистика библиотеки\n0. Выход");
        Console.Write("\nВыберите действие: ");
    }
}

public static class Program
{
    public static void Main()
    {
        var library = new Library();
        Library.ShowLibraryName();
        library.ShowWelcomeMessage();

        while (true)
        {
            library.ShowMenu();
            Console.WriteLine();
            switch (Console.ReadLine()?.Trim())
            {
                case "1": AddBook(library); break;
                case "2": library.ShowBooks(); break;
                case "3": SearchBooks(library); break;
                case "4": AddReader(library); break;
                case "5": library.ShowReaders(); break;
                case "6": BorrowBook(library); break;
                case "7": ReturnBook(library); break;
                case "8": library.ShowStatistics(); break;
                case "0": Console.WriteLine("До свидания!"); return;
                default: Console.WriteLine("Введите число от 0 до 8."); break;
            }
        }
    }

    private static void AddBook(Library library)
    {
        Console.Write("Название: "); string title = Console.ReadLine() ?? "";
        Console.Write("Автор: "); string author = Console.ReadLine() ?? "";
        Console.Write("Год: ");
        if (int.TryParse(Console.ReadLine(), out int year) && year is > 0 and <= 9999 && !string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author))
        {
            library.AddBook(title, author, year);
            Console.WriteLine("\nКнига успешно добавлена!");
        }
        else Console.WriteLine("Проверьте введённые данные.");
    }

    private static void SearchBooks(Library library)
    {
        Console.Write("Введите название, автора или год: ");
        string query = Console.ReadLine() ?? "";
        List<Book> results = int.TryParse(query, out int year) ? library.SearchBook(year) : library.SearchBook(query);
        if (results.Count == 0) Console.WriteLine("Книги не найдены.");
        else foreach (Book book in results) { Console.WriteLine(new string('-', 35)); book.DisplayInfo(); }
    }

    private static void AddReader(Library library)
    {
        Console.Write("Имя: "); string firstName = Console.ReadLine() ?? "";
        Console.Write("Фамилия (необязательно): "); string? lastName = Console.ReadLine();
        Console.Write("Телефон (необязательно): "); string? phone = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(firstName)) { Console.WriteLine("Имя обязательно."); return; }
        if (!string.IsNullOrWhiteSpace(phone)) library.AddReader(firstName, phone, true);
        else if (!string.IsNullOrWhiteSpace(lastName)) library.AddReader(firstName, lastName);
        else library.AddReader(firstName);
        Console.WriteLine("Читатель успешно добавлен!");
    }

    private static void BorrowBook(Library library)
    {
        Console.Write("Название книги: "); string title = Console.ReadLine() ?? "";
        Console.Write("Имя читателя: "); string reader = Console.ReadLine() ?? "";
        library.BorrowBook(title, reader);
    }

    private static void ReturnBook(Library library)
    {
        Console.Write("Название книги: ");
        library.ReturnBook(Console.ReadLine() ?? "");
    }
}
