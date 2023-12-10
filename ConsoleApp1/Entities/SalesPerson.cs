using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PracticeTask.Entities
{
    internal class SalesPerson : Employee
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

    }

