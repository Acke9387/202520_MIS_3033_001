using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Classes_And_Files
{
    internal class Toy
    {

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Image { get; set; }

        private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0.0;
            Image = string.Empty;
            Aisle = string.Empty;
        }

        public string GetAisle()
        {
            string aisle;

            aisle = "" + Manufacturer.ToUpper()[0].ToString();
            aisle += Price.ToString().Replace(".", "").Replace(",", "");
            return aisle;
        }

    }
}
