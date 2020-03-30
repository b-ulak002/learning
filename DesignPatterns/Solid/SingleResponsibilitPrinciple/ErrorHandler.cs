using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibilitPrinciple
{
    public static class ErrorHandler
    {
        public static bool HandleResponse(HttpStatusCode code)
        {
            if (code == HttpStatusCode.OK)
            {
                return true;
            }
            else if (code == HttpStatusCode.NotFound)
            {
                Console.WriteLine("Countries API is momentarily unavailable");
                return false;
            }
            else if (code == HttpStatusCode.InternalServerError)
            {
                Console.WriteLine("Countries API encountered an error, please try again");
                return false;
            }
            else
            {
                Console.WriteLine("An eror has occured while fetching the countries");
                return false;
            }
        }
    }
}
