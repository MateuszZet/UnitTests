using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Learning
{
    public class Company : BaseClass
    {
        private string countryCode;

       public string CountryCode
      {
          get { return countryCode; }
          set
          {
              Regex r = new Regex(@"[A-Za-z]");
              if(value.Length != 2 || !r.IsMatch(value))
              {
                   throw new ArgumentException(countryCode, "Country code should have 2 letters ONLY!");
                   //throw new Exception("NOT Argument Exception");
              }
               else 
               {
                   countryCode = value.ToUpper();
               }  
          }
      }
      

        public Company(string name, int companyId, string countryCode)
        {
            Name = name;
            Console.WriteLine($"Name:{Name}");
            Id = companyId;
            Console.WriteLine($"Id:{Id}");
            CountryCode = countryCode;
        }

        
    }
}
