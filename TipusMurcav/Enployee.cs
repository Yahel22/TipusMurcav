using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipusMurcav;

namespace Mahlaka_Murkevet
{
    internal class Employee
    {
        string id;
        string name;
        Salary salary;
        Car car;
        public Employee(string id, string name, Salary salary, Car car)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.car = car;
        }
        public Employee(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.salary = null;
            this.car = null;
        }
        public string GetId()
        {
            return this.id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public Salary GetSalary()
        {
            return this.salary;
        }
        public void SetSalary(Salary salary)
        {
            this.salary = salary;
        }

        public Car GetCar()
        {
            return this.car;
        }
        public void SetCar(Car car)
        {
            this.car = car;
        }
        public override string ToString()
        {
            string str = $@"Employee ID:{this.id},
                        name: {this.name}";
            if (this.salary != null)
            {
                str += $@"
                    {this.salary.ToString()}";
            }
            if (this.car != null)
            {
                str += $@"
                    {this.car.ToString()}";
            }
            return str;
        }
    }
}



