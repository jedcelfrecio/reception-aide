using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptionAide
{
    public class Address
    {

        private string houseNumber;
        private string streetName;
        private string subdivision;
        private string city;
        private string province;
        private string zipCode;

        public Address()
        {

            this.houseNumber = "";
            this.streetName = "";
            this.subdivision = "";
            this.city = "";
            this.province = "";
            this.zipCode = "";

        }

        public string GetHouseNumber()
        {
            return this.houseNumber;
        }

        public void SetHouseNumber(string houseNumber)
        {
            this.houseNumber = houseNumber;
        }

        public string GetStreetName()
        {
            return this.streetName;
        }

        public void SetStreetName(string streetName)
        {
            this.streetName = streetName;
        }

        public string GetSubdivision()
        {
            return this.subdivision;
        }

        public void SetSubdivision(string subdivision)
        {
            this.subdivision = subdivision;
        }

        public string GetCity()
        {
            return this.city;
        }

        public void SetCity(string city)
        {
            this.city = city;
        }

        public string GetProvince()
        {
            return this.province;
        }

        public void SetProvince(string province)
        {
            this.province = province;
        }

        public string GetZipCode()
        {
            return this.zipCode;
        }

        public void SetZipCode(string zipCode)
        {
            this.zipCode = zipCode;
        }

    }

}
