using Interface;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace interfaces
{

    internal class Extramural: Student
    {
        new public string name;
        public string exams { get; set; }

        public Extramural() : base()
        {

        }
       
        public string Exams
        {
            get { return exams; }
            set { exams = value; }
        }
        //public Extramural():base ()
        //{
         //   Exams = "None";
        //}

        
        public Extramural(int i, string e) : base(i)
        {
            Exams = e;
            name = "Студент - заочник";

        }
        public override void  Print ()
        {
            Console.WriteLine(name);
            Console.WriteLine("Коэффициент интеллекта " + IQ);
            Console.WriteLine("Экзамен " + exams);
        }

        public override Person RandomCreate()
        {
            Person p = base.RandomCreate();
            string[] Exams = { "Физкультура", "Литература", "Английский", "Русский", "Математика" };
            Extramural e = new Extramural(p.iQ, Exams[rnd.Next(Exams.Length)]);
            return e;
        }
        
        public override bool Equals(object obj)
        {
            Extramural e = obj as Extramural;
            if (e == null) return false;
            return this.iQ == e.iQ;         
            
        }

    }
}
