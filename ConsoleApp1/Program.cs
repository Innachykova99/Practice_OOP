using OOP_PracticeTask.Entities;

namespace OOP_PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new SalesPerson("Steve Jobs", 1000, 90),
                new Manager("Bill Gates", 2500, 160),
                new Manager("Anya James", 1400, 147)
            };

            Company company = new Company(employees);
            company.GiveEverybodyBonus(500);

            decimal totalPayment = company.TotalToPay();
            Console.WriteLine($"Total salary to pay: {totalPayment}");

            foreach (Employee employee in employees)
            {
                var (name, payment) = company.GetNameSalary(employee);
                Console.WriteLine($"{name}: {payment}");
            }
        }
    }
}
