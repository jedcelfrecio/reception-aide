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

    }

}
