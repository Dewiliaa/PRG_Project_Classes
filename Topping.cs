using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Project_Classes_Dewi
{
    class Topping
    {
        //Properties
        public string Type { get; set; }

        //Constructors
        public Topping() { }

        public Topping(string type)
        {
            Type = type;
        }

        //ToString Method
        public override string ToString()
        {
            return $"Topping: {Type}";
        }
    }

}
