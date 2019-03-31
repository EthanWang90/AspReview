using System;
using System.Collections.Generic;

namespace delegatePrac
{
    class Program
    {



        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>
            {
                new Student("张三", 38),
                new Student("李四", 56),
                new Student("王五", 99),
                new Student("赵四", 5)
            };

            commonSort<Student>(Students, Student.scoreSort);

            foreach(Student temp in Students)
            {
                Console.WriteLine(temp.ToString());
            }
        }

        static void commonSort<T>(List<T> myList, Func<T, T, bool> comparison)
        {
            bool swap = true;
            do
            {
                swap = false;
                for (int i = 0; i < myList.Count-1; i++)
                {
                    if (comparison(myList[i], myList[i + 1]))
                    {
                        T temp = myList[i];
                        myList[i] = myList[i + 1];
                        myList[i + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap);
        }
    }
}
