using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal class Person : IRandomCreate
    {
        protected static Random rnd = new Random();
        public int IQ { get; set; }
        protected string name = "Персона";

        public virtual void Print ()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("IQ = " + IQ);
        }

        public int iQ
        {
            get { return IQ;  }
            set
            {
                if (value >= 0)
                    IQ = value;
                else
                {
                    Console.WriteLine("Ощибка");
                    IQ = 0;
                }
            }
        }

        public Person ()
        {
            IQ = 0;
        }

        public Person (int i)
        {
            iQ = i;
        }

        public virtual Person RandomCreate()
        {
            int[] iQ = { 150, 50, 88, 120, 200, 166, 70, 115, 96, 98, 69, 123, 52, 197};
            Person a = new Person(iQ[rnd.Next(iQ.Length)]);
            return a;
        }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (p == null) return false;
            return this.iQ == p.iQ ;
        }

        public override string ToString()
        {
            return iQ.ToString();
        }
    }
}
