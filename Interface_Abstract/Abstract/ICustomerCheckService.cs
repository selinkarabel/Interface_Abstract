using Interface_Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
