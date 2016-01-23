using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrigin.Core.Repository
{
    public class CustomerRepository
    {
        private static ObservableCollection<Customer> customerEntries = new ObservableCollection<Customer>();

        //CRUD

            //create
         
        public static void Add(Customer customer)
        {
            customerEntries.Add(customer);
        }

            //READ

        public static Customer GetById(int id)
        {
            return customerEntries.FirstOrDefault(c => c.Id == id);
        }

        public static ObservableCollection<Customer> GetAll()
        {
            return customerEntries;
        }

        public static int Count()
        {
            return customerEntries.Count;
        }

            //UPDATE

            //DELETE

        public static void Delete(Customer customer)
        {
            customerEntries.Remove(customer);
        }


        // SAVING JSON
    }
}
