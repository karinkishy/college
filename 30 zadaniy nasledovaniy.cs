using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises.Exercise01
{
    public class Animal
    {
        public virtual string Speak() => "Animal sound";
    }

    public class Dog : Animal
    {
        public override string Speak() => "Woof!";
    }

    public class Cat : Animal
    {
        public override string Speak() => "Meow!";
    }
}

namespace Exercises.Exercise02
{
    public class Vehicle
    {
        public string Brand;
        public double Speed;

        public Vehicle(string brand, double speed)
        {
            Brand = brand;
            Speed = speed;
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, double speed, int numberOfDoors) : base(brand, speed)
        {
            NumberOfDoors = numberOfDoors;
        }
    }

    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, double speed, bool hasSidecar) : base(brand, speed)
        {
            HasSidecar = hasSidecar;
        }
    }
}

namespace Exercises.Exercise03
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Student : Person
    {
        public string Specialty { get; set; }
        public int Course { get; set; }

        public Student(string name, int age, string specialty, int course) : base(name, age)
        {
            Specialty = specialty;
            Course = course;
        }

        public override string ToString() =>
            $"{Name}, age {Age}, specialty: {Specialty}, course: {Course}";
    }
}

namespace Exercises.Exercise04
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, decimal salary, int teamSize) : base(name, salary)
        {
            TeamSize = teamSize;
        }
    }

    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, decimal salary, string programmingLanguage)
            : base(name, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }
    }
}

namespace Exercises.Exercise05
{
    public class Shape
    {
        public virtual double GetArea() =>
            throw new NotSupportedException("A generic shape has no defined area.");
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

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
    }
}

namespace Exercises.Exercise06
{
    public class Vehicle
    {
        public virtual string Move() => "The vehicle moves.";
    }

    public class Car : Vehicle
    {
        public override string Move() => "The car drives on the road.";
    }

    public class Bus : Vehicle
    {
        public override string Move() => "The bus carries passengers along its route.";
    }

    public class Train : Vehicle
    {
        public override string Move() => "The train travels on railway tracks.";
    }
}

namespace Exercises.Exercise07
{
    public class Worker
    {
        public string Name { get; set; }
        public string Position { get; protected set; }

        public Worker(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }

    public class Cashier : Worker
    {
        public Cashier(string name) : base(name, "Cashier") { }
    }

    public class Seller : Worker
    {
        public Seller(string name) : base(name, "Seller") { }
    }
}

namespace Exercises.Exercise08
{
    public class Computer
    {
        public string Processor { get; set; }
        public int RAM { get; set; }

        public Computer(string processor, int ram)
        {
            Processor = processor;
            RAM = ram;
        }
    }

    public class Laptop : Computer
    {
        public double BatteryLifeHours { get; set; }

        public Laptop(string processor, int ram, double batteryLifeHours)
            : base(processor, ram)
        {
            BatteryLifeHours = batteryLifeHours;
        }
    }

    public class Desktop : Computer
    {
        public bool HasDedicatedGraphicsCard { get; set; }

        public Desktop(string processor, int ram, bool hasDedicatedGraphicsCard)
            : base(processor, ram)
        {
            HasDedicatedGraphicsCard = hasDedicatedGraphicsCard;
        }
    }
}

namespace Exercises.Exercise09
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    public class PaperBook : Book
    {
        public int PageCount { get; set; }

        public PaperBook(string title, string author, int pageCount) : base(title, author)
        {
            PageCount = pageCount;
        }
    }

    public class EBook : Book
    {
        public double FileSizeMb { get; set; }

        public EBook(string title, string author, double fileSizeMb) : base(title, author)
        {
            FileSizeMb = fileSizeMb;
        }
    }
}

namespace Exercises.Exercise10
{
    public class Pet
    {
        public virtual string Eat() => "The pet eats.";
    }

    public class Dog : Pet
    {
        public override string Eat() => "The dog eats its food quickly.";
    }

    public class Cat : Pet
    {
        public override string Eat() => "The cat eats carefully.";
    }

    public class Parrot : Pet
    {
        public override string Eat() => "The parrot pecks at seeds.";
    }
}

namespace Exercises.Exercise11
{
    public class BankAccount
    {
        public decimal Balance { get; protected set; }

        public BankAccount(decimal openingBalance = 0)
        {
            if (openingBalance < 0)
                throw new ArgumentOutOfRangeException(nameof(openingBalance));
            Balance = openingBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit must be positive.");
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal must be positive.");
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds.");
            Balance -= amount;
        }
    }

    public class SavingsAccount : BankAccount
    {
        public decimal AnnualInterestRate { get; }

        public SavingsAccount(decimal openingBalance, decimal annualInterestRate)
            : base(openingBalance)
        {
            if (annualInterestRate < 0)
                throw new ArgumentOutOfRangeException(nameof(annualInterestRate));
            AnnualInterestRate = annualInterestRate;
        }

        public void ApplyAnnualInterest() => Balance += Balance * AnnualInterestRate;
    }

    public class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; }

        public CreditAccount(decimal openingBalance, decimal creditLimit) : base(openingBalance)
        {
            if (creditLimit < 0)
                throw new ArgumentOutOfRangeException(nameof(creditLimit));
            CreditLimit = creditLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal must be positive.");
            if (Balance - amount < -CreditLimit)
                throw new InvalidOperationException("Credit limit exceeded.");
            Balance -= amount;
        }
    }
}

namespace Exercises.Exercise12
{
    public abstract class Transport
    {
        public abstract decimal CalculateCost(double distanceKm);
    }

    public class Car : Transport
    {
        public override decimal CalculateCost(double distanceKm) => (decimal)distanceKm * 2.5m;
    }

    public class Truck : Transport
    {
        public override decimal CalculateCost(double distanceKm) => (decimal)distanceKm * 5m;
    }

    public class Bus : Transport
    {
        public override decimal CalculateCost(double distanceKm) => (decimal)distanceKm * 1.5m;
    }
}

namespace Exercises.Exercise13
{
    public class Employee
    {
        public decimal BaseSalary { get; set; }

        public Employee(decimal baseSalary)
        {
            BaseSalary = baseSalary;
        }

        public virtual decimal GetSalary() => BaseSalary;
    }

    public class Programmer : Employee
    {
        public int OvertimeHours { get; set; }
        public decimal HourlyRate { get; set; }

        public Programmer(decimal baseSalary, int overtimeHours, decimal hourlyRate)
            : base(baseSalary)
        {
            OvertimeHours = overtimeHours;
            HourlyRate = hourlyRate;
        }

        public override decimal GetSalary() => BaseSalary + OvertimeHours * HourlyRate;
    }

    public class Designer : Employee
    {
        public int CompletedProjects { get; set; }
        public decimal BonusPerProject { get; set; }

        public Designer(decimal baseSalary, int completedProjects, decimal bonusPerProject)
            : base(baseSalary)
        {
            CompletedProjects = completedProjects;
            BonusPerProject = bonusPerProject;
        }

        public override decimal GetSalary() => BaseSalary + CompletedProjects * BonusPerProject;
    }

    public class Manager : Employee
    {
        public decimal TeamRevenue { get; set; }
        public decimal CommissionRate { get; set; }

        public Manager(decimal baseSalary, decimal teamRevenue, decimal commissionRate)
            : base(baseSalary)
        {
            TeamRevenue = teamRevenue;
            CommissionRate = commissionRate;
        }

        public override decimal GetSalary() => BaseSalary + TeamRevenue * CommissionRate;
    }
}

namespace Exercises.Exercise14
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Student : Person
    {
        public string StudentId { get; }
        public string Program { get; }

        public Student(string name, int age, string studentId, string program)
            : base(name, age)
        {
            StudentId = studentId;
            Program = program;
        }
    }

    public class GraduateStudent : Student
    {
        public string ThesisTopic { get; }
        public string Advisor { get; }

        public GraduateStudent(
            string name, int age, string studentId, string program, string thesisTopic, string advisor)
            : base(name, age, studentId, program)
        {
            ThesisTopic = thesisTopic;
            Advisor = advisor;
        }

        public string GetFullInformation() =>
            $"{Name}, age {Age}, student ID {StudentId}, program {Program}, " +
            $"thesis: {ThesisTopic}, advisor: {Advisor}";
    }
}

namespace Exercises.Exercise15
{
    public abstract class MilitaryVehicle
    {
        public abstract string Attack();
    }

    public class Tank : MilitaryVehicle
    {
        public override string Attack() => "Tank fires its main cannon.";
    }

    public class Helicopter : MilitaryVehicle
    {
        public override string Attack() => "Helicopter launches a guided missile.";
    }

    public class ArmoredCar : MilitaryVehicle
    {
        public override string Attack() => "Armored car fires its mounted weapon.";
    }
}

namespace Exercises.Exercise16
{
    public abstract class Character
    {
        public string Name { get; }
        public int Health { get; protected set; }
        public int Damage { get; }

        protected Character(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public abstract int Attack();
    }

    public class Warrior : Character
    {
        public Warrior(string name, int health, int damage) : base(name, health, damage) { }
        public override int Attack() => Damage * 2;
    }

    public class Mage : Character
    {
        public Mage(string name, int health, int damage) : base(name, health, damage) { }
        public override int Attack() => (int)Math.Ceiling(Damage * 1.5);
    }

    public class Archer : Character
    {
        public Archer(string name, int health, int damage) : base(name, health, damage) { }
        public override int Attack() => Damage + 5;
    }
}

namespace Exercises.Exercise17
{
    public class Device
    {
        public bool IsOn { get; private set; }
        public virtual string TurnOn()
        {
            IsOn = true;
            return "Device turned on.";
        }

        public virtual string TurnOff()
        {
            IsOn = false;
            return "Device turned off.";
        }
    }

    public class Phone : Device
    {
        public override string TurnOn() => IsOn ? "Phone is already on." : TurnOnDevice("Phone");
        public override string TurnOff() => IsOn ? TurnOffDevice("Phone") : "Phone is already off.";

        private string TurnOnDevice(string name)
        {
            base.TurnOn();
            return $"{name} turned on.";
        }

        private string TurnOffDevice(string name)
        {
            base.TurnOff();
            return $"{name} turned off.";
        }
    }

    public class Computer : Device { }
    public class Television : Device { }
}

namespace Exercises.Exercise18
{
    public abstract class Payment
    {
        public abstract string Pay(double amount);

        protected static void ValidateAmount(double amount)
        {
            if (double.IsNaN(amount) || double.IsInfinity(amount) || amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Payment amount must be positive.");
        }
    }

    public class CashPayment : Payment
    {
        public override string Pay(double amount)
        {
            ValidateAmount(amount);
            return $"Paid {amount:F2} in cash.";
        }
    }

    public class CardPayment : Payment
    {
        public override string Pay(double amount)
        {
            ValidateAmount(amount);
            return $"Paid {amount:F2} by card.";
        }
    }

    public class OnlinePayment : Payment
    {
        public override string Pay(double amount)
        {
            ValidateAmount(amount);
            return $"Paid {amount:F2} online.";
        }
    }
}

namespace Exercises.Exercise19
{
    public class Employee
    {
        public decimal Salary { get; }
        public decimal BonusPercent { get; }

        public Employee(decimal salary, decimal bonusPercent)
        {
            Salary = salary;
            BonusPercent = bonusPercent;
        }

        public virtual decimal GetBonus() => Salary * BonusPercent / 100m;
        public decimal GetTotalCompensation() => Salary + GetBonus();
    }

    public class Manager : Employee
    {
        public Manager(decimal salary) : base(salary, 20m) { }
    }

    public class Developer : Employee
    {
        public Developer(decimal salary) : base(salary, 10m) { }
    }

    public class SalesManager : Employee
    {
        public SalesManager(decimal salary) : base(salary, 15m) { }
    }
}

namespace Exercises.Exercise20
{
    public class Animal
    {
        public virtual string Eat() => "The animal eats.";
        public virtual string MakeSound() => "The animal makes a sound.";
    }

    public class Lion : Animal
    {
        public override string Eat() => "The lion eats meat.";
        public override string MakeSound() => "Roar!";
    }

    public class Elephant : Animal
    {
        public override string Eat() => "The elephant eats plants.";
        public override string MakeSound() => "Trumpet!";
    }

    public class Monkey : Animal
    {
        public override string Eat() => "The monkey eats fruit.";
        public override string MakeSound() => "Ooh-ooh!";
    }

    public class Parrot : Animal
    {
        public override string Eat() => "The parrot eats seeds.";
        public override string MakeSound() => "Squawk!";
    }

    public class Zebra : Animal
    {
        public override string Eat() => "The zebra eats grass.";
        public override string MakeSound() => "Neigh!";
    }
}

namespace Exercises.Exercise21
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;
        public override double GetArea() => Math.PI * Radius * Radius;
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

    public class Triangle : Shape
    {
        public double BaseLength { get; }
        public double Height { get; }
        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }
        public override double GetArea() => BaseLength * Height / 2;
    }

    public class Square : Shape
    {
        public double Side { get; }
        public Square(double side) => Side = side;
        public override double GetArea() => Side * Side;
    }
}

namespace Exercises.Exercise22
{
    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price));
            Name = name;
            Price = price;
        }

        public virtual decimal CalculateFinalPrice() => Price;
    }

    public class Electronics : Product
    {
        public Electronics(string name, decimal price) : base(name, price) { }
        public override decimal CalculateFinalPrice() => Price * 1.20m;
    }

    public class Clothing : Product
    {
        public Clothing(string name, decimal price) : base(name, price) { }
        public override decimal CalculateFinalPrice() => Price * 0.90m;
    }

    public class Food : Product
    {
        public bool IsNearExpiry { get; }

        public Food(string name, decimal price, bool isNearExpiry) : base(name, price)
        {
            IsNearExpiry = isNearExpiry;
        }

        public override decimal CalculateFinalPrice() => IsNearExpiry ? Price * 0.70m : Price;
    }
}

namespace Exercises.Exercise23
{
    public abstract class Transport
    {
        public abstract string Move();
        public abstract double GetFuelConsumption(double distanceKm);
    }

    public class Car : Transport
    {
        public override string Move() => "Car drives on the road.";
        public override double GetFuelConsumption(double distanceKm) => distanceKm * 8 / 100;
    }

    public class Truck : Transport
    {
        public override string Move() => "Truck transports cargo.";
        public override double GetFuelConsumption(double distanceKm) => distanceKm * 25 / 100;
    }

    public class Bus : Transport
    {
        public override string Move() => "Bus transports passengers.";
        public override double GetFuelConsumption(double distanceKm) => distanceKm * 18 / 100;
    }

    public class Motorcycle : Transport
    {
        public override string Move() => "Motorcycle rides on the road.";
        public override double GetFuelConsumption(double distanceKm) => distanceKm * 4 / 100;
    }
}

namespace Exercises.Exercise24
{
    public abstract class MedicalWorker
    {
        public string Name { get; }
        protected MedicalWorker(string name) => Name = name;
        public abstract string Work();
    }

    public class Doctor : MedicalWorker
    {
        public Doctor(string name) : base(name) { }
        public override string Work() => $"{Name} examines and treats patients.";
    }

    public class Nurse : MedicalWorker
    {
        public Nurse(string name) : base(name) { }
        public override string Work() => $"{Name} provides nursing care.";
    }

    public class Surgeon : MedicalWorker
    {
        public Surgeon(string name) : base(name) { }
        public override string Work() => $"{Name} performs surgery.";
    }
}

namespace Exercises.Exercise25
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string GetInfo() => $"Person: {Name}, age {Age}.";
    }

    public class Employee : Person
    {
        public string EmployeeId { get; }
        public string Department { get; }

        public Employee(string name, int age, string employeeId, string department)
            : base(name, age)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public virtual string DoWork() => $"{Name} works in {Department}.";
    }

    public class Manager : Employee
    {
        public int TeamSize { get; }
        public decimal Budget { get; }

        public Manager(string name, int age, string employeeId, string department, int teamSize, decimal budget)
            : base(name, age, employeeId, department)
        {
            TeamSize = teamSize;
            Budget = budget;
        }

        public string ManageTeam() => $"{Name} manages a team of {TeamSize}.";
    }

    public class Director : Manager
    {
        public string Division { get; }
        public decimal AnnualBudget { get; }

        public Director(
            string name, int age, string employeeId, string department,
            int teamSize, decimal budget, string division, decimal annualBudget)
            : base(name, age, employeeId, department, teamSize, budget)
        {
            Division = division;
            AnnualBudget = annualBudget;
        }

        public string LeadDivision() => $"{Name} leads the {Division} division.";
    }
}

namespace Exercises.Exercise26
{
    public abstract class Character
    {
        public string Name { get; }
        public int Health { get; protected set; }
        public int Damage { get; }

        protected Character(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public abstract int Attack();
        public abstract int Defend();
        public abstract int SpecialAttack();
    }

    public class Warrior : Character
    {
        public Warrior(string name, int health, int damage) : base(name, health, damage) { }
        public override int Attack() => Damage;
        public override int Defend() => 20;
        public override int SpecialAttack() => Damage * 3;
    }

    public class Mage : Character
    {
        public Mage(string name, int health, int damage) : base(name, health, damage) { }
        public override int Attack() => Damage;
        public override int Defend() => 5;
        public override int SpecialAttack() => Damage * 4;
    }

    public class Archer : Character
    {
        public Archer(string name, int health, int damage) : base(name, health, damage) { }
        public override int Attack() => Damage + 3;
        public override int Defend() => 10;
        public override int SpecialAttack() => Damage * 2 + 10;
    }
}

namespace Exercises.Exercise27
{
    public class File
    {
        public string Name { get; }
        public long SizeBytes { get; }

        public File(string name, long sizeBytes)
        {
            if (sizeBytes < 0)
                throw new ArgumentOutOfRangeException(nameof(sizeBytes));
            Name = name;
            SizeBytes = sizeBytes;
        }

        public virtual string Open() => $"Opening file {Name}.";
    }

    public class TextFile : File
    {
        public TextFile(string name, long sizeBytes) : base(name, sizeBytes) { }
        public override string Open() => $"Opening {Name} in a text editor.";
    }

    public class ImageFile : File
    {
        public ImageFile(string name, long sizeBytes) : base(name, sizeBytes) { }
        public override string Open() => $"Displaying image {Name}.";
    }

    public class VideoFile : File
    {
        public VideoFile(string name, long sizeBytes) : base(name, sizeBytes) { }
        public override string Open() => $"Playing video {Name}.";
    }
}

namespace Exercises.Exercise28
{
    public abstract class Employee
    {
        public string Name { get; }
        protected Employee(string name) => Name = name;
        public abstract decimal CalculateSalary();
    }

    public class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; }
        public int HoursWorked { get; }

        public HourlyEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalary() => HourlyRate * HoursWorked;
    }

    public class SalariedEmployee : Employee
    {
        public decimal MonthlySalary { get; }
        public SalariedEmployee(string name, decimal monthlySalary) : base(name) =>
            MonthlySalary = monthlySalary;
        public override decimal CalculateSalary() => MonthlySalary;
    }

    public class CommissionEmployee : Employee
    {
        public decimal Sales { get; }
        public decimal CommissionRate { get; }

        public CommissionEmployee(string name, decimal sales, decimal commissionRate) : base(name)
        {
            Sales = sales;
            CommissionRate = commissionRate;
        }

        public override decimal CalculateSalary() => Sales * CommissionRate;
    }

    public static class Payroll
    {
        public static decimal CalculateTotal(IEnumerable<Employee> employees) =>
            employees.Sum(employee => employee.CalculateSalary());
    }
}

namespace Exercises.Exercise29
{
    public class Animal
    {
        public virtual string MakeSound() => "Unknown animal sound.";
    }

    public class Dog : Animal { public override string MakeSound() => "Woof!"; }
    public class Cat : Animal { public override string MakeSound() => "Meow!"; }
    public class Cow : Animal { public override string MakeSound() => "Moo!"; }
    public class Duck : Animal { public override string MakeSound() => "Quack!"; }
    public class Sheep : Animal { public override string MakeSound() => "Baa!"; }

    public static class SoundDemo
    {
        public static void PlayAll(IEnumerable<Animal> animals)
        {
            foreach (Animal animal in animals)
                Console.WriteLine(animal.MakeSound());
        }
    }
}

namespace Exercises.Exercise30
{
    public abstract class Vehicle
    {
        public string RegistrationNumber { get; }
        public string Brand { get; }
        public string Model { get; }
        public double MaxSpeed { get; }
        public decimal Price { get; }

        protected Vehicle(
            string registrationNumber, string brand, string model, double maxSpeed, decimal price)
        {
            if (maxSpeed < 0)
                throw new ArgumentOutOfRangeException(nameof(maxSpeed));
            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price));
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            Price = price;
        }

        public abstract double CalculateConsumptionPer100Km();
        public abstract string ConsumptionUnit { get; }

        public virtual string GetInfo() =>
            $"{GetType().Name}: {Brand} {Model}, registration {RegistrationNumber}, " +
            $"max speed {MaxSpeed} km/h, price {Price:C}, " +
            $"consumption {CalculateConsumptionPer100Km():F1} {ConsumptionUnit}/100 km";
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; }

        public Car(
            string registrationNumber, string brand, string model, double maxSpeed,
            decimal price, int numberOfDoors)
            : base(registrationNumber, brand, model, maxSpeed, price)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override double CalculateConsumptionPer100Km() => 8.0;
        public override string ConsumptionUnit => "L";
        public override string GetInfo() => $"{base.GetInfo()}, doors {NumberOfDoors}";
    }

    public class Truck : Vehicle
    {
        public double CargoCapacityTons { get; }

        public Truck(
            string registrationNumber, string brand, string model, double maxSpeed,
            decimal price, double cargoCapacityTons)
            : base(registrationNumber, brand, model, maxSpeed, price)
        {
            CargoCapacityTons = cargoCapacityTons;
        }

        public override double CalculateConsumptionPer100Km() => 25.0;
        public override string ConsumptionUnit => "L";
        public override string GetInfo() => $"{base.GetInfo()}, cargo capacity {CargoCapacityTons} t";
    }

    public class Bus : Vehicle
    {
        public int PassengerCapacity { get; }

        public Bus(
            string registrationNumber, string brand, string model, double maxSpeed,
            decimal price, int passengerCapacity)
            : base(registrationNumber, brand, model, maxSpeed, price)
        {
            PassengerCapacity = passengerCapacity;
        }

        public override double CalculateConsumptionPer100Km() => 18.0;
        public override string ConsumptionUnit => "L";
        public override string GetInfo() => $"{base.GetInfo()}, seats {PassengerCapacity}";
    }

    public class ElectricCar : Car
    {
        public double BatteryCapacityKwh { get; }

        public ElectricCar(
            string registrationNumber, string brand, string model, double maxSpeed,
            decimal price, int numberOfDoors, double batteryCapacityKwh)
            : base(registrationNumber, brand, model, maxSpeed, price, numberOfDoors)
        {
            BatteryCapacityKwh = batteryCapacityKwh;
        }

        public override double CalculateConsumptionPer100Km() => 18.0;
        public override string ConsumptionUnit => "kWh";
        public override string GetInfo() =>
            $"{base.GetInfo()}, battery {BatteryCapacityKwh:F1} kWh";
    }

    public class Motorcycle : Vehicle
    {
        public int EngineCapacityCc { get; }

        public Motorcycle(
            string registrationNumber, string brand, string model, double maxSpeed,
            decimal price, int engineCapacityCc)
            : base(registrationNumber, brand, model, maxSpeed, price)
        {
            EngineCapacityCc = engineCapacityCc;
        }

        public override double CalculateConsumptionPer100Km() => 4.0;
        public override string ConsumptionUnit => "L";
        public override string GetInfo() => $"{base.GetInfo()}, engine {EngineCapacityCc} cc";
    }

    public class Fleet
    {
        private readonly List<Vehicle> _vehicles = new List<Vehicle>();
        public IReadOnlyList<Vehicle> Vehicles => _vehicles;

        public void Add(Vehicle vehicle)
        {
            if (vehicle == null)
                throw new ArgumentNullException(nameof(vehicle));
            if (_vehicles.Any(existing =>
                existing.RegistrationNumber == vehicle.RegistrationNumber))
                throw new InvalidOperationException(
                    $"Vehicle {vehicle.RegistrationNumber} is already in the fleet.");
            _vehicles.Add(vehicle);
        }

        public bool Remove(string registrationNumber)
        {
            int index = _vehicles.FindIndex(
                item => item.RegistrationNumber == registrationNumber);
            if (index < 0)
                return false;
            _vehicles.RemoveAt(index);
            return true;
        }

        public void PrintAll()
        {
            foreach (Vehicle vehicle in _vehicles)
                Console.WriteLine(vehicle.GetInfo());
        }

        public Vehicle FindFastest() =>
            _vehicles.OrderByDescending(vehicle => vehicle.MaxSpeed).FirstOrDefault()
            ?? throw new InvalidOperationException("The fleet is empty.");

        public Vehicle FindMostExpensive() =>
            _vehicles.OrderByDescending(vehicle => vehicle.Price).FirstOrDefault()
            ?? throw new InvalidOperationException("The fleet is empty.");
    }
}

namespace Exercises
{
    public static class Program
    {
        public static void Main()
        {
            var student = new Exercise03.Student("Anna", 20, "Computer Science", 2);
            Console.WriteLine(student);

            var graduate = new Exercise14.GraduateStudent(
                "Ivan", 24, "S-104", "Engineering", "Robotics", "Dr. Petrova");
            Console.WriteLine(graduate.GetFullInformation());

            var employees = new List<Exercise28.Employee>
            {
                new Exercise28.HourlyEmployee("Alex", 20m, 160),
                new Exercise28.SalariedEmployee("Maria", 3200m),
                new Exercise28.CommissionEmployee("Oleg", 10000m, 0.08m)
            };
            Console.WriteLine($"Total payroll: {Exercise28.Payroll.CalculateTotal(employees):C}");

            Exercise29.SoundDemo.PlayAll(new List<Exercise29.Animal>
            {
                new Exercise29.Dog(),
                new Exercise29.Cat(),
                new Exercise29.Cow(),
                new Exercise29.Duck(),
                new Exercise29.Sheep()
            });

            var fleet = new Exercise30.Fleet();
            fleet.Add(new Exercise30.Car("CAR-001", "Volvo", "S60", 220, 42000m, 4));
            fleet.Add(new Exercise30.Truck("TRK-001", "MAN", "TGX", 160, 95000m, 18));
            fleet.Add(new Exercise30.Bus("BUS-001", "Mercedes", "Tourismo", 180, 130000m, 50));
            fleet.Add(new Exercise30.ElectricCar(
                "EV-001", "Tesla", "Model 3", 250, 52000m, 4, 75));
            fleet.Add(new Exercise30.Motorcycle(
                "MOT-001", "Honda", "CB500", 180, 7500m, 500));

            fleet.PrintAll();
            Console.WriteLine($"Fastest: {fleet.FindFastest()?.Model ?? "none"}");
            Console.WriteLine($"Most expensive: {fleet.FindMostExpensive()?.Model ?? "none"}");
            fleet.Remove("MOT-001");
        }
    }
}
