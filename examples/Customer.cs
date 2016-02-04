using System;

namespace examples
{
    public class Customer
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }

        public Customer(String firstName, String lastName, String address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }

    }
}
