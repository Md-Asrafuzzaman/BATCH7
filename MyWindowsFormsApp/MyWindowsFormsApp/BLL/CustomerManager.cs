using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MyWindowsFormsApp.Repository;

namespace MyWindowsFormsApp.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool AddCustomerInfo(string name, string address, string contact)
        {
            return _customerRepository.AddCustomerInfo(name,address,contact);
        }
        public bool IsNameExists(string name)
        {
            return _customerRepository.IsNameExists(name);
        }

        public bool UpdateCustomerInfo(int id, string name, string address, string contact)
        {
            return _customerRepository.UpdateCustomerInfo(id,name,address,contact);
        }
        public DataTable Display()
        {
            return _customerRepository.Display();
        }


    }
}
