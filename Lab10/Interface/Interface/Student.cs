using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Student: Person
    {
        protected static Random rnd = new Random();
        
        public string name;
       

        public Student() : base()
        {
            
        }
        public Student(int i) : base( i)
        {
            name = "Студент";
        }

        public override  void Print ()
        {
            Console.WriteLine(name);
            Console.WriteLine("Коэффициент интеллекта " + IQ);
            
        }

        public override Person RandomCreate()
        {
            Person p = base.RandomCreate();
            
            Student s = new Student(p.iQ);
            return s;

        }

        public override bool Equals (object obj)
        {
            Student s = obj as Student;
            if (s == null) return false;
            return this.iQ == s.iQ;
        }




    }
}
