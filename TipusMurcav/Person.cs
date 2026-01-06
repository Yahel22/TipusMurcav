using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipusMurcav
{
    class Person
    {
        ID person;
        string email;
        string Telephone;
        public Person(ID person, string email, string telephone)
        {
            this.person = person;
            this.email = email;
            Telephone = telephone;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetTelephone()
        {
            return Telephone;
        }
        public void SetTelephone(string telephone)
        {
            Telephone = telephone;
        }

    }

}
