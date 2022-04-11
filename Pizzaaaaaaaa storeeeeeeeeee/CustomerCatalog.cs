using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;

namespace Pizzaaaaaaaa_storeeeeeeeeee
{
    class CustomerCatalog

    {
        Dictionary<int, Customer> customers;

        public CustomerCatalog()
        { 
            customers = new Dictionary<int, Customer>();

        }
        public void CreateCustomer(Customer customer)
        {
            customers.Add(customer.ID, customer);
        }
        public Customer ReadCustomer(int ID)
        {
            return customers[ID];
        }
        public void UpdateCustomer(Customer customers)
        {
            Customer C = ReadCustomer(customers.ID);
            C.ID = customers.ID;
            C.Name = customers.Name;
            C.Telefonnr = customers.Telefonnr;
        }

        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer.ID);
        }

        public void PrintMenu()
        {
            foreach (var c in customers)
            {
                Console.WriteLine($" {c.Value.ID} {c.Value.Name} {c.Value.Telefonnr} ");
            }
        }

        public Customer Search(string name)
        {
            return customers.FirstOrDefault(a => a.Value.Name.Contains(name)).Value;
        }


    }
}
