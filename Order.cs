using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10262519_PRG2Assignment
{
    class Order
    {
        public int Id { get; private set; }
        public DateTime TimeReceived { get; private set; }
        public DateTime? TimeFulfilled { get; set; }
        public List<IceCream> IceCreamList { get; private set; } = new List<IceCream>();

        public Order()
        {
            TimeReceived = DateTime.Now;
        }

        public Order(int id, DateTime timeReceived)
        {
            Id = id;
            TimeReceived = timeReceived;
        }

    }
}
