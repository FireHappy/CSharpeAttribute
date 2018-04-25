using System;
using System.Reflection;

namespace Attribute
{
    //开发定制的特性 constom attribute
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = false,Inherited = true)]
    public class HelpAttribute:System.Attribute
    {
        //注意:对一个特性类使用Attribute后缀是一个惯例
        //然而我们把疼添加到一个程序尸体,是否包括Atrribute
        //后缀使我们的自由编译器会首先在System.Attirbute的派生类中
        //查找被添加的特性类,入托没有找到,那么编译器会添加Attribute后缀
        //后继续查找哦 
        //获取某个类的特性需要通过反射实现
        //参考地址:http://www.cnblogs.com/liuxinxin/articles/2265672.html        

        protected string description;

        public String Description => this.description;

        public HelpAttribute(string Description_in)
        {
            this.description = Description_in;
        }
              
    }
}