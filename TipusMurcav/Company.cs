using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mahlaka_Murkevet;

namespace TipusMurcav
{
    class Company
    {
        Employee[] employees;
        int count;
        public void AddNewEmployee(Employee employee)
        {
            this.employees[this.count] = employee;
            this.count++;

        }
        public Company(int maxEmployees)
        {
            this.employees = new Employee[maxEmployees];
            this.count = 0;
        }
        public Employee MaxSalary()
        {
            Employee maxEmp = this.employees[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.employees[i].GetSalary().GetBrutto() > maxEmp.GetSalary().GetBrutto())
                {
                    maxEmp = this.employees[i];
                }
            }
            return maxEmp;
        }
        public string OldestModel()
        {
            int year = this.employees[0].GetCar().GetYear();
            string model = this.employees[0].GetCar().GetModel();
            for (int i = 1; i < this.count; i++)
            {
                if (this.employees[i].GetCar().GetYear() < year)
                {
                    year = this.employees[i].GetCar().GetYear();
                    model = this.employees[i].GetCar().GetModel();
                }
            }
            return model;
        }
        public double TotalNettoSalary()
        {
            double total = 0;
            for (int i = 0; i < this.count; i++)
            {
                total += this.employees[i].GetSalary().netto();
            }
            return total;
        }
        public double AverageBruttoSalary()
        {
            double total = 0;
            for (int i = 0; i < this.count; i++)
            {
                total += this.employees[i].GetSalary().GetBrutto();
            }
            return total / this.count;
        }
        public string[] GetNamesWithNewCar()
        {
            string[] names = new string[this.CountNewCar()];
            int year = NewesCarYear();
            int index = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (this.employees[i].GetCar().GetYear() == year)
                {
                    names[index] = this.employees[i].GetName();
                    index++;
                }
            }
            return names;

        }
        private int NewesCarYear()
        {
            int Year = this.employees[0].GetCar().GetYear();
            for (int i = 1; i < this.count; i++)
            {
                if (this.employees[i].GetCar().GetYear() > Year)
                {
                    Year = this.employees[i].GetCar().GetYear();
                }
            }
            return Year;

        }
        private int CountNewCar()
        {
            int year = NewesCarYear();
            int count = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (this.employees[i].GetCar().GetYear() == year)
                {
                    count++;
                }
            }
            return count;
        }
        public bool IfEmployeeExists(string id)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.employees[i].GetId() == id)
                {
                    return true;
                }
            }
            return false;
        }









    }
}
   