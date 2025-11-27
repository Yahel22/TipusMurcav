using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipusMurcav
{
    internal class Car
    {
        string id;
        string model;
        int year;
        public Car(string id, string model, int year)
        {
            this.id = id;
            this.model = model;
            this.year = year;
        }
        public string GetId()
        {
            return this.id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetModel()
        {
            return this.model;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }

        public int GetYear()
        {
            return this.year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public override string ToString()
        {
            return $@"Car ID: {this.id},
                      Model: {this.model},
                        Year: {this.year}";

        }

    }
}
