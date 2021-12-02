using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp__Hometask
{
    class Country
    {
        public string Name { get; set; }
        public string President { get; set; }
        private List<City> Cities { get; set; }
        public int Population
        {
            get
            {
                int result = 0;
                foreach (City item in Cities)
                {
                    result += item.Population;
                }
                return result;
            }

        }

        private static int count = 0;
        public readonly int Id;

        private Country()
        {
            count++;
            Id = count;
        }
        public Country(string name, string president) : this()
        {
            Name = name;
            President = president;
        }
        public override string ToString()
        {
            return $"Country : {Id} - Name : {Name} President : {President} Population : {Population} City Count: {Cities.Count}";
        }
        public override bool Equals(object obj)
        {
            return ((Name == ((Country)obj).Name) && (President== ((Country)obj).President));

        }
        public bool Addcity(City city)
        {
            if (!Cities.Contains(city))
            {
                return false;
            }
            Cities.Add(city);
            return true;
        }
 
        public bool RemoveCity(int Id)
        {
            int len = Cities.Count;
            for (int i = 0; i < len; i++)
            {
                if (Cities[i].Id == Id)
                {
                    Cities.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public void PrintAllCities()
        {
            foreach (City item in Cities)
            {
                Console.WriteLine(item);
            }

        }
        public void SearchAndPrintCities(string query)
        {
            bool resultFound = false;
            foreach (City item in Cities)
            {
                if (item.Name.Contains(query)||item.Major.Contains(query))
                {
                    Console.WriteLine(item);
                    resultFound = true;
                }
            }
            if (!resultFound)
            {
                Console.WriteLine("Not results found.");
            }
        }
    }
}
