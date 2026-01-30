using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_First_Application
{
    public class Toy
    {
        public string Manufactrer { get; set; }
        public string Name { get; set; }

        private string Aisle { get; set; }
        public double Price { get; set; }   
        public List<string> Tags { get; set; }

        public Toy()
        {
            Manufactrer = "";
            Price = 0.0;
            Name = string.Empty;
            Aisle = "";
            Tags = new List<string>();
        }


    }
}
