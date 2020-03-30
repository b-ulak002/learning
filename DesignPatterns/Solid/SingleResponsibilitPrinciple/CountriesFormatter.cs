using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibilitPrinciple
{
    public static class CountriesFormatter
    {
        //Formats into string for console
        public static string FormatForConsole(Country country)
        {
            return $"{country.Name}, Capital: {country.Capital} - Region: {country.Region}";
        }    

        //What about if we need an HTML Formatter


    }
}
