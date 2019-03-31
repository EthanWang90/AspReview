using System;
using System.Collections.Generic;
using System.Text;

namespace delegatePrac
{
    class Student
    {
        private string name;
        private int score;
        public Student(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public static bool scoreSort(Student a, Student b)
        {
            if(a.score < b.score)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
