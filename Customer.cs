using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10262519_PRG2Assignment
{
    class Customer
    {
        public string Name { get; private set; }
        public int MemberId { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public Order CurrentOrder { get; private set; }
        public List<Order> OrderHistory { get; private set; } = new List<Order>();
        public PointCard Rewards { get; private set; }

        public Customer()
        {
         
        }

        public Customer(string name, int memberId, DateTime dateOfBirth)
        {
            Name = name;
            MemberId = memberId;
            DateOfBirth = dateOfBirth;
            Rewards = new PointCard(); 
        }

        public Order MakeOrder()
        {
            CurrentOrder = new Order();
            return CurrentOrder;
        }

        public bool IsBirthday()
        {
            return DateOfBirth.Month == DateTime.Today.Month && DateOfBirth.Day == DateTime.Today.Day;
        }
    }

}
