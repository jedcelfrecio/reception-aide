using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptionAide
{
    public class Customer
    {

        private string name;
        private Sex sex;
        private DateTime birthDate;
        private Address address;

        public Customer(string name, Sex sex, DateTime birthDate)
        {

            this.name = name;
            this.sex = sex;
            this.birthDate = birthDate;
            this.address = new Address();

        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public Sex GetSex()
        {
            return this.sex;
        }

        public void SetSex(Sex sex)
        {
            this.sex = sex;
        }

        public DateTime GetBirthDate()
        {
            return this.birthDate;
        }

        public void SetBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        public Address GetAddress()
        {
            return this.address;
        }

    }

}
