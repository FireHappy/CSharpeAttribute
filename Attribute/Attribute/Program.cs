using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
            //取得自定义特性
            IEnumerable<System.Attribute> attributes= typeof(T).GetCustomAttributes();
            var enumerable = attributes as System.Attribute[] ?? attributes.ToArray();
            //while (enumerable.GetEnumerator().MoveNext())
            //{
            //    Console.WriteLine(enumerable.GetEnumerator().MoveNext());  
            //    Console.WriteLine(enumerable.GetEnumerator().Current);
            //}
            //遍历特性
            foreach (var attribute in enumerable)
            {
                Console.WriteLine(attribute);
                if (attribute.GetType() == typeof(HelpAttribute))
                {
                    HelpAttribute help = (HelpAttribute) attribute;
                    Console.WriteLine("help.Description:" + help.Description);
                }
            }
        }
    }
}
