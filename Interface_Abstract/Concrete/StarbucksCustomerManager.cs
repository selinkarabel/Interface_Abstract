using Interface_Abstract.Abstract;
using Interface_Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Abstract.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager // 1. usage --> , ICustomerCheckService
    {
        ICustomerCheckService _customerCheckService; // 2nd usage

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService) //dependency injection
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer) // override to check person is real from Mernis
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
           
        }

    }
}
