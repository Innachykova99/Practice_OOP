using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace OOP_PracticeTask
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private decimal bonus;

        public string Name => name;
        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }

        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }

        public decimal ToPay()
        {
            return salary + bonus;
        }

        public class SalesPerson : Employee
        {
            private int percent;

            public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
            {
                this.percent = percent;
            }

            public override void SetBonus(decimal bonus)
            {
                if (percent > 200)
                {
                    this.bonus = bonus * 3;
                }
                else if (percent > 100)
                {
                    this.bonus = bonus * 2;
                }
                else
                {
                    this.bonus = bonus;
                }
            }
        }

        public class Manager : Employee
        {
            private int quantity;

            public Manager(string name, decimal salary, int quantity) : base(name, salary)
            {
                this.quantity = quantity;
            }

            public override void SetBonus(decimal bonus)
            {
                if (quantity > 100)
                {
                    this.bonus = bonus + 500;
                }
                else if (quantity > 150)
                {
                    this.bonus = bonus + 1000;
                }
                else
                {
                    this.bonus = bonus;
                }
            }
        }

        public class Company
        {
            private Employee[] employees;

            public Company(Employee[] Employees)
            {
                this.employees = Employees;
            }

            public void GiveEverybodyBonus(decimal companyBonus)
            {
                foreach (Employee employee in employees)
                {
                    employee.SetBonus(companyBonus);
                }
            }

            public decimal TotalToPay()
            {
                decimal total = 0;
                foreach (Employee employee in employees)
                {
                    total += employee.ToPay();
                }
                return total;
            }
            public (string, decimal) GetNameSalary(Employee employee)
            {
                return (employee.Name, employee.ToPay());
            }
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
    }
}


