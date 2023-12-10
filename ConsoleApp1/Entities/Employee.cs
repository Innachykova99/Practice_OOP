using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_PracticeTask.Entities
{
    internal class Employee
    {
        private string name;
        private decimal salary;
        protected decimal bonus;

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
    }
}

