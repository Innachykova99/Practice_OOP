using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PracticeTask.Entities
{
    internal class Manager : Employee
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

}
