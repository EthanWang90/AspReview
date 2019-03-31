using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleReview1
{
    class Parent
    {
        public void live()
        {
            eat();
            Console.WriteLine("这是父类live方法");
        }
        public virtual void eat()
        {
            Console.WriteLine("这是父类虚方法eat");
        }
    }
}
