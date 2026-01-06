using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TipusMurcav
{
    class ID
    {
        string id;
        string firstName;
        string lastName;
        Date birthDate;
        string countryBorn;
        string Leom;
        string ststus;
        string address;
        string[]KidsID;
        int count;
        public void Addkids(string kidId)
        {
            this.KidsID[count] = kidId;
            count++;
        }
        public string getIdNumber()
        {
            return id;
        }
        public void setIdNumber(string idNumber)
        {
            this.id = idNumber;
        }
        public string getFirstName()
        { return firstName; }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public Date getBirthDate()
        {
            return birthDate;
        }
        public void setBirthDate(Date birthDate)
        {
            this.birthDate = birthDate;
        }
        public string getCountryBorn()
        {
            return countryBorn;
        }
        public void setCountryBorn(string countryBorn)
        {
            this.countryBorn = countryBorn;
        }
        public string getLeom()
        {
            return Leom;
        }

        public void setLeom(string nationality)
        {
            this.Leom = Leom;
        }
        public string getStatus()
        {
            return ststus;
        }
        public void setStatus(string status)
        {
            this.ststus = status;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }

        public ID(string id, string firstName, string lastName, Date birthDate, string countryBorn, string leom, string status, string address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.countryBorn = countryBorn;
            this.Leom = leom;
            this.ststus = status;
            this.address = address;
            this.KidsID = new string[10];
            this.count = 0;
        }










    }
}
