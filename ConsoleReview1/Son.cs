using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleReview1
{
    class Son:Parent
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("这是子类虚方法重新");
        }
    }
}
