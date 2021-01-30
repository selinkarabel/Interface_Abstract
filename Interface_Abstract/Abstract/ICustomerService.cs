using Interface_Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer); // different companies have this operation and they have to use it
    }
}
