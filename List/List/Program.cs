using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var egypt = new country { IsoCode = "egy", Country = "Egypt" };
            var jordan = new country { IsoCode = "jor", Country = "jordan" };
            var iraq = new country { IsoCode = "irq", Country = "iraq" };
            var usa = new country { IsoCode = "usa", Country = "United States of America" };
            var germany = new country { IsoCode = "deu", Country = "Germany" };
            var japan = new country { IsoCode = "jpn", Country = "Japan" };
            var india = new country { IsoCode = "ind", Country = "India" };
            var canada = new country { IsoCode = "can", Country = "Canada" };
            var australia = new country { IsoCode = "aus", Country = "Australia" };
            country[] countreisarr ={
                egypt,
                  jordan,
                  iraq,
                  usa,
                  germany,
                  japan,
                  india,
                  canada,
                  australia,
            };

            //creating list
            //1
            List<country> countriesList = new List<country>();
            //2- creating alist with putthing the capacity -capacity here is 3-
            List<country> countriesListwithcapacity = new List<country>(3);
            //3- creating alist with items -items here is the array
            List<country> countriesListwithitems = new List<country>(countreisarr);

            //adding to the list

            //1-adding  item to the list بيضيف في الاخر
            countriesList.Add(new country { Country = "Brazil", IsoCode = "BRZ" }); //o(1)
            // 2-adding array to the listبيضيف في الاخر 
            countriesList.AddRange(countreisarr); //o(1)
            // 3-add item in spesific position 
            // here adding in index 1 العنضر الثانى
            countriesList.Insert(1, new country { Country = "france", IsoCode = "fra" });// O(n)

            // removing
            //1-remove at specific condition  
            countriesList.RemoveAt(2);
            //2- remove item with condition
            countriesList.RemoveAll(x => x.Country.StartsWith("k"));
            Console.WriteLine("-------list of countries with iso code----------");
            print(countriesList);
            
            
                        Console.ReadKey();
        }
        static void print(List<country> countriesList)
        {
            foreach (var item in countriesList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------about list------");
            //properties of list
            Console.WriteLine("actual length the list :" + countriesList.Count);//actual length of the list
            Console.WriteLine("the capacity of the list :" +countriesList.Capacity);//how much can the list store
            //if u try to add item to list and capacity is full it will extend  
        }

    }
    class country
    {
        public string IsoCode { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"{Country} ({IsoCode})";
        }
    }
}



