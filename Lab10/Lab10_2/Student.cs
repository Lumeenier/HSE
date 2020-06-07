using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_2
{
    class Student : Person
    {
        //Ben, Mary, Stacy, Root
        //18-24
        public int mark; // 1-10
        public int course; //1-4
        public int scolarship;

        public Student(string name, int age, int mark, int course, int scolarship): base (name, age) 

            {
            this.mark = mark;
            this.course = course;
            this.scolarship = scolarship;
            }

        public override void Print ()
        {
            base.Print();
            Console.WriteLine("Оценка: "+mark);
            Console.WriteLine("Курс: "+course);
            Console.WriteLine("Стипендия: "+scolarship);

        }
    }
       

}
