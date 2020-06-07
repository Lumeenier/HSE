using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_2
{

    //студант - заочник
    class Extramural : Student
    {
       //Ben, Mary, Stacy, Root
       //18-24
       
        public string direction = "Business"; // Economy, History, Maths, Languages
       

        public Extramural (string name, int age, int mark, int course, int scolarship, string direction): base (name, age, mark, course, scolarship)
        {
            this.direction = direction;
            
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Направление обучения: " +direction);           
        }

    }
}
