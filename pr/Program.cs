using System;

public class Circle
{
    public const double Pi = 3.14159;
    public static double Area(double radius) => Pi * radius * radius;
}

public class Temperature
{
    public const double MinTemperature = -50;
    public const double MaxTemperature = 50;
    public static bool IsInRange(double temperature) =>
        temperature >= MinTemperature && temperature <= MaxTemperature;
}

public class School
{
    public const int MaxGrade = 100;
    public static bool IsValidGrade(int grade) => grade >= 0 && grade <= MaxGrade;
}

public class Bank
{
    public const decimal MinimumBalance = 1000m;
    public static bool MeetsMinimum(decimal balance) => balance >= MinimumBalance;
}

public class GameSettings
{
    public const int MaxPlayers = 4;
    public const int DefaultLives = 3;

    public static void ShowMenu()
    {
        Console.WriteLine($"Игра: максимум игроков — {MaxPlayers}, жизней у игрока — {DefaultLives}.");
        Console.WriteLine("1. Начать игру");
        Console.WriteLine("2. Настройки");
        Console.WriteLine("3. Выход");
    }
}

public class Product
{
    public const decimal TaxRate = 0.12m;
    public static decimal CalculateTax(decimal price) => price * TaxRate;
    public static decimal CalculateTotal(decimal price) => price + CalculateTax(price);
}

public class SpeedLimit
{
    public const int CityLimit = 60;
    public static bool IsOverLimit(double speed) => speed > CityLimit;
}

public class Exam
{
    public const int PassMark = 50;
    public const int MaxMark = 100;
    public static bool IsValidMark(int mark) => mark >= 0 && mark <= MaxMark;
    public static bool HasPassed(int mark) => IsValidMark(mark) && mark >= PassMark;
}

public class PasswordRules
{
    public const int MinLength = 8;
    public static bool IsLongEnough(string password) => password.Length >= MinLength;
}

public class Shipping
{
    public const decimal FreeDeliveryLimit = 15000m;
    public static bool IsFreeDelivery(decimal orderAmount) =>
        orderAmount >= FreeDeliveryLimit;
}

public class Geometry
{
    public const double Pi = 3.14159;
    public const double SquareRootOfTwo = 1.41421356237;
    public static double Circumference(double radius) => 2 * Pi * radius;
    public static double SquareDiagonal(double side) => side * SquareRootOfTwo;
}

public class SalaryCalculator
{
    public const decimal IncomeTaxRate = 0.10m;
    public static decimal CalculateTax(decimal salary) => salary * IncomeTaxRate;
    public static decimal NetSalary(decimal salary) => salary - CalculateTax(salary);
}

public class LoanCalculator
{
    public const decimal AnnualRate = 0.15m;
    public static decimal CalculateAnnualInterest(decimal loanAmount) =>
        loanAmount * AnnualRate;
}

public class FuelCalculator
{
    public const decimal FuelPrice = 230m;
    public static decimal CalculateCost(double liters) =>
        (decimal)liters * FuelPrice;
}

public class TimeConverter
{
    public const int SecondsPerMinute = 60;
    public const int MinutesPerHour = 60;
    public static long ToSeconds(int hours, int minutes) =>
        ((long)hours * MinutesPerHour + minutes) * SecondsPerMinute;
}

public class DataStorage
{
    public const int BytesPerKilobyte = 1024;
    public static long ToBytes(long kilobytes) => kilobytes * BytesPerKilobyte;
}

public class FitnessCalculator
{
    public const int StepsPerKilometer = 1300;
    public static double KilometersFromSteps(int steps) =>
        (double)steps / StepsPerKilometer;
}

public class ElectricityBill
{
    public const decimal PricePerKWh = 25m;
    public static decimal CalculateCost(double kWh) => (decimal)kWh * PricePerKWh;
}

public class CurrencyConverter
{
    public const decimal UsdToKzt = 500m;
    public static decimal ToKzt(decimal dollars) => dollars * UsdToKzt;
    // В реальном приложении курс меняется, поэтому его лучше получать из API или базы данных.
}

public class DiscountCalculator
{
    public const decimal StandardDiscount = 0.05m;
    public const decimal PremiumDiscount = 0.15m;

    public static decimal FinalPrice(decimal price, bool isPremium)
    {
        decimal discount = isPremium ? PremiumDiscount : StandardDiscount;
        return price * (1 - discount);
    }
}

// Задание 21
public class Student
{
    public static bool IsValidGrade(int grade) => grade >= 0 && grade <= School.MaxGrade;
}

// Задание 22
public class Store
{
    public const decimal TaxRate = 0.12m;
}

public class Cart
{
    public static decimal Tax(decimal subtotal) => subtotal * Store.TaxRate;
    public static decimal Total(decimal subtotal) => subtotal + Tax(subtotal);
}

// Задание 23
public class GameConfig
{
    public const int MaxHealth = 100;
}

public class Player
{
    public int Health { get; private set; }

    public Player(int health) => Health = Math.Clamp(health, 0, GameConfig.MaxHealth);

    public void RestoreHealth(int amount) =>
        Health = Math.Min(GameConfig.MaxHealth, Health + amount);
}

// Задание 24
public class AppConfig
{
    public const string AppName = "Учебное приложение";
    public const string Version = "1.0";
}

public class AboutPage
{
    public static void Show() =>
        Console.WriteLine($"{AppConfig.AppName}, версия {AppConfig.Version}");
}

// Задание 25
public class Hotel
{
    public const int MaxGuestsPerRoom = 4;
}

public class Booking
{
    public static bool IsGuestCountValid(int guests) =>
        guests >= 1 && guests <= Hotel.MaxGuestsPerRoom;
}

// Задание 26
public class Library
{
    public const int MaxLoanDays = 14;
}

public class BookLoan
{
    public static DateTime ReturnDate(DateTime loanDate) =>
        loanDate.AddDays(Library.MaxLoanDays);
}

// Задание 27
public class DeliveryService
{
    public const decimal BaseDeliveryPrice = 1500m;
}

public class Order
{
    public static decimal DeliveryCost() => DeliveryService.BaseDeliveryPrice;
}

// Задание 28
public class University
{
    public const int MinimumPassingScore = 70;
}

public class Applicant
{
    public static bool IsAccepted(int score) =>
        score >= University.MinimumPassingScore;
}

// Задание 29
public class NetworkSettings
{
    public const int DefaultPort = 8080;
}

public class NetworkClient
{
    public static void Start() =>
        Console.WriteLine($"Клиент запущен на порту {NetworkSettings.DefaultPort}.");
}

// Задание 30
public class Clinic
{
    public const int AppointmentDurationMinutes = 30;
}

public class Appointment
{
    public static DateTime EndTime(DateTime start) =>
        start.AddMinutes(Clinic.AppointmentDurationMinutes);
}

public class AgePolicy
{
    public const int MinimumAge = 18;
    public const int MaximumAge = 65;
    public static bool CanRegister(int age) =>
        age >= MinimumAge && age <= MaximumAge;
}

public class ATM
{
    public const decimal MaxWithdrawal = 200000m;

    public static bool CanWithdraw(decimal amount, decimal balance) =>
        amount > 0 && amount <= MaxWithdrawal && amount <= balance;
}

public class Warehouse
{
    public const int MinStock = 5;
    public const int MaxStock = 500;
    public static bool IsStockValid(int quantity) =>
        quantity >= MinStock && quantity <= MaxStock;
}

public class TicketOffice
{
    public const int ChildAgeLimit = 12;
    public const int SeniorAgeLimit = 60;

    public static string TicketCategory(int age)
    {
        if (age < 0) return "Некорректный возраст";
        if (age < ChildAgeLimit) return "Детский билет";
        if (age >= SeniorAgeLimit) return "Льготный билет для старшего возраста";
        return "Стандартный билет";
    }
}

public class LoginPolicy
{
    public const int MaxAttempts = 3;
    public const int LockMinutes = 15;

    public static string StatusAfterAttempts(int failedAttempts) =>
        failedAttempts >= MaxAttempts
            ? $"Аккаунт заблокирован на {LockMinutes} минут."
            : $"Попыток осталось: {MaxAttempts - failedAttempts}.";
}

public class FilePolicy
{
    public const double MaxFileSizeMb = 50;
    public static bool IsUploadAllowed(double fileSizeMb) =>
        fileSizeMb >= 0 && fileSizeMb <= MaxFileSizeMb;
}

public class Tournament
{
    public const int MinTeams = 4;
    public const int MaxTeams = 16;
    public static bool IsTeamCountValid(int teams) =>
        teams >= MinTeams && teams <= MaxTeams;
}

public class Parcel
{
    public const double MaxWeightKg = 20;
    public static bool CanAccept(double weightKg) =>
        weightKg > 0 && weightKg <= MaxWeightKg;
}

public class BookingPolicy
{
    public const int MinAdvanceHours = 2;
    public const int MaxAdvanceDays = 90;

    public static bool IsBookingTimeValid(DateTime bookingTime, DateTime now)
    {
        TimeSpan advance = bookingTime - now;
        return advance.TotalHours >= MinAdvanceHours &&
               advance.TotalDays <= MaxAdvanceDays;
    }
}

public class PasswordPolicy
{
    public const int MinLength = 8;
    public const int MaxLength = 24;

    public static string Validate(string password)
    {
        if (password.Length < MinLength)
            return $"Ошибка: пароль должен содержать минимум {MinLength} символов.";
        if (password.Length > MaxLength)
            return $"Ошибка: пароль должен содержать не более {MaxLength} символов.";
        return "Пароль подходит.";
    }
}

public class RestaurantBill
{
    public const decimal ServiceChargeRate = 0.10m;
    public const decimal TaxRate = 0.12m;

    public static decimal ServiceCharge(decimal amount) =>
        amount * ServiceChargeRate;

    public static decimal Tax(decimal amount) =>
        amount * TaxRate;

    public static decimal Total(decimal amount) =>
        amount + ServiceCharge(amount) + Tax(amount);
}

public class CarRental
{
    public const decimal PricePerDay = 12000m;
    public const decimal Deposit = 30000m;

    public static decimal RentalCost(int days) => days * PricePerDay;
    public static decimal TotalToPay(int days) => RentalCost(days) + Deposit;
}

public class UniversityFees
{
    public const decimal BaseTuition = 900000m;
    public const decimal ScholarshipRate = 0.25m;

    public static decimal TuitionAfterScholarship() =>
        BaseTuition * (1 - ScholarshipRate);
}

public class RPGCharacter
{
    public const int MaxHealth = 100;
    public const int MaxMana = 80;
    public const int MaxLevel = 50;

    public int Health { get; private set; }
    public int Mana { get; private set; }
    public int Level { get; private set; }

    public RPGCharacter(int health, int mana, int level)
    {
        Health = Math.Clamp(health, 0, MaxHealth);
        Mana = Math.Clamp(mana, 0, MaxMana);
        Level = Math.Clamp(level, 1, MaxLevel);
    }

    public void Heal(int amount) =>
        Health = Math.Min(MaxHealth, Health + Math.Max(0, amount));

    public void RestoreMana(int amount) =>
        Mana = Math.Min(MaxMana, Mana + Math.Max(0, amount));

    public void LevelUp() =>
        Level = Math.Min(MaxLevel, Level + 1);
}

public class SmartHome
{
    public const int MinTemperature = 16;
    public const int MaxTemperature = 28;

    public static string TemperatureHint(int temperature)
    {
        if (temperature < MinTemperature)
            return $"Слишком холодно. Установите не менее {MinTemperature}°C.";
        if (temperature > MaxTemperature)
            return $"Слишком жарко. Установите не более {MaxTemperature}°C.";
        return "Температура находится в допустимом диапазоне.";
    }
}

public class InternetPlan
{
    public const decimal MonthlyFee = 5000m;
    public const int IncludedGb = 100;
    public const decimal ExtraGbPrice = 100m;

    public static decimal CalculateBill(int usedGb)
    {
        int extraGb = Math.Max(0, usedGb - IncludedGb);
        return MonthlyFee + extraGb * ExtraGbPrice;
    }
}

public class ParkingLot
{
    public const int FreeMinutes = 15;
    public const decimal PricePerHour = 300m;

    public static decimal CalculateCost(int minutes)
    {
        int paidMinutes = Math.Max(0, minutes - FreeMinutes);
        if (paidMinutes == 0) return 0m;

        decimal hours = (decimal)paidMinutes / 60m;
        return Math.Ceiling(hours) * PricePerHour;
    }
}

public class OrderValidator
{
    public const decimal MinOrderAmount = 1000m;
    public const decimal MaxOrderAmount = 1000000m;

    public static string Validate(decimal amount)
    {
        if (amount < MinOrderAmount)
            return $"Сумма заказа должна быть не меньше {MinOrderAmount}.";
        if (amount > MaxOrderAmount)
            return $"Сумма заказа должна быть не больше {MaxOrderAmount}.";
        return "Сумма заказа допустима.";
    }
}

public class Quiz
{
    public const int QuestionsCount = 20;
    public const int PointsPerQuestion = 5;

    public static int MaximumScore => QuestionsCount * PointsPerQuestion;

    public static double ResultPercent(int correctAnswers)
    {
        int score = correctAnswers * PointsPerQuestion;
        return (double)score / MaximumScore * 100;
    }
}

// Задание 50: предметная область — кафе.
public class CafeConfig
{
    public const decimal TaxRate = 0.12m;
    public const decimal DeliveryFee = 1000m;
    public const decimal FreeDeliveryLimit = 10000m;
}

public class CafeOrder
{
    public decimal Subtotal { get; }

    public CafeOrder(decimal subtotal) => Subtotal = subtotal;

    public decimal Tax => Subtotal * CafeConfig.TaxRate;

    public decimal Delivery =>
        Subtotal >= CafeConfig.FreeDeliveryLimit ? 0m : CafeConfig.DeliveryFee;

    public decimal Total => Subtotal + Tax + Delivery;
}

public class CafeReceipt
{
    public static void Print(CafeOrder order)
    {
        Console.WriteLine($"Сумма заказа: {order.Subtotal:F2}");
        Console.WriteLine($"Налог: {order.Tax:F2}");
        Console.WriteLine($"Доставка: {order.Delivery:F2}");
        Console.WriteLine($"Итого: {order.Total:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Основы и применение констант ===");
        Console.WriteLine($"1. Площадь круга радиусом 5: {Circle.Area(5):F2}");
        Console.WriteLine($"2. Температура 20°C допустима: {Temperature.IsInRange(20)}");
        Console.WriteLine($"3. Оценка 85 корректна: {School.IsValidGrade(85)}");
        Console.WriteLine($"4. Баланс 1500 соответствует минимуму: {Bank.MeetsMinimum(1500m)}");
        Console.WriteLine("5. Игровое меню:");
        GameSettings.ShowMenu();
        Console.WriteLine($"6. Товар 1000: налог {Product.CalculateTax(1000m):F2}, итог {Product.CalculateTotal(1000m):F2}");
        Console.WriteLine($"7. Скорость 70 км/ч превышает лимит: {SpeedLimit.IsOverLimit(70)}");
        Console.WriteLine($"8. Экзамен, результат 75: корректен {Exam.IsValidMark(75)}, сдан {Exam.HasPassed(75)}");
        Console.WriteLine($"9. Пароль 'secret123' подходит: {PasswordRules.IsLongEnough("secret123")}");
        Console.WriteLine($"10. Заказ 16000: доставка бесплатная {Shipping.IsFreeDelivery(16000m)}");

        Console.WriteLine("\n=== Константы в вычислениях ===");
        Console.WriteLine($"11. Окружность радиуса 5: {Geometry.Circumference(5):F2}; диагональ квадрата со стороной 4: {Geometry.SquareDiagonal(4):F2}");
        Console.WriteLine($"12. Зарплата 300000: налог {SalaryCalculator.CalculateTax(300000m):F2}, после удержания {SalaryCalculator.NetSalary(300000m):F2}");
        Console.WriteLine($"13. Годовые проценты по займу 100000: {LoanCalculator.CalculateAnnualInterest(100000m):F2}");
        Console.WriteLine($"14. Топливо 20 литров: {FuelCalculator.CalculateCost(20):F2}");
        Console.WriteLine($"15. 2 часа 30 минут в секундах: {TimeConverter.ToSeconds(2, 30)}");
        Console.WriteLine($"16. 5 килобайт в байтах: {DataStorage.ToBytes(5)}");
        Console.WriteLine($"17. 6500 шагов — примерно {FitnessCalculator.KilometersFromSteps(6500):F2} км");
        Console.WriteLine($"18. Электроэнергия 120 кВт·ч: {ElectricityBill.CalculateCost(120):F2}");
        Console.WriteLine($"19. 10 долларов в тенге: {CurrencyConverter.ToKzt(10m):F2}. Курс в реальной программе лучше получать из изменяемого источника, так как он меняется.");
        Console.WriteLine($"20. Стандартный клиент: {DiscountCalculator.FinalPrice(10000m, false):F2}; премиум: {DiscountCalculator.FinalPrice(10000m, true):F2}");

        Console.WriteLine("\n=== Несколько классов и доступ к константам ===");
        Console.WriteLine($"21. Оценка 95 проверена через School.MaxGrade: {Student.IsValidGrade(95)}");
        Console.WriteLine($"22. Корзина на 5000: налог {Cart.Tax(5000m):F2}, итог {Cart.Total(5000m):F2}");
        var player = new Player(90);
        player.RestoreHealth(30);
        Console.WriteLine($"23. Здоровье игрока после восстановления: {player.Health}/{GameConfig.MaxHealth}");
        Console.Write("24. ");
        AboutPage.Show();
        Console.WriteLine($"25. Бронирование на 3 гостей допустимо: {Booking.IsGuestCountValid(3)}");
        Console.WriteLine($"26. Книга, взятая 1 октября 2026, должна быть возвращена {BookLoan.ReturnDate(new DateTime(2026, 10, 1)):d}");
        Console.WriteLine($"27. Стоимость доставки заказа: {Order.DeliveryCost():F2}");
        Console.WriteLine($"28. Абитуриент с баллом 75 принят: {Applicant.IsAccepted(75)}");
        Console.Write("29. ");
        NetworkClient.Start();
        Console.WriteLine($"30. Приём, начавшийся в 10:00, закончится в {Appointment.EndTime(new DateTime(2026, 10, 16, 10, 0, 0)):HH:mm}");

        Console.WriteLine("\n=== Проверки, условия и бизнес-правила ===");
        Console.WriteLine($"31. Возраст 25 подходит для регистрации: {AgePolicy.CanRegister(25)}");
        Console.WriteLine($"32. Можно снять 50000 при балансе 100000: {ATM.CanWithdraw(50000m, 100000m)}");
        Console.WriteLine($"33. Запас 100 единиц допустим: {Warehouse.IsStockValid(100)}");
        Console.WriteLine($"34. Категория билета для 10 лет: {TicketOffice.TicketCategory(10)}");
        Console.WriteLine($"35. После 3 неудачных попыток: {LoginPolicy.StatusAfterAttempts(3)}");
        Console.WriteLine($"36. Файл размером 20 МБ разрешён: {FilePolicy.IsUploadAllowed(20)}");
        Console.WriteLine($"37. Турнир на 8 команд допустим: {Tournament.IsTeamCountValid(8)}");
        Console.WriteLine($"38. Посылку весом 15 кг можно принять: {Parcel.CanAccept(15)}");
        Console.WriteLine($"39. Бронирование через сутки допустимо: {BookingPolicy.IsBookingTimeValid(DateTime.Now.AddDays(1), DateTime.Now)}");
        Console.WriteLine($"40. Проверка пароля: {PasswordPolicy.Validate("mysecret123")}");

        Console.WriteLine("\n=== Комплексные задания ===");
        Console.WriteLine($"41. Счёт ресторана на 10000: сбор {RestaurantBill.ServiceCharge(10000m):F2}, налог {RestaurantBill.Tax(10000m):F2}, итог {RestaurantBill.Total(10000m):F2}");
        Console.WriteLine($"42. Аренда автомобиля на 3 дня: аренда {CarRental.RentalCost(3):F2}, к оплате с залогом {CarRental.TotalToPay(3):F2}");
        Console.WriteLine($"43. Стоимость обучения после стипендии: {UniversityFees.TuitionAfterScholarship():F2}");
        var character = new RPGCharacter(70, 50, 49);
        character.Heal(50);
        character.RestoreMana(50);
        character.LevelUp();
        Console.WriteLine($"44. Персонаж после улучшений: здоровье {character.Health}/{RPGCharacter.MaxHealth}, мана {character.Mana}/{RPGCharacter.MaxMana}, уровень {character.Level}/{RPGCharacter.MaxLevel}");
        Console.WriteLine($"45. Подсказка умного дома для 30°C: {SmartHome.TemperatureHint(30)}");
        Console.WriteLine($"46. Оплата интернета за 120 ГБ: {InternetPlan.CalculateBill(120):F2}");
        Console.WriteLine($"47. Парковка на 80 минут: {ParkingLot.CalculateCost(80):F2}");
        Console.WriteLine($"48. Проверка заказа на 50000: {OrderValidator.Validate(50000m)}");
        Console.WriteLine($"49. Тест: максимум {Quiz.MaximumScore} баллов; за 16 правильных ответов — {Quiz.ResultPercent(16):F0}%");

        Console.WriteLine("50. Чек кафе:");
        CafeReceipt.Print(new CafeOrder(12000m));
    }
}