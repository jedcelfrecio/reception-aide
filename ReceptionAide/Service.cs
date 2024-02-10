using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReceptionAide
{
    public class Service
    {

        private string name;

        public Service(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public override bool Equals(Object? service)
        {

            Service serviceToCompare = (Service)service;

            bool servicesHaveTheSameName = (this.name.Equals(serviceToCompare.GetName()));

            return servicesHaveTheSameName;

        }

    }

}
