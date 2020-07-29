using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonImpl
{

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public User() { }

        public User(string name, string phone)
        {
            Name = name;
            PhoneNumber = phone;
        }

        public User(int id, string name, string phoneNumber)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}