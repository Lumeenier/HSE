using Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class Pupil: Person, IRandomCreate, IComparable, ICloneable
    {
        new public static Random rnd = new Random();
        public string Name { get; set; }
        new int IQ;

        public IDNumber id { get; set; }

        public int iQ
        {
            get { return IQ; }
            set
            { if (value >= 0)
                    IQ = value;
                else
                {
                    Console.WriteLine("Ошибка");
                    IQ = 0;
                }

            }
        }

        public Pupil ()
        {
            id = new IDNumber(0);
            Name = "None";
            IQ = 0;

        }

        public Pupil (int idn, string n, int i)
        {
            id = new IDNumber(idn);
            Name = n;
            iQ = i;
        }


        new virtual public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("IQ = " + IQ);
        }
        
        public override Person RandomCreate()
        //new public virtual Pupil RandomCreate()
        {
            Person p = base.RandomCreate();
            string[] Names = { "Лена", "Алена", "Витя", "Даниил", "Олеся", "Ирина", "Вася" };
            Pupil pu = new Pupil(rnd.Next(), Names[rnd.Next(Names.Length)], p.iQ);
            return pu;
        }
        public override string ToString()
        {
            return id + ": " + Name + ", " + iQ;
        }
        public virtual int CompareTo(object obj)
        {
            return String.Compare(this.Name, ((Pupil)obj).Name);
        }
        public object Clone()
        {
            return new Pupil(this.id.number, this.Name, this.IQ);
        }
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

    }
    class IDNumber
    {
        public int number;
        public IDNumber(int n)
        {
            number = n;
        }
        public override string ToString()
        {
            return number.ToString();
        }
    }








}
