using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
            IEnumerator enumerator = attributes.GetEnumerator();//获得枚举器
            //枚举的参考信息 https://www.cnblogs.com/2star/p/5538567.html
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            //使用foreach枚举
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
                if (attribute.GetType() == typeof(HelpAttribute))
                {
                    HelpAttribute help = (HelpAttribute)attribute;
                    Console.WriteLine("help.Description:" + help.Description);
                }
            }
        }
    }
}
