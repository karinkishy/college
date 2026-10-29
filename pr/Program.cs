// using System.Globalization;
// // using System;

// // public class Circle
// // {
// //     public const double Pi = 3.14159;
// //     public static double Area(double radius) => Pi * radius * radius;
// // }

// // public class Temperature
// // {
// //     public const double MinTemperature = -50;
// //     public const double MaxTemperature = 50;
// //     public static bool IsInRange(double temperature) =>
// //         temperature >= MinTemperature && temperature <= MaxTemperature;
// // }

// // public class School
// // {
// //     public const int MaxGrade = 100;
// //     public static bool IsValidGrade(int grade) => grade >= 0 && grade <= MaxGrade;
// // }

// // public class Bank
// // {
// //     public const decimal MinimumBalance = 1000m;
// //     public static bool MeetsMinimum(decimal balance) => balance >= MinimumBalance;
// // }

// // public class GameSettings
// // {
// //     public const int MaxPlayers = 4;
// //     public const int DefaultLives = 3;

// //     public static void ShowMenu()
// //     {
// //         Console.WriteLine($"Игра: максимум игроков — {MaxPlayers}, жизней у игрока — {DefaultLives}.");
// //         Console.WriteLine("1. Начать игру");
// //         Console.WriteLine("2. Настройки");
// //         Console.WriteLine("3. Выход");
// //     }
// // }

// // public class Product
// // {
// //     public const decimal TaxRate = 0.12m;
// //     public static decimal CalculateTax(decimal price) => price * TaxRate;
// //     public static decimal CalculateTotal(decimal price) => price + CalculateTax(price);
// // }

// // public class SpeedLimit
// // {
// //     public const int CityLimit = 60;
// //     public static bool IsOverLimit(double speed) => speed > CityLimit;
// // }

// // public class Exam
// // {
// //     public const int PassMark = 50;
// //     public const int MaxMark = 100;
// //     public static bool IsValidMark(int mark) => mark >= 0 && mark <= MaxMark;
// //     public static bool HasPassed(int mark) => IsValidMark(mark) && mark >= PassMark;
// // }

// // public class PasswordRules
// // {
// //     public const int MinLength = 8;
// //     public static bool IsLongEnough(string password) => password.Length >= MinLength;
// // }

// // public class Shipping
// // {
// //     public const decimal FreeDeliveryLimit = 15000m;
// //     public static bool IsFreeDelivery(decimal orderAmount) =>
// //         orderAmount >= FreeDeliveryLimit;
// // }

// // public class Geometry
// // {
// //     public const double Pi = 3.14159;
// //     public const double SquareRootOfTwo = 1.41421356237;
// //     public static double Circumference(double radius) => 2 * Pi * radius;
// //     public static double SquareDiagonal(double side) => side * SquareRootOfTwo;
// // }

// // public class SalaryCalculator
// // {
// //     public const decimal IncomeTaxRate = 0.10m;
// //     public static decimal CalculateTax(decimal salary) => salary * IncomeTaxRate;
// //     public static decimal NetSalary(decimal salary) => salary - CalculateTax(salary);
// // }

// // public class LoanCalculator
// // {
// //     public const decimal AnnualRate = 0.15m;
// //     public static decimal CalculateAnnualInterest(decimal loanAmount) =>
// //         loanAmount * AnnualRate;
// // }

// // public class FuelCalculator
// // {
// //     public const decimal FuelPrice = 230m;
// //     public static decimal CalculateCost(double liters) =>
// //         (decimal)liters * FuelPrice;
// // }

// // public class TimeConverter
// // {
// //     public const int SecondsPerMinute = 60;
// //     public const int MinutesPerHour = 60;
// //     public static long ToSeconds(int hours, int minutes) =>
// //         ((long)hours * MinutesPerHour + minutes) * SecondsPerMinute;
// // }

// // public class DataStorage
// // {
// //     public const int BytesPerKilobyte = 1024;
// //     public static long ToBytes(long kilobytes) => kilobytes * BytesPerKilobyte;
// // }

// // public class FitnessCalculator
// // {
// //     public const int StepsPerKilometer = 1300;
// //     public static double KilometersFromSteps(int steps) =>
// //         (double)steps / StepsPerKilometer;
// // }

// // public class ElectricityBill
// // {
// //     public const decimal PricePerKWh = 25m;
// //     public static decimal CalculateCost(double kWh) => (decimal)kWh * PricePerKWh;
// // }

// // public class CurrencyConverter
// // {
// //     public const decimal UsdToKzt = 500m;
// //     public static decimal ToKzt(decimal dollars) => dollars * UsdToKzt;
// //     // В реальном приложении курс меняется, поэтому его лучше получать из API или базы данных.
// // }

// // public class DiscountCalculator
// // {
// //     public const decimal StandardDiscount = 0.05m;
// //     public const decimal PremiumDiscount = 0.15m;

// //     public static decimal FinalPrice(decimal price, bool isPremium)
// //     {
// //         decimal discount = isPremium ? PremiumDiscount : StandardDiscount;
// //         return price * (1 - discount);
// //     }
// // }

// // // Задание 21
// // public class Student
// // {
// //     public static bool IsValidGrade(int grade) => grade >= 0 && grade <= School.MaxGrade;
// // }

// // // Задание 22
// // public class Store
// // {
// //     public const decimal TaxRate = 0.12m;
// // }

// // public class Cart
// // {
// //     public static decimal Tax(decimal subtotal) => subtotal * Store.TaxRate;
// //     public static decimal Total(decimal subtotal) => subtotal + Tax(subtotal);
// // }

// // // Задание 23
// // public class GameConfig
// // {
// //     public const int MaxHealth = 100;
// // }

// // public class Player
// // {
// //     public int Health { get; private set; }

// //     public Player(int health) => Health = Math.Clamp(health, 0, GameConfig.MaxHealth);

// //     public void RestoreHealth(int amount) =>
// //         Health = Math.Min(GameConfig.MaxHealth, Health + amount);
// // }

// // // Задание 24
// // public class AppConfig
// // {
// //     public const string AppName = "Учебное приложение";
// //     public const string Version = "1.0";
// // }

// // public class AboutPage
// // {
// //     public static void Show() =>
// //         Console.WriteLine($"{AppConfig.AppName}, версия {AppConfig.Version}");
// // }

// // // Задание 25
// // public class Hotel
// // {
// //     public const int MaxGuestsPerRoom = 4;
// // }

// // public class Booking
// // {
// //     public static bool IsGuestCountValid(int guests) =>
// //         guests >= 1 && guests <= Hotel.MaxGuestsPerRoom;
// // }

// // // Задание 26
// // public class Library
// // {
// //     public const int MaxLoanDays = 14;
// // }

// // public class BookLoan
// // {
// //     public static DateTime ReturnDate(DateTime loanDate) =>
// //         loanDate.AddDays(Library.MaxLoanDays);
// // }

// // // Задание 27
// // public class DeliveryService
// // {
// //     public const decimal BaseDeliveryPrice = 1500m;
// // }

// // public class Order
// // {
// //     public static decimal DeliveryCost() => DeliveryService.BaseDeliveryPrice;
// // }

// // // Задание 28
// // public class University
// // {
// //     public const int MinimumPassingScore = 70;
// // }

// // public class Applicant
// // {
// //     public static bool IsAccepted(int score) =>
// //         score >= University.MinimumPassingScore;
// // }

// // // Задание 29
// // public class NetworkSettings
// // {
// //     public const int DefaultPort = 8080;
// // }

// // public class NetworkClient
// // {
// //     public static void Start() =>
// //         Console.WriteLine($"Клиент запущен на порту {NetworkSettings.DefaultPort}.");
// // }

// // // Задание 30
// // public class Clinic
// // {
// //     public const int AppointmentDurationMinutes = 30;
// // }

// // public class Appointment
// // {
// //     public static DateTime EndTime(DateTime start) =>
// //         start.AddMinutes(Clinic.AppointmentDurationMinutes);
// // }

// // public class AgePolicy
// // {
// //     public const int MinimumAge = 18;
// //     public const int MaximumAge = 65;
// //     public static bool CanRegister(int age) =>
// //         age >= MinimumAge && age <= MaximumAge;
// // }

// // public class ATM
// // {
// //     public const decimal MaxWithdrawal = 200000m;

// //     public static bool CanWithdraw(decimal amount, decimal balance) =>
// //         amount > 0 && amount <= MaxWithdrawal && amount <= balance;
// // }

// // public class Warehouse
// // {
// //     public const int MinStock = 5;
// //     public const int MaxStock = 500;
// //     public static bool IsStockValid(int quantity) =>
// //         quantity >= MinStock && quantity <= MaxStock;
// // }

// // public class TicketOffice
// // {
// //     public const int ChildAgeLimit = 12;
// //     public const int SeniorAgeLimit = 60;

// //     public static string TicketCategory(int age)
// //     {
// //         if (age < 0) return "Некорректный возраст";
// //         if (age < ChildAgeLimit) return "Детский билет";
// //         if (age >= SeniorAgeLimit) return "Льготный билет для старшего возраста";
// //         return "Стандартный билет";
// //     }
// // }

// // public class LoginPolicy
// // {
// //     public const int MaxAttempts = 3;
// //     public const int LockMinutes = 15;

// //     public static string StatusAfterAttempts(int failedAttempts) =>
// //         failedAttempts >= MaxAttempts
// //             ? $"Аккаунт заблокирован на {LockMinutes} минут."
// //             : $"Попыток осталось: {MaxAttempts - failedAttempts}.";
// // }

// // public class FilePolicy
// // {
// //     public const double MaxFileSizeMb = 50;
// //     public static bool IsUploadAllowed(double fileSizeMb) =>
// //         fileSizeMb >= 0 && fileSizeMb <= MaxFileSizeMb;
// // }

// // public class Tournament
// // {
// //     public const int MinTeams = 4;
// //     public const int MaxTeams = 16;
// //     public static bool IsTeamCountValid(int teams) =>
// //         teams >= MinTeams && teams <= MaxTeams;
// // }

// // public class Parcel
// // {
// //     public const double MaxWeightKg = 20;
// //     public static bool CanAccept(double weightKg) =>
// //         weightKg > 0 && weightKg <= MaxWeightKg;
// // }

// // public class BookingPolicy
// // {
// //     public const int MinAdvanceHours = 2;
// //     public const int MaxAdvanceDays = 90;

// //     public static bool IsBookingTimeValid(DateTime bookingTime, DateTime now)
// //     {
// //         TimeSpan advance = bookingTime - now;
// //         return advance.TotalHours >= MinAdvanceHours &&
// //                advance.TotalDays <= MaxAdvanceDays;
// //     }
// // }

// // public class PasswordPolicy
// // {
// //     public const int MinLength = 8;
// //     public const int MaxLength = 24;

// //     public static string Validate(string password)
// //     {
// //         if (password.Length < MinLength)
// //             return $"Ошибка: пароль должен содержать минимум {MinLength} символов.";
// //         if (password.Length > MaxLength)
// //             return $"Ошибка: пароль должен содержать не более {MaxLength} символов.";
// //         return "Пароль подходит.";
// //     }
// // }

// // public class RestaurantBill
// // {
// //     public const decimal ServiceChargeRate = 0.10m;
// //     public const decimal TaxRate = 0.12m;

// //     public static decimal ServiceCharge(decimal amount) =>
// //         amount * ServiceChargeRate;

// //     public static decimal Tax(decimal amount) =>
// //         amount * TaxRate;

// //     public static decimal Total(decimal amount) =>
// //         amount + ServiceCharge(amount) + Tax(amount);
// // }

// // public class CarRental
// // {
// //     public const decimal PricePerDay = 12000m;
// //     public const decimal Deposit = 30000m;

// //     public static decimal RentalCost(int days) => days * PricePerDay;
// //     public static decimal TotalToPay(int days) => RentalCost(days) + Deposit;
// // }

// // public class UniversityFees
// // {
// //     public const decimal BaseTuition = 900000m;
// //     public const decimal ScholarshipRate = 0.25m;

// //     public static decimal TuitionAfterScholarship() =>
// //         BaseTuition * (1 - ScholarshipRate);
// // }

// // public class RPGCharacter
// // {
// //     public const int MaxHealth = 100;
// //     public const int MaxMana = 80;
// //     public const int MaxLevel = 50;

// //     public int Health { get; private set; }
// //     public int Mana { get; private set; }
// //     public int Level { get; private set; }

// //     public RPGCharacter(int health, int mana, int level)
// //     {
// //         Health = Math.Clamp(health, 0, MaxHealth);
// //         Mana = Math.Clamp(mana, 0, MaxMana);
// //         Level = Math.Clamp(level, 1, MaxLevel);
// //     }

// //     public void Heal(int amount) =>
// //         Health = Math.Min(MaxHealth, Health + Math.Max(0, amount));

// //     public void RestoreMana(int amount) =>
// //         Mana = Math.Min(MaxMana, Mana + Math.Max(0, amount));

// //     public void LevelUp() =>
// //         Level = Math.Min(MaxLevel, Level + 1);
// // }

// // public class SmartHome
// // {
// //     public const int MinTemperature = 16;
// //     public const int MaxTemperature = 28;

// //     public static string TemperatureHint(int temperature)
// //     {
// //         if (temperature < MinTemperature)
// //             return $"Слишком холодно. Установите не менее {MinTemperature}°C.";
// //         if (temperature > MaxTemperature)
// //             return $"Слишком жарко. Установите не более {MaxTemperature}°C.";
// //         return "Температура находится в допустимом диапазоне.";
// //     }
// // }

// // public class InternetPlan
// // {
// //     public const decimal MonthlyFee = 5000m;
// //     public const int IncludedGb = 100;
// //     public const decimal ExtraGbPrice = 100m;

// //     public static decimal CalculateBill(int usedGb)
// //     {
// //         int extraGb = Math.Max(0, usedGb - IncludedGb);
// //         return MonthlyFee + extraGb * ExtraGbPrice;
// //     }
// // }

// // public class ParkingLot
// // {
// //     public const int FreeMinutes = 15;
// //     public const decimal PricePerHour = 300m;

// //     public static decimal CalculateCost(int minutes)
// //     {
// //         int paidMinutes = Math.Max(0, minutes - FreeMinutes);
// //         if (paidMinutes == 0) return 0m;

// //         decimal hours = (decimal)paidMinutes / 60m;
// //         return Math.Ceiling(hours) * PricePerHour;
// //     }
// // }

// // public class OrderValidator
// // {
// //     public const decimal MinOrderAmount = 1000m;
// //     public const decimal MaxOrderAmount = 1000000m;

// //     public static string Validate(decimal amount)
// //     {
// //         if (amount < MinOrderAmount)
// //             return $"Сумма заказа должна быть не меньше {MinOrderAmount}.";
// //         if (amount > MaxOrderAmount)
// //             return $"Сумма заказа должна быть не больше {MaxOrderAmount}.";
// //         return "Сумма заказа допустима.";
// //     }
// // }

// // public class Quiz
// // {
// //     public const int QuestionsCount = 20;
// //     public const int PointsPerQuestion = 5;

// //     public static int MaximumScore => QuestionsCount * PointsPerQuestion;

// //     public static double ResultPercent(int correctAnswers)
// //     {
// //         int score = correctAnswers * PointsPerQuestion;
// //         return (double)score / MaximumScore * 100;
// //     }
// // }

// // // Задание 50: предметная область — кафе.
// // public class CafeConfig
// // {
// //     public const decimal TaxRate = 0.12m;
// //     public const decimal DeliveryFee = 1000m;
// //     public const decimal FreeDeliveryLimit = 10000m;
// // }

// // public class CafeOrder
// // {
// //     public decimal Subtotal { get; }

// //     public CafeOrder(decimal subtotal) => Subtotal = subtotal;

// //     public decimal Tax => Subtotal * CafeConfig.TaxRate;

// //     public decimal Delivery =>
// //         Subtotal >= CafeConfig.FreeDeliveryLimit ? 0m : CafeConfig.DeliveryFee;

// //     public decimal Total => Subtotal + Tax + Delivery;
// // }

// // public class CafeReceipt
// // {
// //     public static void Print(CafeOrder order)
// //     {
// //         Console.WriteLine($"Сумма заказа: {order.Subtotal:F2}");
// //         Console.WriteLine($"Налог: {order.Tax:F2}");
// //         Console.WriteLine($"Доставка: {order.Delivery:F2}");
// //         Console.WriteLine($"Итого: {order.Total:F2}");
// //     }
// // }

// // public class Program
// // {
// //     public static void Main()
// //     {
// //         Console.WriteLine("=== Основы и применение констант ===");
// //         Console.WriteLine($"1. Площадь круга радиусом 5: {Circle.Area(5):F2}");
// //         Console.WriteLine($"2. Температура 20°C допустима: {Temperature.IsInRange(20)}");
// //         Console.WriteLine($"3. Оценка 85 корректна: {School.IsValidGrade(85)}");
// //         Console.WriteLine($"4. Баланс 1500 соответствует минимуму: {Bank.MeetsMinimum(1500m)}");
// //         Console.WriteLine("5. Игровое меню:");
// //         GameSettings.ShowMenu();
// //         Console.WriteLine($"6. Товар 1000: налог {Product.CalculateTax(1000m):F2}, итог {Product.CalculateTotal(1000m):F2}");
// //         Console.WriteLine($"7. Скорость 70 км/ч превышает лимит: {SpeedLimit.IsOverLimit(70)}");
// //         Console.WriteLine($"8. Экзамен, результат 75: корректен {Exam.IsValidMark(75)}, сдан {Exam.HasPassed(75)}");
// //         Console.WriteLine($"9. Пароль 'secret123' подходит: {PasswordRules.IsLongEnough("secret123")}");
// //         Console.WriteLine($"10. Заказ 16000: доставка бесплатная {Shipping.IsFreeDelivery(16000m)}");

// //         Console.WriteLine("\n=== Константы в вычислениях ===");
// //         Console.WriteLine($"11. Окружность радиуса 5: {Geometry.Circumference(5):F2}; диагональ квадрата со стороной 4: {Geometry.SquareDiagonal(4):F2}");
// //         Console.WriteLine($"12. Зарплата 300000: налог {SalaryCalculator.CalculateTax(300000m):F2}, после удержания {SalaryCalculator.NetSalary(300000m):F2}");
// //         Console.WriteLine($"13. Годовые проценты по займу 100000: {LoanCalculator.CalculateAnnualInterest(100000m):F2}");
// //         Console.WriteLine($"14. Топливо 20 литров: {FuelCalculator.CalculateCost(20):F2}");
// //         Console.WriteLine($"15. 2 часа 30 минут в секундах: {TimeConverter.ToSeconds(2, 30)}");
// //         Console.WriteLine($"16. 5 килобайт в байтах: {DataStorage.ToBytes(5)}");
// //         Console.WriteLine($"17. 6500 шагов — примерно {FitnessCalculator.KilometersFromSteps(6500):F2} км");
// //         Console.WriteLine($"18. Электроэнергия 120 кВт·ч: {ElectricityBill.CalculateCost(120):F2}");
// //         Console.WriteLine($"19. 10 долларов в тенге: {CurrencyConverter.ToKzt(10m):F2}. Курс в реальной программе лучше получать из изменяемого источника, так как он меняется.");
// //         Console.WriteLine($"20. Стандартный клиент: {DiscountCalculator.FinalPrice(10000m, false):F2}; премиум: {DiscountCalculator.FinalPrice(10000m, true):F2}");

// //         Console.WriteLine("\n=== Несколько классов и доступ к константам ===");
// //         Console.WriteLine($"21. Оценка 95 проверена через School.MaxGrade: {Student.IsValidGrade(95)}");
// //         Console.WriteLine($"22. Корзина на 5000: налог {Cart.Tax(5000m):F2}, итог {Cart.Total(5000m):F2}");
// //         var player = new Player(90);
// //         player.RestoreHealth(30);
// //         Console.WriteLine($"23. Здоровье игрока после восстановления: {player.Health}/{GameConfig.MaxHealth}");
// //         Console.Write("24. ");
// //         AboutPage.Show();
// //         Console.WriteLine($"25. Бронирование на 3 гостей допустимо: {Booking.IsGuestCountValid(3)}");
// //         Console.WriteLine($"26. Книга, взятая 1 октября 2026, должна быть возвращена {BookLoan.ReturnDate(new DateTime(2026, 10, 1)):d}");
// //         Console.WriteLine($"27. Стоимость доставки заказа: {Order.DeliveryCost():F2}");
// //         Console.WriteLine($"28. Абитуриент с баллом 75 принят: {Applicant.IsAccepted(75)}");
// //         Console.Write("29. ");
// //         NetworkClient.Start();
// //         Console.WriteLine($"30. Приём, начавшийся в 10:00, закончится в {Appointment.EndTime(new DateTime(2026, 10, 16, 10, 0, 0)):HH:mm}");

// //         Console.WriteLine("\n=== Проверки, условия и бизнес-правила ===");
// //         Console.WriteLine($"31. Возраст 25 подходит для регистрации: {AgePolicy.CanRegister(25)}");
// //         Console.WriteLine($"32. Можно снять 50000 при балансе 100000: {ATM.CanWithdraw(50000m, 100000m)}");
// //         Console.WriteLine($"33. Запас 100 единиц допустим: {Warehouse.IsStockValid(100)}");
// //         Console.WriteLine($"34. Категория билета для 10 лет: {TicketOffice.TicketCategory(10)}");
// //         Console.WriteLine($"35. После 3 неудачных попыток: {LoginPolicy.StatusAfterAttempts(3)}");
// //         Console.WriteLine($"36. Файл размером 20 МБ разрешён: {FilePolicy.IsUploadAllowed(20)}");
// //         Console.WriteLine($"37. Турнир на 8 команд допустим: {Tournament.IsTeamCountValid(8)}");
// //         Console.WriteLine($"38. Посылку весом 15 кг можно принять: {Parcel.CanAccept(15)}");
// //         Console.WriteLine($"39. Бронирование через сутки допустимо: {BookingPolicy.IsBookingTimeValid(DateTime.Now.AddDays(1), DateTime.Now)}");
// //         Console.WriteLine($"40. Проверка пароля: {PasswordPolicy.Validate("mysecret123")}");

// //         Console.WriteLine("\n=== Комплексные задания ===");
// //         Console.WriteLine($"41. Счёт ресторана на 10000: сбор {RestaurantBill.ServiceCharge(10000m):F2}, налог {RestaurantBill.Tax(10000m):F2}, итог {RestaurantBill.Total(10000m):F2}");
// //         Console.WriteLine($"42. Аренда автомобиля на 3 дня: аренда {CarRental.RentalCost(3):F2}, к оплате с залогом {CarRental.TotalToPay(3):F2}");
// //         Console.WriteLine($"43. Стоимость обучения после стипендии: {UniversityFees.TuitionAfterScholarship():F2}");
// //         var character = new RPGCharacter(70, 50, 49);
// //         character.Heal(50);
// //         character.RestoreMana(50);
// //         character.LevelUp();
// //         Console.WriteLine($"44. Персонаж после улучшений: здоровье {character.Health}/{RPGCharacter.MaxHealth}, мана {character.Mana}/{RPGCharacter.MaxMana}, уровень {character.Level}/{RPGCharacter.MaxLevel}");
// //         Console.WriteLine($"45. Подсказка умного дома для 30°C: {SmartHome.TemperatureHint(30)}");
// //         Console.WriteLine($"46. Оплата интернета за 120 ГБ: {InternetPlan.CalculateBill(120):F2}");
// //         Console.WriteLine($"47. Парковка на 80 минут: {ParkingLot.CalculateCost(80):F2}");
// //         Console.WriteLine($"48. Проверка заказа на 50000: {OrderValidator.Validate(50000m)}");
// //         Console.WriteLine($"49. Тест: максимум {Quiz.MaximumScore} баллов; за 16 правильных ответов — {Quiz.ResultPercent(16):F0}%");

// //         Console.WriteLine("50. Чек кафе:");
// //         CafeReceipt.Print(new CafeOrder(12000m));
// //     }
// // }


// public class Program
// {
//     private const double Pi = Math.PI;

//     public static int Sum(int a, int b) => a + b;
//     public static int Sum(int a, int b, int c) => checked(a + b + c);
//     public static double Sum(double a, double b) => a + b;
//     public static int Subtract(int a, int b) => a - b;
//     public static double Subtract(double a, double b) => a - b;
//     public static int Multiply(int a, int b) => checked(a * b);
//     public static int Multiply(int a, int b, int c) => checked(a * b * c);
//     public static int Multiply(int a, int b, int c, int d) => checked(a * b * c * d);

//     public static int Divide(int a, int b)
//     {
//         if (b == 0) throw new DivideByZeroException("Деление на ноль невозможно.");
//         return a / b;
//     }
//     public static double Divide(double a, double b)
//     {
//         if (b == 0) throw new DivideByZeroException("Деление на ноль невозможно.");
//         return a / b;
//     }
//     public static double CalculateArea(double side)
//     {
//         if (side < 0) throw new ArgumentOutOfRangeException(nameof(side));
//         return side * side;
//     }
//     public static double CalculateArea(double width, double height)
//     {
//         if (width < 0 || height < 0) throw new ArgumentOutOfRangeException("Размеры не могут быть отрицательными.");
//         return width * height;
//     }
//     public static double CalculateArea(int side)
//     {
//         if (side < 0) throw new ArgumentOutOfRangeException(nameof(side));
//         return (double)side * side;
//     }
//     public static double CalculateArea(int width, int height)
//     {
//         if (width < 0 || height < 0) throw new ArgumentOutOfRangeException("Размеры не могут быть отрицательными.");
//         return (double)width * height;
//     }
//     public static double CalculateCircleArea(double radius)
//     {
//         if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius));
//         return Pi * radius * radius;
//     }

//     public static int Max(int a, int b) => Math.Max(a, b);
//     public static int Max(int a, int b, int c) => Math.Max(a, Math.Max(b, c));
//     public static int Max(int a, int b, int c, int d) => Math.Max(Math.Max(a, b), Math.Max(c, d));
//     public static double Max(double a, double b) => Math.Max(a, b);
//     public static double Max(double a, double b, double c) => Math.Max(a, Math.Max(b, c));
//     public static double Max(double a, double b, double c, double d) => Math.Max(Math.Max(a, b), Math.Max(c, d));
//     public static int Min(int a, int b) => Math.Min(a, b);
//     public static int Min(int a, int b, int c) => Math.Min(a, Math.Min(b, c));

//     public static double Power(int value, int exponent) => Math.Pow(value, exponent);
//     public static double Power(double value, double exponent) => Math.Pow(value, exponent);
//     public static void Display(int value) => Console.WriteLine(value);
//     public static void Display(string value) => Console.WriteLine(value);
//     public static void Display(double value) => Console.WriteLine(value);
//     public static void Greet() => Console.WriteLine("Привет!");
//     public static void Greet(string name) => Console.WriteLine($"Привет, {name}!");
//     public static void Greet(string name, int age) => Console.WriteLine($"Привет, {name}! Тебе {age} лет.");

//     public static double ConvertTemperature(double celsius) => celsius * 9 / 5 + 32;
//     public static double ConvertTemperature(double temperature, bool toCelsius)
//     {
//         if (toCelsius) return (temperature - 32) * 5 / 9;
//         return ConvertTemperature(temperature);
//     }

//     public static double CalculatePerimeter(double side)
//     {
//         if (side < 0) throw new ArgumentOutOfRangeException(nameof(side));
//         return 4 * side;
//     }
//     public static double CalculatePerimeter(double width, double height)
//     {
//         if (width < 0 || height < 0) throw new ArgumentOutOfRangeException("Размеры не могут быть отрицательными.");
//         return 2 * (width + height);
//     }
//     public static double CalculatePerimeter(double a, double b, double c)
//     {
//         if (a < 0 || b < 0 || c < 0) throw new ArgumentOutOfRangeException("Стороны не могут быть отрицательными.");
//         return a + b + c;
//     }

//     public static double Average(int a, int b) => ((double)a + b) / 2;
//     public static double Average(int a, int b, int c) => ((double)a + b + c) / 3;
//     public static double Average(int a, int b, int c, int d) => ((double)a + b + c + d) / 4;
//     public static bool Check(int value) => value > 0;
//     public static bool Check(double value) => value > 0;
//     public static int Count(string value) => value.Length;
//     public static int Count(int[] values) => values.Length;
//     public static string Combine(string a, string b) => a + b;
//     public static string Combine(string a, string b, string c) => a + b + c;
//     public static string Combine(string value, int number) => value + number;

//     public static string FormatName(string firstName) => firstName.Trim();
//     public static string FormatName(string firstName, string lastName) => $"{firstName.Trim()} {lastName.Trim()}";
//     public static string FormatName(string firstName, string lastName, string middleName) => $"{lastName.Trim()} {firstName.Trim()} {middleName.Trim()}";
//     public static bool IsEven(int value) => value % 2 == 0;
//     public static bool IsEven(int first, int second) => IsEven(first) && IsEven(second);

//     public static long Factorial(int value) => Factorial((long)value);
//     public static long Factorial(long value)
//     {
//         if (value < 0 || value > 20) throw new ArgumentOutOfRangeException(nameof(value), "Для результата типа long допустимы числа от 0 до 20.");
//         long result = 1;
//         for (long i = 2; i <= value; i++) result = checked(result * i);
//         return result;
//     }

//     public static int Find(int[] values, int target) => Array.IndexOf(values, target);
//     public static int Find(string value, string substring) => value.IndexOf(substring, StringComparison.Ordinal);
//     public static string Repeat(string value, int count)
//     {
//         if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
//         return string.Concat(Enumerable.Repeat(value, count));
//     }
//     public static string Repeat(char value, int count)
//     {
//         if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
//         return new string(value, count);
//     }
//     public static string RemoveSpaces(string value) => value.Replace(" ", string.Empty);
//     public static string RemoveSpaces(string value, bool trimOnly)
//     {
//         if (trimOnly) return value.Trim();
//         return RemoveSpaces(value);
//     }
//     public static int CountDigits(int value) => CountDigits(value.ToString(CultureInfo.InvariantCulture));
//     public static int CountDigits(string value) => value.Count(char.IsDigit);
//     public static string Reverse(string value) => new(value.Reverse().ToArray());
//     public static int[] Reverse(int[] values) => values.Reverse().ToArray();
//     public static bool IsPalindrome(string value) => string.Equals(value, Reverse(value), StringComparison.OrdinalIgnoreCase);
//     public static bool IsPalindrome(int value) => value >= 0 && IsPalindrome(value.ToString(CultureInfo.InvariantCulture));

//     public static long RoundValue(double value) => checked((long)Math.Round(value, MidpointRounding.AwayFromZero));
//     public static double RoundValue(double value, int digits) => Math.Round(value, digits, MidpointRounding.AwayFromZero);
//     public static int ConvertValue(string value) => int.Parse(value, CultureInfo.InvariantCulture);
//     public static string ConvertValue(int value) => value.ToString(CultureInfo.InvariantCulture);
//     public static double CalculateAverage(int[] values)
//     {
//         if (values.Length == 0) throw new ArgumentException("Массив не должен быть пустым.", nameof(values));
//         return values.Average();
//     }
//     public static double CalculateAverage(double[] values)
//     {
//         if (values.Length == 0) throw new ArgumentException("Массив не должен быть пустым.", nameof(values));
//         return values.Average();
//     }
//     public static double CalculateAverage(double a, double b) => (a + b) / 2;
//     public static double Calculate(int a, int b) => a + b;
//     public static int Calculate(int a, int b, int c) => checked(a + b + c);
//     public static double Calculate(double a, double b) => a + b;

//     public static decimal CalculatePrice(decimal price) => price;
//     public static decimal CalculatePrice(decimal price, int quantity) => price * quantity;
//     public static decimal CalculatePrice(decimal[] prices, decimal discountPercent) => prices.Sum() * (1 - discountPercent / 100);
//     public static decimal CalculateSalary(decimal salary) => salary;
//     public static decimal CalculateSalary(decimal salary, decimal bonus) => salary + bonus;
//     public static decimal CalculateSalary(decimal salary, decimal bonus, decimal taxPercent) => (salary + bonus) * (1 - taxPercent / 100);
//     public static decimal Deposit(decimal balance, int amount)
//     {
//         if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
//         return balance + amount;
//     }
//     public static decimal Deposit(decimal balance, double amount)
//     {
//         if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
//         return balance + (decimal)amount;
//     }
//     public static decimal Withdraw(decimal balance, decimal amount)
//     {
//         if (amount < 0 || amount > balance) throw new ArgumentOutOfRangeException(nameof(amount), "Недостаточно средств или сумма некорректна.");
//         return balance - amount;
//     }
//     public static decimal Withdraw(decimal balance, decimal amount, decimal fee) => Withdraw(balance, amount + fee);

//     public static void Main()
//     {
        
//     }
// }

using System.Globalization;
using System.Text;

public class Car
{
    public static void ShowInfo(string brand) => Console.WriteLine(brand);
    public static void ShowInfo(string brand, int year) => Console.WriteLine($"{brand}, {year}");
    public static void ShowInfo(string brand, int year, decimal price) => Console.WriteLine($"{brand}, {year}, {price:C}");
}

public class StudentGrading
{
    public static int CalculateGrade(double score) => Grade(score);
    public static int CalculateGrade(double first, double second) => Grade((first + second) / 2);
    public static int CalculateGrade(double first, double second, double third) => Grade((first + second + third) / 3);
    private static int Grade(double score)
    {
        if (score < 0 || score > 100) throw new ArgumentOutOfRangeException(nameof(score));
        if (score >= 90) return 5;
        if (score >= 75) return 4;
        if (score >= 50) return 3;
        return 2;
    }
}

public class Discounts
{
    public static decimal CalculateDiscount(decimal price, int percent) => price * percent / 100;
    public static decimal CalculateDiscount(decimal price, decimal fixedAmount) => Math.Min(price, fixedAmount);
}

public class Delivery
{
    public static decimal CalculateDelivery() => 100m;
    public static decimal CalculateDelivery(bool express)
    {
        if (express) return 250m;
        return 100m;
    }
    public static decimal CalculateDelivery(decimal weight, bool express)
    {
        if (weight < 0) throw new ArgumentOutOfRangeException(nameof(weight));
        decimal basePrice = 100m;
        if (express) basePrice = 250m;
        return basePrice + weight * 20m;
    }
}

public class Book
{
    public static void DisplayBook(string title) => Console.WriteLine(title);
    public static void DisplayBook(string title, string author) => Console.WriteLine($"{title} — {author}");
    public static void DisplayBook(string title, string author, int year) => Console.WriteLine($"{title} — {author}, {year}");
}

public class GameScore
{
    public static int AddScore(int score, int points) => checked(score + points);
    public static int AddScore(int score, int points, int bonus) => checked(score + points + bonus);
    public static int AddScore(int score, int points, double multiplier) => checked(score + (int)Math.Round(points * multiplier));
}

public class FileStorage
{
    public static void SaveFile(string path, string text) => File.WriteAllText(path, text);
    public static void SaveFile(string path, string[] lines) => File.WriteAllLines(path, lines);
    public static void SaveFile(string path, string text, Encoding encoding) => File.WriteAllText(path, text, encoding);
}

public class GeometryVolume
{
    public static double CalculateVolume(double cubeSide)
    {
        CheckPositive(cubeSide, nameof(cubeSide));
        return Math.Pow(cubeSide, 3);
    }
    public static double CalculateVolume(double length, double width, double height)
    {
        CheckPositive(length, nameof(length)); CheckPositive(width, nameof(width)); CheckPositive(height, nameof(height));
        return length * width * height;
    }
    public static double CalculateVolume(double radius, double height, bool cylinder)
    {
        CheckPositive(radius, nameof(radius)); CheckPositive(height, nameof(height));
        return Math.PI * radius * radius * height;
    }
    private static void CheckPositive(double value, string name)
    {
        if (value < 0) throw new ArgumentOutOfRangeException(name);
    }
}

public class Taxi
{
    public static decimal CalculateFare(double distance) => (decimal)distance * 150m;
    public static decimal CalculateFare(double distance, int waitingMinutes) => CalculateFare(distance) + waitingMinutes * 20m;
    public static decimal CalculateFare(double distance, string carClass)
    {
        decimal rate = carClass.ToLowerInvariant() switch
        {
            "business" => 300m,
            "comfort" => 200m,
            "эконом" or "economy" => 150m,
            _ => throw new ArgumentException("Неизвестный класс автомобиля.", nameof(carClass))
        };
        return (decimal)distance * rate;
    }
}

public class LibrarySearch
{
    public static bool SearchBook(string title, string query) => title.Contains(query, StringComparison.OrdinalIgnoreCase);
    public static bool SearchBook(string title, string author, string query) => title.Contains(query, StringComparison.OrdinalIgnoreCase) || author.Contains(query, StringComparison.OrdinalIgnoreCase);
    public static bool SearchBook(string title, string author, string titleQuery, string authorQuery) => title.Contains(titleQuery, StringComparison.OrdinalIgnoreCase) && author.Contains(authorQuery, StringComparison.OrdinalIgnoreCase);
}

public class ArrayTools
{
    public static int[] Sort(int[] values) { int[] result = (int[])values.Clone(); Array.Sort(result); return result; }
    public static double[] Sort(double[] values) { double[] result = (double[])values.Clone(); Array.Sort(result); return result; }
    public static string[] Sort(string[] values) { string[] result = (string[])values.Clone(); Array.Sort(result, StringComparer.Ordinal); return result; }
}

public record ArrayStatistics(double Minimum, double Maximum, double Average);
public class Statistics
{
    public static ArrayStatistics Analyze(int[] values) => Analyze(values.Select(value => (double)value).ToArray());
    public static ArrayStatistics Analyze(double[] values)
    {
        if (values.Length == 0) throw new ArgumentException("Массив не должен быть пустым.", nameof(values));
        return new ArrayStatistics(values.Min(), values.Max(), values.Average());
    }
}

public class PasswordRules
{
    public static bool ValidatePassword(string password, int minLength) => password.Length >= minLength;
    public static bool ValidatePassword(string password, int minLength, bool requireDigit) => ValidatePassword(password, minLength) && (!requireDigit || password.Any(char.IsDigit));
    public static bool ValidatePassword(string password, int minLength, bool requireDigit, bool requireSpecial)
    {
        if (!ValidatePassword(password, minLength, requireDigit)) return false;
        if (requireSpecial && !password.Any(character => !char.IsLetterOrDigit(character))) return false;
        return true;
    }
}

public class CurrencyConverter
{
    private const decimal FixedRate = 500m;
    public static decimal ConvertCurrency(decimal amount) => amount * FixedRate;
    public static decimal ConvertCurrency(decimal amount, decimal rate, decimal commissionPercent)
    {
        if (rate <= 0 || commissionPercent < 0) throw new ArgumentOutOfRangeException(nameof(rate));
        return amount * rate * (1 - commissionPercent / 100);
    }
}

public class DateFormatter
{
    public static string FormatDate(DateTime date) => date.ToString("d", CultureInfo.InvariantCulture);
    public static string FormatDate(string date) => DateTime.Parse(date, CultureInfo.InvariantCulture).ToString("d", CultureInfo.InvariantCulture);
    public static string FormatDate(DateTime date, DateTime time) => date.Date.Add(time.TimeOfDay).ToString("g", CultureInfo.InvariantCulture);
}

public class Notifications
{
    public static void SendNotification(string message) => Console.WriteLine(message);
    public static void SendNotification(string title, string message) => Console.WriteLine($"{title}: {message}");
    public static void SendNotification(string title, string message, string recipient) => Console.WriteLine($"Для {recipient}: {title}: {message}");
}

public class Employee
{
    public string Name { get; }
    public string Position { get; }
    public decimal Salary { get; }
    public Employee(string name, string position, decimal salary) { Name = name; Position = position; Salary = salary; }
    public override string ToString() => $"{Name}, {Position}, {Salary:C}";
}
public class EmployeeFactory
{
    public static Employee CreateEmployee(string name) => new(name, "Не указана", 0);
    public static Employee CreateEmployee(string name, string position) => new(name, position, 0);
    public static Employee CreateEmployee(string name, string position, decimal salary)
    {
        if (salary < 0) throw new ArgumentOutOfRangeException(nameof(salary));
        return new Employee(name, position, salary);
    }
}

public class WarehouseStock
{
    public static int UpdateStock(int current, int amount) { if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount)); return checked(current + amount); }
    public static int UpdateStock(int current, int amount, bool decrease)
    {
        if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
        if (!decrease) return checked(current + amount);
        if (amount > current) throw new InvalidOperationException("На складе недостаточно товара.");
        return current - amount;
    }
    public static int UpdateStock(int current, int newAmount, string operation)
    {
        if (operation != "set") throw new ArgumentException("Операция должна быть set.", nameof(operation));
        if (newAmount < 0) throw new ArgumentOutOfRangeException(nameof(newAmount));
        return newAmount;
    }
}

public class MathLibrary
{
    public static double Calculate(double a, double b, char operation)
    {
        if (operation == '+') return a + b;
        if (operation == '-') return a - b;
        if (operation == '*') return a * b;
        if (operation == '/') { if (b == 0) throw new DivideByZeroException(); return a / b; }
        throw new ArgumentException("Неизвестная операция.", nameof(operation));
    }
    public static decimal Calculate(decimal a, decimal b, string operation)
    {
        if (operation == "sum") return a + b;
        if (operation == "subtract") return a - b;
        if (operation == "multiply") return a * b;
        if (operation == "divide") { if (b == 0) throw new DivideByZeroException(); return a / b; }
        throw new ArgumentException("Неизвестная операция.", nameof(operation));
    }
}

public class Authorization
{
    public static bool Login(string login, string password) => !string.IsNullOrWhiteSpace(login) && !string.IsNullOrEmpty(password);
    public static bool Login(string email, string password, bool byEmail) => byEmail && email.Contains('@') && !string.IsNullOrEmpty(password);
    public static bool Login(string login, string password, string verificationCode) => Login(login, password) && verificationCode == "123456";
}

public record ImageSize(int Width, int Height);
public class ImageResizer
{
    public static ImageSize ResizeImage(int originalWidth, int originalHeight, int width, int height)
    {
        Validate(originalWidth, originalHeight);
        Validate(width, height);
        return new ImageSize(width, height);
    }
    public static ImageSize ResizeImage(int originalWidth, int originalHeight, double scale)
    {
        Validate(originalWidth, originalHeight);
        if (scale <= 0 || double.IsNaN(scale) || double.IsInfinity(scale)) throw new ArgumentOutOfRangeException(nameof(scale));
        return new ImageSize((int)Math.Round(originalWidth * scale), (int)Math.Round(originalHeight * scale));
    }
    public static ImageSize ResizeImage(int originalWidth, int originalHeight, int maxWidth, int maxHeight, bool keepAspectRatio)
    {
        Validate(originalWidth, originalHeight); Validate(maxWidth, maxHeight);
        if (!keepAspectRatio) return new ImageSize(maxWidth, maxHeight);
        double scale = Math.Min((double)maxWidth / originalWidth, (double)maxHeight / originalHeight);
        return new ImageSize((int)Math.Round(originalWidth * scale), (int)Math.Round(originalHeight * scale));
    }
    private static void Validate(int width, int height)
    {
        if (width <= 0 || height <= 0) throw new ArgumentOutOfRangeException("Размеры должны быть положительными.");
    }
}

public class FuelCalculator
{
    public static decimal CalculateFuelCost(double distance, double consumption) => CalculateFuelCost(distance, consumption, 250m);
    public static decimal CalculateFuelCost(double distance, double consumption, decimal pricePerLiter)
    {
        if (distance < 0 || consumption < 0 || pricePerLiter < 0) throw new ArgumentOutOfRangeException("Параметры не могут быть отрицательными.");
        return (decimal)(distance * consumption / 100) * pricePerLiter;
    }
}

public class ElectronicsStore
{
    public static decimal CalculateFinalPrice(decimal price, decimal discountPercent) => price * (1 - discountPercent / 100);
    public static decimal CalculateFinalPrice(decimal price, decimal discountPercent, decimal taxPercent) => CalculateFinalPrice(price, discountPercent) * (1 + taxPercent / 100);
    public static decimal CalculateFinalPrice(decimal price, decimal discountPercent, decimal taxPercent, decimal delivery) => CalculateFinalPrice(price, discountPercent, taxPercent) + delivery;
}

public class StudentEvaluator
{
    public static string EvaluateStudent(double exam) => Evaluate(exam);
    public static string EvaluateStudent(double exam, double test) => Evaluate((exam + test) / 2);
    public static string EvaluateStudent(double[] exams) { if (exams.Length == 0) throw new ArgumentException("Нет оценок.", nameof(exams)); return Evaluate(exams.Average()); }
    private static string Evaluate(double score)
    {
        if (score >= 90) return "Отлично";
        if (score >= 75) return "Хорошо";
        if (score >= 50) return "Удовлетворительно";
        return "Неудовлетворительно";
    }
}

public class Helper
{
    public double Calculate(double a, double b) => a + b;
    public double Calculate(double a, double b, char operation) => MathLibrary.Calculate(a, b, operation);
    public string Format(double value) => value.ToString("F2", CultureInfo.InvariantCulture);
    public string Format(string value) => value.Trim();
    public string Format(DateTime value) => value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    public int Find(int[] values, int target) => Array.IndexOf(values, target);
    public int Find(string text, string value) => text.IndexOf(value, StringComparison.Ordinal);
    public void Display(int value) => Console.WriteLine($"Целое число: {value}");
    public void Display(double value) => Console.WriteLine($"Вещественное число: {value}");
    public void Display(string value) => Console.WriteLine($"Строка: {value}");
    public void Display(Employee value) => Console.WriteLine($"Сотрудник: {value}");

    public static void Main()
    {
        Helper helper = new();
        Console.WriteLine("1. Автомобиль:"); Car.ShowInfo("Toyota"); Car.ShowInfo("Toyota", 2022); Car.ShowInfo("Toyota", 2022, 12000000m);
        Console.WriteLine($"2. Оценка: {StudentGrading.CalculateGrade(80)}, {StudentGrading.CalculateGrade(80, 90)}, {StudentGrading.CalculateGrade(70, 80, 90)}");
        Console.WriteLine($"3. Скидки: {Discounts.CalculateDiscount(1000m, 10)} и {Discounts.CalculateDiscount(1000m, 100m)}");
        Console.WriteLine($"4. Доставка: {Delivery.CalculateDelivery()}, {Delivery.CalculateDelivery(true)}, {Delivery.CalculateDelivery(3, true)}");
        Console.WriteLine("5. Книга:"); Book.DisplayBook("Война и мир"); Book.DisplayBook("Война и мир", "Лев Толстой"); Book.DisplayBook("Война и мир", "Лев Толстой", 1869);
        Console.WriteLine($"6. Очки: {GameScore.AddScore(100, 20)}, {GameScore.AddScore(100, 20, 5)}, {GameScore.AddScore(100, 20, 2)}");
        FileStorage.SaveFile("sample.txt", "Пример текста"); FileStorage.SaveFile("sample-lines.txt", new[] { "Первая строка", "Вторая строка" }); FileStorage.SaveFile("sample-utf8.txt", "Текст UTF-8", Encoding.UTF8);
        Console.WriteLine($"8. Объёмы: {GeometryVolume.CalculateVolume(3)}, {GeometryVolume.CalculateVolume(2, 3, 4)}, {GeometryVolume.CalculateVolume(2, 5, true):F2}");
        Console.WriteLine($"9. Такси: {Taxi.CalculateFare(5)}, {Taxi.CalculateFare(5, 4)}, {Taxi.CalculateFare(5, "comfort")}");
        Console.WriteLine($"10. Поиск книги: {LibrarySearch.SearchBook("Dune", "Frank Herbert", "Frank")}, {LibrarySearch.SearchBook("Dune", "Frank Herbert", "Dune", "Frank Herbert")}");
        Console.WriteLine($"11. Сортировка: {string.Join(",", ArrayTools.Sort(new[] { 3, 1, 2 }))}; {string.Join(",", ArrayTools.Sort(new[] { 3.2, 1.1 }))}; {string.Join(",", ArrayTools.Sort(new[] { "pear", "apple" }))}");
        Console.WriteLine($"12. Статистика: {Statistics.Analyze(new[] { 2, 4, 6 })}; {Statistics.Analyze(new[] { 1.5, 2.5, 3.5 })}");
        Console.WriteLine($"13. Пароль: {PasswordRules.ValidatePassword("abc123!", 6)}, {PasswordRules.ValidatePassword("abc123!", 6, true)}, {PasswordRules.ValidatePassword("abc123!", 6, true, true)}");
        Console.WriteLine($"14. Валюта: {CurrencyConverter.ConvertCurrency(10)}, {CurrencyConverter.ConvertCurrency(10, 500, 2)}");
        Console.WriteLine($"15. Дата: {DateFormatter.FormatDate(DateTime.Now)}, {DateFormatter.FormatDate("2026-10-29")}, {DateFormatter.FormatDate(DateTime.Today, DateTime.Now)}");
        Notifications.SendNotification("Сообщение"); Notifications.SendNotification("Заголовок", "Текст"); Notifications.SendNotification("Заголовок", "Текст", "user@example.com");
        Console.WriteLine($"17. Сотрудники: {EmployeeFactory.CreateEmployee("Алия")}; {EmployeeFactory.CreateEmployee("Иван", "Разработчик")}; {EmployeeFactory.CreateEmployee("Сара", "Менеджер", 500000)}");
        Console.WriteLine($"18. Склад: {WarehouseStock.UpdateStock(10, 5)}, {WarehouseStock.UpdateStock(10, 3, true)}, {WarehouseStock.UpdateStock(10, 20, "set")}");
        Console.WriteLine($"19. Математика: {MathLibrary.Calculate(10, 5, '+')}, {MathLibrary.Calculate(10m, 5m, "divide")}");
        Console.WriteLine($"20. Вход: {Authorization.Login("user", "pass")}, {Authorization.Login("user@example.com", "pass", true)}, {Authorization.Login("user", "pass", "123456")}");
        Console.WriteLine($"21. Размер: {ImageResizer.ResizeImage(800, 600, 400, 300)}, {ImageResizer.ResizeImage(800, 600, 0.5)}, {ImageResizer.ResizeImage(800, 600, 300, 300, true)}");
        Console.WriteLine($"22. Топливо: {FuelCalculator.CalculateFuelCost(100, 8)}, {FuelCalculator.CalculateFuelCost(100, 8, 270)}");
        Console.WriteLine($"23. Цена: {ElectronicsStore.CalculateFinalPrice(1000, 10)}, {ElectronicsStore.CalculateFinalPrice(1000, 10, 12)}, {ElectronicsStore.CalculateFinalPrice(1000, 10, 12, 50)}");
        Console.WriteLine($"24. Итог: {StudentEvaluator.EvaluateStudent(90)}, {StudentEvaluator.EvaluateStudent(80, 90)}, {StudentEvaluator.EvaluateStudent(new[] { 70.0, 80, 90 })}");
        Console.WriteLine("25. Универсальный помощник:");
        Console.WriteLine(helper.Calculate(2, 3)); Console.WriteLine(helper.Calculate(7, 2, '*'));
        Console.WriteLine(helper.Format(12.345)); Console.WriteLine(helper.Format("  текст  ")); Console.WriteLine(helper.Format(DateTime.Today));
        Console.WriteLine(helper.Find(new[] { 4, 5, 6 }, 5)); Console.WriteLine(helper.Find("универсальный помощник", "помощник"));
        helper.Display(42); helper.Display(3.14); helper.Display("Готово"); helper.Display(EmployeeFactory.CreateEmployee("Алия", "Инженер", 400000));
    }
}


