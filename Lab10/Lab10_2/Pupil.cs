using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_2
{
    class Pupil : Person
    {
         //Ben, Mary, Stacy, Root
       //7-18
        
        public int mark = 5; // 1-5
        public int level = 7; //1-11

        public Pupil (string name, int age, int mark, int level): base (name, age)
        {
            this.mark = mark;
            this.level = level; 
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Оценка: "+ mark);
            Console.WriteLine("Класс: "+ level);
        }
    }
}
