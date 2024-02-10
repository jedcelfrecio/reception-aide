using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptionAide
{
    public class Schedule
    {

        private DateTime dateAndTime;
        private List<Customer> customersInvolved;
        private List<Service> servicesInvolved;
        private List<Employee> employeesInvolved;

        public Schedule(DateTime dateAndTime)
        {

            this.dateAndTime = dateAndTime;
            this.customersInvolved = new List<Customer>();
            this.servicesInvolved = new List<Service>();
            this.employeesInvolved = new List<Employee>();

        }

        public DateTime GetDateAndTime()
        {
            return this.dateAndTime;
        }

        public void SetDateAndTime(DateTime dateAndTime)
        {
            this.dateAndTime= dateAndTime;
        }

        public List<Customer> GetCustomersInvolved()
        {
            return this.customersInvolved;
        }

        public List<Service> GetServicesInvolved()
        {
            return this.servicesInvolved;
        }

        public List<Employee> GetEmployeesInvolved()
        {
            return this.employeesInvolved;
        }

    }

}
