using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.TestData
{
    class Customer
    {
        public Customer()
        {
            SeedRandomData();
        }

        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public string Company;
       
        public void SeedRandomData()
        {
            var faker = new Faker();

            PhoneNumber = faker.Phone.PhoneNumber();
            Email = faker.Internet.Email();
            FirstName = faker.Name.FindName();
            LastName = faker.Name.LastName();
            Company = faker.Company.CompanyName();

            



        }
        


    }
}
