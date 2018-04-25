using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            AnyClass.Old();
            AnyClass.New();   
            GetTypeAttributeInfo<Derive>();
            Console.ReadKey();
        }

        static void GetTypeAttributeInfo<T>()
        {        
            Console.WriteLine(typeof(T).GetCustomAttributes(typeof(HelpAttribute),false));           
        }
    }
}
