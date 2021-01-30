using Interface_Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService 
    {
        public virtual void Save(Customer customer) //virtual means we can override this method
        {
            Console.WriteLine("Saved to DB: " + customer.FirstName);
        }
    }
}
