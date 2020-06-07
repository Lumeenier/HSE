using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_2
{
    class Person
    {
        public string Name;
        public int Age;
               
        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
        //виртуальный метод вывода 
        public virtual void Print ()
        { 
            Console.WriteLine();
        Console.WriteLine("Имя: " + Name);
        Console.WriteLine("Возраст: " + Age);
           
        }
    }
}
