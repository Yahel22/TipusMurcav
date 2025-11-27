using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipusMurcav
{
    internal class Salary
    {
        int month;
        int year;
        double brutto;
        public Salary(int month, int year, double brutto)
        {
            this.month = month;
            this.year = year;
            this.brutto = brutto;
        }
        public int GetMonth()
        {
            return this.month;
        }
        public void SetMonth(int month)
        {
            this.month = month;
        }

        public int GetYear()
        {
            return this.year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }

        public double GetBrutto()
        {
            return this.brutto;
        }
        public void SetBrutto(double brutto)
        {
            this.brutto = brutto;
        }

        public double netto()
        {
           if(this.brutto > 7000)
            {
                return this.brutto * 0.9;
            }
            else
            {
                double mas1 = 7000 * 0.1;
                double mas2 = (this.brutto - 7000) * 0.25;
                return this.brutto - mas1 - mas2;


            }

        }

        public override string ToString()
        {
            return $@"Salary for {this.month}
                     Brutto: {this.brutto},
                     Netto: {this.netto()}";
        }


    }
}
