namespace OOP_PracticeTask.Entities
{
    internal class Company
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
    }
}
