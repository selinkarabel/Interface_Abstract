using Interface_Abstract.Abstract;
using Interface_Abstract.Adapters;
using Interface_Abstract.Concrete;
using Interface_Abstract.Entities;
using System;


namespace Interface_Abstract
{

    //Customer Management System
    partial class Program 
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1985,1,6), FirstName = "Engin", LastName="Demiroğ", NationalityId="28861499108"});
            Console.ReadLine();
        }
    }
}
