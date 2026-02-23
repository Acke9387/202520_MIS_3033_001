using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace WPF_JSON
{
    public class Customer
    {
        public int id { get; set; }
        public string first_name {get;set;}
        public string last_name {get;set;}
        public string email {get;set;}
        public string gender {get;set;}
        public string ip_address {get;set;}
        public string city {get;set;}

        public Customer()
        {
            id = 0;
            first_name = string.Empty;
            last_name = string.Empty;
            email = string.Empty;
            gender = string.Empty;
            ip_address = string.Empty;
            city = string.Empty;
        }
        public Customer(string fName, string lName) :this()
        {
            first_name =fName;
            last_name =lName;
        }

        public override string ToString()
        {
            return $"{first_name}:{last_name}";
        }
    }
}
