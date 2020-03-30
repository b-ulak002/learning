using Solid.Interface_Segregation_Principle.Example1;
using Solid.SingleResponsibilitPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        public static void Main(string[] args)
        {
            Contact contact = new Contact();
            Emailer emailer = new Emailer();
            emailer.SendMessage(contact, "hello", "hi");

            TestCountries().Wait();
            Console.ReadKey();
        }

        /// <summary>
        /// Testing single responsibility principle
        /// </summary>
        /// <returns></returns>
        private async static Task TestCountries()
        {
            CountriesManager manager = new CountriesManager();
            var countries = await manager.GetCountries();
            foreach(var country in countries)
            {
                Console.WriteLine(CountriesFormatter.FormatForConsole(country));
            }
        }
    }
}
