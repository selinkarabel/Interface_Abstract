using Interface_Abstract.Abstract;
using Interface_Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
           
            return true;
        }

     
    }
}
