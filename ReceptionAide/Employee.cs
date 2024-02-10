using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptionAide
{
    public class Employee : Person
    {

        private List<Service> servicesOffered;

        public Employee(string name, Sex sex, DateTime birthDate) : base(name, sex, birthDate)
        {
            this.servicesOffered = new List<Service>();
        }

        public List<Service> GetServicesOffered()
        {
            return this.servicesOffered;
        }

        public void AddService(Service service)
        {
            servicesOffered.Add(service);
        }

        public void RemoveService(Service service)
        {
            servicesOffered.Remove(service);
        }

    }

}
