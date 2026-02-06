using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_InputOutput_JSON
{
    public class Snack
    {
        public string snack_name { get; set; }
        public double price { get; set; }
        public double calories { get; set; }
        public double serving_size { get; set; }
        public string spiciness_level { get; set; }

        public Snack()
        {
            snack_name = string.Empty;
            price = 0.0;
            calories = 0.0;
            serving_size = 0.0;
            spiciness_level = string.Empty;
        }

        public override string ToString()
        {
            return $"{spiciness_level} - {snack_name}";
        }

    }
}
