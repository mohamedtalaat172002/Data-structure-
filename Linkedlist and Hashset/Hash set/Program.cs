using System;
using System.Collections.Generic;

namespace Hash_set
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<customer>
            {
            new customer { Name = "mohamed", phone = "1323 654 789 159" },
            new customer { Name = "talaat", phone = "323 654 789 159" },
            new customer { Name = "awad", phone = "123 657 789 159" },
            new customer { Name = "ali", phone = "925 654 789 159" },
            new customer { Name = "mo", phone = "1243 654 789 159" },
            new customer { Name = "salah", phone = "1723 654 789 159" },
            };
            Console.WriteLine("----------hash set----------");
            var customer_hash = new HashSet<customer> ( list );
            foreach (var item in customer_hash)
            {
                Console.WriteLine(item);
            }
           
            Console.WriteLine("----------sorted set----------");
            var customerSet = new SortedSet<customer>(list);
            foreach (var item in customerSet)
            {
                Console.WriteLine(item);
            }
        }
    }
    class customer:IComparable<customer>
    {
        public string Name { set; get; }
        public string phone { set; get; }


        public override string ToString()
        {
            return $"the name: {Name} , the phone number:{phone}";
        }
        public override int GetHashCode()
        {
           var hash = 17;
            hash = hash * 317 + phone.GetHashCode();
            return hash;
        }
        public override bool Equals(object obj)
        {
            var customer =  obj as customer;
            if (customer == null)
                return false;
            return this.phone.Equals(customer.phone);
        }

        public int CompareTo(customer other)
        {
            if (object.ReferenceEquals(this, other))
                return 0;
            if (other is null)
                return -1;
            return this.Name.CompareTo(other.Name);
        }
    }
}
