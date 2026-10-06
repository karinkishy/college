using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises.Polymorphism.Exercise01
{
    public class Animal
    {
        public virtual string MakeSound() => "Animal sound";
    }

    public class Dog : Animal
    {
        public override string MakeSound() => "Woof!";
    }

    public class Cat : Animal
    {
        public override string MakeSound() => "Meow!";
    }

    public class Cow : Animal
    {
        public override string MakeSound() => "Moo!";
    }
}

namespace Exercises.Polymorphism.Exercise02
{
    public class Vehicle
    {
        public virtual string Move() => "The vehicle moves.";
    }

    public class Car : Vehicle
    {
        public override string Move() => "The car drives on the road.";
    }

    public class Bike : Vehicle
    {
        public override string Move() => "The bike is pedalled along the road.";
    }

    public class Bus : Vehicle
    {
        public override string Move() => "The bus carries passengers along its route.";
    }
}

namespace Exercises.Polymorphism.Exercise03
{
    public class Employee
    {
        public virtual string Work() => "The employee is working.";
    }

    public class Programmer : Employee
    {
        public override string Work() => "The programmer writes code.";
    }

    public class Teacher : Employee
    {
        public override string Work() => "The teacher gives a lesson.";
    }

    public class Doctor : Employee
    {
        public override string Work() => "The doctor treats patients.";
    }
}

namespace Exercises.Polymorphism.Exercise04
{
    public class Shape
    {
        public virtual double GetArea() => 0;
    }

    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius) => Radius = radius;

        public override double GetArea() => Math.PI * Radius * Radius;
    }

    public class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double triangleBase, double height)
        {
            Base = triangleBase;
            Height = height;
        }

        public override double GetArea() => Base * Height / 2;
    }
}

namespace Exercises.Polymorphism.Exercise05
{
    public class BankAccount
    {
        public decimal Balance { get; }

        public BankAccount(decimal balance) => Balance = balance;

        public virtual decimal CalculateInterest() => 0;
    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(decimal balance) : base(balance) { }

        public override decimal CalculateInterest() => Balance * 0.05m;
    }

    public class BusinessAccount : BankAccount
    {
        public BusinessAccount(decimal balance) : base(balance) { }

        public override decimal CalculateInterest() => Balance * 0.02m;
    }
}

namespace Exercises.Polymorphism.Exercise06
{
    public class Player
    {
        public virtual string Attack() => "The player attacks.";
    }

    public class Warrior : Player
    {
        public override string Attack() => "The warrior attacks with a sword.";
    }

    public class Archer : Player
    {
        public override string Attack() => "The archer shoots an arrow.";
    }

    public class Mage : Player
    {
        public override string Attack() => "The mage casts a spell.";
    }
}

namespace Exercises.Polymorphism.Exercise07
{
    public class Device
    {
        public virtual string TurnOn() => "The device is turned on.";
    }

    public class Phone : Device
    {
        public override string TurnOn() => "The phone starts up.";
    }

    public class Computer : Device
    {
        public override string TurnOn() => "The computer boots.";
    }

    public class Television : Device
    {
        public override string TurnOn() => "The television displays a picture.";
    }
}

namespace Exercises.Polymorphism.Exercise08
{
    public class Instrument
    {
        public virtual string Play() => "The instrument is played.";
    }

    public class Guitar : Instrument
    {
        public override string Play() => "The guitar strums.";
    }

    public class Piano : Instrument
    {
        public override string Play() => "The piano plays a melody.";
    }

    public class Drums : Instrument
    {
        public override string Play() => "The drums beat a rhythm.";
    }
}

namespace Exercises.Polymorphism.Exercise09
{
    public class Bird
    {
        public virtual string Fly() => "The bird flies.";
    }

    public class Eagle : Bird
    {
        public override string Fly() => "The eagle soars high.";
    }

    public class Penguin : Bird
    {
        public override string Fly() => "The penguin cannot fly; it swims instead.";
    }

    public class Sparrow : Bird
    {
        public override string Fly() => "The sparrow flutters through the air.";
    }
}

namespace Exercises.Polymorphism.Exercise10
{
    public class Employee
    {
        public decimal BaseSalary { get; }

        public Employee(decimal baseSalary) => BaseSalary = baseSalary;

        public virtual decimal CalculateSalary() => BaseSalary;
    }

    public class Manager : Employee
    {
        public Manager(decimal baseSalary) : base(baseSalary) { }

        public override decimal CalculateSalary() => BaseSalary + 1000m;
    }

    public class Developer : Employee
    {
        public Developer(decimal baseSalary) : base(baseSalary) { }

        public override decimal CalculateSalary() => BaseSalary + 500m;
    }

    public class Intern : Employee
    {
        public Intern(decimal baseSalary) : base(baseSalary) { }

        public override decimal CalculateSalary() => BaseSalary * 0.5m;
    }
}

namespace Exercises.Polymorphism.Exercise11
{
    public class Payment
    {
        public virtual string Pay(decimal amount) => $"Payment of {amount:C} completed.";
    }

    public class CashPayment : Payment
    {
        public override string Pay(decimal amount) => $"Paid {amount:C} in cash.";
    }

    public class CardPayment : Payment
    {
        public override string Pay(decimal amount) => $"Charged {amount:C} to the card.";
    }

    public class CryptoPayment : Payment
    {
        public override string Pay(decimal amount) => $"Paid {amount:C} in cryptocurrency.";
    }
}

namespace Exercises.Polymorphism.Exercise12
{
    public class Notification
    {
        public virtual string Send(string message) => $"Notification sent: {message}";
    }

    public class EmailNotification : Notification
    {
        public override string Send(string message) => $"Email sent: {message}";
    }

    public class SmsNotification : Notification
    {
        public override string Send(string message) => $"SMS sent: {message}";
    }

    public class PushNotification : Notification
    {
        public override string Send(string message) => $"Push notification sent: {message}";
    }
}

namespace Exercises.Polymorphism.Exercise13
{
    public class Delivery
    {
        public double DistanceKm { get; }
        public decimal WeightKg { get; }

        public Delivery(double distanceKm, decimal weightKg)
        {
            DistanceKm = distanceKm;
            WeightKg = weightKg;
        }

        public virtual decimal CalculatePrice() => (decimal)DistanceKm * 2m + WeightKg;
    }

    public class CourierDelivery : Delivery
    {
        public CourierDelivery(double distanceKm, decimal weightKg) : base(distanceKm, weightKg) { }

        public override decimal CalculatePrice() => (decimal)DistanceKm * 3m + WeightKg * 2m;
    }

    public class PostDelivery : Delivery
    {
        public PostDelivery(double distanceKm, decimal weightKg) : base(distanceKm, weightKg) { }

        public override decimal CalculatePrice() => 5m + WeightKg * 1.5m;
    }

    public class ExpressDelivery : Delivery
    {
        public ExpressDelivery(double distanceKm, decimal weightKg) : base(distanceKm, weightKg) { }

        public override decimal CalculatePrice() => (decimal)DistanceKm * 5m + WeightKg * 3m + 10m;
    }
}

namespace Exercises.Polymorphism.Exercise14
{
    public class Discount
    {
        public virtual decimal CalculateDiscount(decimal price) => 0;
    }

    public class StudentDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price) => price * 0.10m;
    }

    public class VipDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price) => price * 0.20m;
    }

    public class SeasonalDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price) => price * 0.15m;
    }
}

namespace Exercises.Polymorphism.Exercise15
{
    public class Robot
    {
        public virtual string PerformTask() => "The robot performs a task.";
    }

    public class CleaningRobot : Robot
    {
        public override string PerformTask() => "The robot cleans the floor.";
    }

    public class SecurityRobot : Robot
    {
        public override string PerformTask() => "The robot patrols the area.";
    }

    public class DeliveryRobot : Robot
    {
        public override string PerformTask() => "The robot delivers a package.";
    }
}

namespace Exercises.Polymorphism.Exercise16
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius) => Radius = radius;

        public override double GetArea() => Math.PI * Radius * Radius;
        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }

    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => 2 * (Width + Height);
    }

    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side) => Side = side;

        public override double GetArea() => Side * Side;
        public override double GetPerimeter() => 4 * Side;
    }

    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0 ||
                sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("The side lengths must form a valid triangle.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetPerimeter() => SideA + SideB + SideC;

        public override double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) *
                (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }
    }
}

namespace Exercises.Polymorphism.Exercise17
{
    public abstract class Transport
    {
        public abstract double GetSpeed();
    }

    public class Car : Transport
    {
        public override double GetSpeed() => 120;
    }

    public class Train : Transport
    {
        public override double GetSpeed() => 250;
    }

    public class Airplane : Transport
    {
        public override double GetSpeed() => 900;
    }

    public class Ship : Transport
    {
        public override double GetSpeed() => 45;
    }

    public static class TransportExample
    {
        public static List<double> GetSpeeds()
        {
            List<Transport> transports = new List<Transport>
            {
                new Car(),
                new Train(),
                new Airplane(),
                new Ship()
            };

            return transports.Select(transport => transport.GetSpeed()).ToList();
        }
    }
}

namespace Exercises.Polymorphism.Exercise18
{
    public abstract class Employee
    {
        public abstract decimal CalculateSalary();
    }

    public class Manager : Employee
    {
        public decimal MonthlyRate { get; }
        public decimal Bonus { get; }

        public Manager(decimal monthlyRate, decimal bonus)
        {
            MonthlyRate = monthlyRate;
            Bonus = bonus;
        }

        public override decimal CalculateSalary() => MonthlyRate + Bonus;
    }

    public class Developer : Employee
    {
        public decimal MonthlyRate { get; }
        public int OvertimeHours { get; }

        public Developer(decimal monthlyRate, int overtimeHours)
        {
            MonthlyRate = monthlyRate;
            OvertimeHours = overtimeHours;
        }

        public override decimal CalculateSalary() => MonthlyRate + OvertimeHours * 25m;
    }

    public class SalesManager : Employee
    {
        public decimal MonthlyRate { get; }
        public decimal Sales { get; }

        public SalesManager(decimal monthlyRate, decimal sales)
        {
            MonthlyRate = monthlyRate;
            Sales = sales;
        }

        public override decimal CalculateSalary() => MonthlyRate + Sales * 0.05m;
    }

    public static class PayrollExample
    {
        public static List<decimal> CalculateAll()
        {
            List<Employee> employees = new List<Employee>
            {
                new Manager(5000m, 1000m),
                new Developer(4500m, 10),
                new SalesManager(3000m, 20000m)
            };

            return employees.Select(employee => employee.CalculateSalary()).ToList();
        }
    }
}

namespace Exercises.Polymorphism.Exercise19
{
    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual decimal GetFinalPrice() => Price;
    }

    public class Electronics : Product
    {
        public Electronics(string name, decimal price) : base(name, price) { }

        public override decimal GetFinalPrice() => Price * 1.10m;
    }

    public class Food : Product
    {
        public Food(string name, decimal price) : base(name, price) { }

        public override decimal GetFinalPrice() => Price * 0.90m;
    }

    public class Clothing : Product
    {
        public Clothing(string name, decimal price) : base(name, price) { }

        public override decimal GetFinalPrice() => Price * 1.05m;
    }
}

namespace Exercises.Polymorphism.Exercise20
{
    public interface IMessageSender
    {
        string SendMessage(string message);
    }

    public class EmailSender : IMessageSender
    {
        public string SendMessage(string message) => $"Email: {message}";
    }

    public class SmsSender : IMessageSender
    {
        public string SendMessage(string message) => $"SMS: {message}";
    }

    public class TelegramSender : IMessageSender
    {
        public string SendMessage(string message) => $"Telegram: {message}";
    }

    public static class MessageExample
    {
        public static List<string> SendToAll(string message)
        {
            List<IMessageSender> senders = new List<IMessageSender>
            {
                new EmailSender(),
                new SmsSender(),
                new TelegramSender()
            };

            return senders.Select(sender => sender.SendMessage(message)).ToList();
        }
    }
}

namespace Exercises.Polymorphism.Exercise21
{
    public interface IPaymentMethod
    {
        string Pay(decimal amount);
        string Refund(decimal amount);
    }

    public class BankCard : IPaymentMethod
    {
        public string Pay(decimal amount) => $"Paid {amount:C} by bank card.";
        public string Refund(decimal amount) => $"Refunded {amount:C} to the bank card.";
    }

    public class PayPal : IPaymentMethod
    {
        public string Pay(decimal amount) => $"Paid {amount:C} with PayPal.";
        public string Refund(decimal amount) => $"Refunded {amount:C} to PayPal.";
    }

    public class CryptoWallet : IPaymentMethod
    {
        public string Pay(decimal amount) => $"Paid {amount:C} from a crypto wallet.";
        public string Refund(decimal amount) => $"Refunded {amount:C} to the crypto wallet.";
    }
}

namespace Exercises.Polymorphism.Exercise22
{
    public abstract class Employee
    {
        public string Name { get; }

        protected Employee(string name) => Name = name;

        public abstract string Work();
        public abstract decimal CalculateSalary();
    }

    public class Developer : Employee
    {
        public Developer(string name) : base(name) { }

        public override string Work() => $"{Name} writes and reviews code.";
        public override decimal CalculateSalary() => 5000m;
    }

    public class Manager : Employee
    {
        public Manager(string name) : base(name) { }

        public override string Work() => $"{Name} coordinates the team.";
        public override decimal CalculateSalary() => 6000m;
    }

    public class Designer : Employee
    {
        public Designer(string name) : base(name) { }

        public override string Work() => $"{Name} designs the user interface.";
        public override decimal CalculateSalary() => 4500m;
    }

    public class Tester : Employee
    {
        public Tester(string name) : base(name) { }

        public override string Work() => $"{Name} tests the application.";
        public override decimal CalculateSalary() => 4000m;
    }

    public static class CompanyExample
    {
        public static List<string> RunWorkday()
        {
            List<Employee> employees = new List<Employee>
            {
                new Developer("Alex"),
                new Manager("Sam"),
                new Designer("Taylor"),
                new Tester("Jordan")
            };

            return employees
                .Select(employee => $"{employee.Work()} Salary: {employee.CalculateSalary():C}")
                .ToList();
        }
    }
}

namespace Exercises.Polymorphism.Exercise23
{
    public abstract class Character
    {
        public abstract string Attack();
    }

    public class Warrior : Character
    {
        public override string Attack() => "The warrior strikes with a sword.";
    }

    public class Mage : Character
    {
        public override string Attack() => "The mage casts a fireball.";
    }

    public class Archer : Character
    {
        public override string Attack() => "The archer shoots an arrow.";
    }

    public class Assassin : Character
    {
        public override string Attack() => "The assassin attacks from the shadows.";
    }

    public static class TeamExample
    {
        public static List<string> AttackWithTeam()
        {
            List<Character> team = new List<Character>
            {
                new Warrior(),
                new Mage(),
                new Archer(),
                new Assassin()
            };

            return team.Select(character => character.Attack()).ToList();
        }
    }
}

namespace Exercises.Polymorphism.Exercise24
{
    public class MedicalWorker
    {
        public virtual string TreatPatient() => "The medical worker treats a patient.";
    }

    public class Doctor : MedicalWorker
    {
        public override string TreatPatient() => "The doctor examines and treats the patient.";
    }

    public class Surgeon : MedicalWorker
    {
        public override string TreatPatient() => "The surgeon performs an operation.";
    }

    public class Nurse : MedicalWorker
    {
        public override string TreatPatient() => "The nurse cares for the patient.";
    }

    public class Dentist : MedicalWorker
    {
        public override string TreatPatient() => "The dentist treats the patient's teeth.";
    }

    public static class HospitalExample
    {
        public static List<string> TreatPatients()
        {
            List<MedicalWorker> workers = new List<MedicalWorker>
            {
                new Doctor(),
                new Surgeon(),
                new Nurse(),
                new Dentist()
            };

            return workers.Select(worker => worker.TreatPatient()).ToList();
        }
    }
}

namespace Exercises.Polymorphism.Exercise25
{
    public abstract class File
    {
        public string Name { get; }

        protected File(string name) => Name = name;

        public abstract string Open();
    }

    public class TextFile : File
    {
        public TextFile(string name) : base(name) { }

        public override string Open() => $"Opening text file {Name} in a text editor.";
    }

    public class ImageFile : File
    {
        public ImageFile(string name) : base(name) { }

        public override string Open() => $"Opening image file {Name} in an image viewer.";
    }

    public class VideoFile : File
    {
        public VideoFile(string name) : base(name) { }

        public override string Open() => $"Playing video file {Name}.";
    }

    public class AudioFile : File
    {
        public AudioFile(string name) : base(name) { }

        public override string Open() => $"Playing audio file {Name}.";
    }
}

namespace Exercises.Polymorphism.Exercise26
{
    public interface IReport
    {
        string Generate();
    }

    public class SalesReport : IReport
    {
        public string Generate() => "Sales report generated.";
    }

    public class FinancialReport : IReport
    {
        public string Generate() => "Financial report generated.";
    }

    public class EmployeeReport : IReport
    {
        public string Generate() => "Employee report generated.";
    }

    public static class ReportExample
    {
        public static List<string> GenerateAll()
        {
            List<IReport> reports = new List<IReport>
            {
                new SalesReport(),
                new FinancialReport(),
                new EmployeeReport()
            };

            return reports.Select(report => report.Generate()).ToList();
        }
    }
}

namespace Exercises.Polymorphism.Exercise27
{
    public abstract class SmartDevice
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    public class SmartLight : SmartDevice
    {
        public override void TurnOn() => Console.WriteLine("Smart light is on.");
        public override void TurnOff() => Console.WriteLine("Smart light is off.");
    }

    public class SmartTV : SmartDevice
    {
        public override void TurnOn() => Console.WriteLine("Smart TV is on.");
        public override void TurnOff() => Console.WriteLine("Smart TV is off.");
    }

    public class SmartThermostat : SmartDevice
    {
        public override void TurnOn() => Console.WriteLine("Thermostat is regulating the temperature.");
        public override void TurnOff() => Console.WriteLine("Thermostat is off.");
    }

    public class SecurityCamera : SmartDevice
    {
        public override void TurnOn() => Console.WriteLine("Security camera is recording.");
        public override void TurnOff() => Console.WriteLine("Security camera is off.");
    }

    public class SmartHomeController
    {
        private readonly List<SmartDevice> devices;

        public SmartHomeController(List<SmartDevice> devices) => this.devices = devices;

        public void TurnAllOn()
        {
            foreach (SmartDevice device in devices)
            {
                device.TurnOn();
            }
        }

        public void TurnAllOff()
        {
            foreach (SmartDevice device in devices)
            {
                device.TurnOff();
            }
        }
    }
}

namespace Exercises.Polymorphism.Exercise28
{
    public abstract class Order
    {
        public decimal ItemsTotal { get; }

        protected Order(decimal itemsTotal) => ItemsTotal = itemsTotal;

        public abstract decimal CalculateTotal();
    }

    public class FoodOrder : Order
    {
        public FoodOrder(decimal itemsTotal) : base(itemsTotal) { }

        public override decimal CalculateTotal() => ItemsTotal * 1.05m;
    }

    public class ClothingOrder : Order
    {
        public ClothingOrder(decimal itemsTotal) : base(itemsTotal) { }

        public override decimal CalculateTotal() => ItemsTotal * 1.10m;
    }

    public class ElectronicsOrder : Order
    {
        public ElectronicsOrder(decimal itemsTotal) : base(itemsTotal) { }

        public override decimal CalculateTotal() => ItemsTotal * 1.20m;
    }
}

namespace Exercises.Polymorphism.Exercise29
{
    public interface IRide
    {
        string StartRide();
        decimal CalculateCost(double distanceKm);
    }

    public class EconomyRide : IRide
    {
        public string StartRide() => "Economy ride started.";
        public decimal CalculateCost(double distanceKm) => (decimal)distanceKm * 1.5m;
    }

    public class ComfortRide : IRide
    {
        public string StartRide() => "Comfort ride started.";
        public decimal CalculateCost(double distanceKm) => (decimal)distanceKm * 2.5m;
    }

    public class BusinessRide : IRide
    {
        public string StartRide() => "Business ride started.";
        public decimal CalculateCost(double distanceKm) => (decimal)distanceKm * 4m + 5m;
    }
}

namespace Exercises.Polymorphism.Exercise30
{
    public interface IDiscount
    {
        decimal Apply(decimal price);
    }

    public class PercentageDiscount : IDiscount
    {
        private readonly decimal percent;

        public PercentageDiscount(decimal percent) => this.percent = percent;

        public decimal Apply(decimal price) => price * (1 - percent / 100m);
    }

    public class FixedDiscount : IDiscount
    {
        private readonly decimal amount;

        public FixedDiscount(decimal amount) => this.amount = amount;

        public decimal Apply(decimal price) => Math.Max(0, price - amount);
    }

    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        private readonly IDiscount discount;

        public Product(string name, decimal price, IDiscount discount)
        {
            Name = name;
            Price = price;
            this.discount = discount;
        }

        public virtual decimal GetFinalPrice() => discount.Apply(Price);

        public override string ToString() => $"{Name}: {GetFinalPrice():C}";
    }

    public class Electronics : Product
    {
        public Electronics(string name, decimal price, IDiscount discount)
            : base(name, price, discount) { }
    }

    public class Food : Product
    {
        public Food(string name, decimal price, IDiscount discount)
            : base(name, price, discount) { }
    }

    public class Clothing : Product
    {
        public Clothing(string name, decimal price, IDiscount discount)
            : base(name, price, discount) { }
    }

    public static class StoreExample
    {
        public static List<string> PrintProductsAndTotal()
        {
            List<Product> products = new List<Product>
            {
                new Electronics("Headphones", 100m, new PercentageDiscount(10m)),
                new Food("Bread", 5m, new FixedDiscount(1m)),
                new Clothing("Jacket", 80m, new PercentageDiscount(15m))
            };

            List<string> result = products.Select(product => product.ToString()).ToList();
            result.Add($"Total: {products.Sum(product => product.GetFinalPrice()):C}");
            return result;
        }
    }
}