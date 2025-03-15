using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICustomerService
    {
        // VARNING! Databasentitet! List<Customer> 
        List<Customer> GetCustomers();

    }
}
