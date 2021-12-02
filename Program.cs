using System;
using System.Collections.Generic;

namespace ConsoleApp__Hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countryContex = new List<Country>();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Menu: Add Country - 1 | Add City - 2 | Look Cities - 3 | Find City - 4 | Remove Country - 5 | Remove City - 6 | Exit");
                Console.ResetColor();
                
                string userResponse =  Console.ReadLine();

              if (userResponse.ToLower() == "Exit") 
              {
                    break;
              }
                int selection;
                bool selectionIsValid = int.TryParse(userResponse,out selection);

                if (selectionIsValid && selection>=1 && selection<=6)
                {
                    switch (selection)
                    {
                        case (int)AppMenuSelection.AddCountry:
                            Console.Write("Enter Country Name:");
                            string ctName = Console.ReadLine();
                            if (string.IsNullOrEmpty(ctName))
                            {
                                Console.WriteLine("Country name is Invalid.");
                                break;
                            }
                            Console.Write("Enter Country President :");
                            string ctPresident = Console.ReadLine();

                            if (string.IsNullOrEmpty(ctPresident))
                            {
                                Console.WriteLine("President name is Invalid."); 
                                break;
                            }    
                           
                            
                            Country newCountry = new Country(ctName,ctPresident);

                            if (countryContex.Contains(newCountry))
                            {
                                 Console.WriteLine("Country already exsists");
                                break;

                            }

                            countryContex.Add(newCountry);
                            Console.WriteLine("Country added successfully");
                            
                            break;
                        
                        case (int)AppMenuSelection.AddCity :
                            if (countryContex.Count<=0)
                            {
                                Console.WriteLine("Add a country name first : ");
                                break;
                                Console.Write("Enter City Name:");
                                string cityName = Console.ReadLine();
                                if (string.IsNullOrEmpty(cityName))
                                {
                                    Console.WriteLine("Country name is Invalid.");
                                    break;
                                }
                                Console.Write("Enter Major name :");
                                string cityMajor = Console.ReadLine();

                                if (string.IsNullOrEmpty(cityMajor))
                                {
                                    Console.WriteLine("President name is Invalid.");
                                    break;
                                }
                                Console.Write("Enter population : ");
                                int cityPopulation;
                                bool cityPopulationInvalid = int.TryParse(Console.ReadLine(), out cityPopulation);
                                if (cityPopulationInvalid)
                                {
                                    Console.WriteLine("Population invalid.");
                                    break;
                                }

                                foreach (Country item in countryContex)
                                {
                                    Console.WriteLine("Enter the Id of Country that you want to add the City to : ");
                                }
                            }
                            break;
                        case (int)AppMenuSelection.FindCity:
                            break;
                        case (int)AppMenuSelection.RemoveCity:
                            break;
                        case (int)AppMenuSelection.RemoveCountry:
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid Selection.");
                }
            }
            
        }
    }
}
