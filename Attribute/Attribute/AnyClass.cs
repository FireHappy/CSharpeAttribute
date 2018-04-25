using System;

namespace Attribute
{
    //废弃特性可以使用在类上
    [Obsolete("Don't use anyclass use OtherClass ",false)]
    public class AnyClass
    {
        //C#的预定义特性 Obsolete废弃的
        [Obsolete("Don't use Old method,use New method",false)]
        public static void Old() { }
        public static void New() { }
    }

    [Help("这是一个没有什么用的代码")]
    public class OtherClass
    {
        
    }
}