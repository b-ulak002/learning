using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.NoSRP
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }


        /// <summary>
        /// How about this method? Does it violate SRP?
        /// </summary>
        /// <returns></returns>
        public string Format()
        {
            return $"{Name}, Capital: {Capital} - Region: {Region}";
        }
    }
}
