using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Project_Classes_Dewi
{
    class Cone : IceCream
    {
        //Properties
        public bool Dipped { get; set; }

        //Constructor
        public Cone() : base() { }

        public Cone(string option, int scoops, List<Flavour> flavours, List<Topping> toppings, bool dipped)
            : base(option, scoops, flavours, toppings)
        {
            Dipped = dipped;
        }

        //CalculatePrice for Cone
        public override double CalculatePrice()
        {
            double basePrice = base.CalculatePrice();

            if (Dipped)
            {
                basePrice += 2.00; //Extra $2 for choc dip cone
            }
            return basePrice;
        }

        //ToString
        public override string ToString()
        {
            return $"Cone - Dipped: {Dipped} - {base.ToString()}";
        }
    }
}
