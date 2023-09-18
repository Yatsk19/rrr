using System;

// Клас Address
class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо екземпляр класу Address і ініціалізуємо його поля
        Address address = new Address
        {
            Index = "12345",
            Country = "Україна",
            City = "Київ",
            Street = "Вулиця Київська",
            House = "10",
            Apartment = "42"
        };

        // Виводимо на екран значення полів, що описують адресу
        Console.WriteLine("Поштова адреса:");
        Console.WriteLine("Індекс: " + address.Index);
        Console.WriteLine("Країна: " + address.Country);
        Console.WriteLine("Місто: " + address.City);
        Console.WriteLine("Вулиця: " + address.Street);
        Console.WriteLine("Будинок: " + address.House);
        Console.WriteLine("Квартира: " + address.Apartment);

        // Клас Converter
        class Converter
    {
        private double usd;
        private double eur;
        private double pln;

        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }

        public double HryvniaToUsd(double amount)
        {
            return amount / usd;
        }

        public double HryvniaToEur(double amount)
        {
            return amount / eur;
        }

        public double HryvniaToPln(double amount)
        {
            return amount / pln;
        }

        public double UsdToHryvnia(double amount)
        {
            return amount * usd;
        }

        public double EurToHryvnia(double amount)
        {
            return amount * eur;
        }

        public double PlnToHryvnia(double amount)
        {
            return amount * pln;
        }
    }

    // Створюємо екземпляр класу Converter і ініціалізуємо курси валют
    Converter converter = new Converter(28.0, 33.0, 7.5);

    // Проводимо конвертацію з гривні в інші валюти та назад
    double amountHryvnia = 1000;
    Console.WriteLine("\nКонвертація з гривні:");
        Console.WriteLine($"{amountHryvnia} гривень = {converter.HryvniaToUsd(amountHryvnia)} доларів");
        Console.WriteLine($"{amountHryvnia} гривень = {converter.HryvniaToEur(amountHryvnia)} євро");
        Console.WriteLine($"{amountHryvnia} гривень = {converter.HryvniaToPln(amountHryvnia)} злотих");

        double amountUsd = 50;
    double amountEur = 40;
    double amountPln = 200;
    Console.WriteLine("\nКонвертація в гривню:");
        Console.WriteLine($"{amountUsd} доларів = {converter.UsdToHryvnia(amountUsd)} гривень");
        Console.WriteLine($"{amountEur} євро = {converter.EurToHryvnia(amountEur)} гривень");
        Console.WriteLine($"{amountPln} злотих = {converter.PlnToHryvnia(amountPln)} гривень");

        // Клас Employee
        class Employee
    {
        private string lastName;
        private string firstName;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void CalculateSalary(string position, int experience)
        {
            double baseSalary = 0;
            if (position == "Менеджер")
            {
                baseSalary = 5000;
            }
            else if (position == "Розробник")
            {
                baseSalary = 6000;
            }
            else if (position == "Тестувальник")
            {
                baseSalary = 4500;
            }

            double experienceBonus = experience * 100;
            double totalSalary = baseSalary + experienceBonus;
            double tax = totalSalary * 0.18;
            double netSalary = totalSalary - tax;

            // Виводимо на екран інформацію про співробітника
            Console.WriteLine("\nІнформація про співробітника:");
            Console.WriteLine("Прізвище: " + lastName);
            Console.WriteLine("Ім'я: " + firstName);
            Console.WriteLine("Посада: " + position);
            Console.WriteLine("Оклад: " + totalSalary);
            Console.WriteLine("Податковий збір: " + tax);
            Console.WriteLine("Чистий оклад: " + netSalary);
        }
    }

    // Створюємо екземпляр класу Employee і розраховуємо оклад та податковий збір
    Employee employee = new Employee("Петров", "Іван");
    string employeePosition = "Розробник";
    int employeeExperience = 5;
    employee.CalculateSalary(employeePosition, employeeExperience);

        // Клас User
        class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; }

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegistrationDate = DateTime.Now;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine("\nІнформація про користувача:");
            Console.WriteLine("Логін: " + Login);
            Console.WriteLine

