using System;

namespace Lab10_2
{

    //Ben, Mary, Stacy, James
    // Economy, History, Maths, Business
    class Program
    {
        static void Main(string[] args)
        {
            Pupil P1 = new Pupil("Ben", 9, 4, 2);
            Pupil P2 = new Pupil("Mary", 11, 5, 4);
            Pupil P3 = new Pupil("Stacy", 18, 5, 11);
            Pupil P4 = new Pupil("Dan", 14, 3, 7);
            Student S1 = new Student("Rome", 18, 9 , 1 , 5000);
            Student S2 = new Student("Lilly",18, 5, 1, 2000);
            Student S3 = new Student("Aron", 20, 4, 3, 3000);
            Student S4 = new Student("Jess",20, 10, 3, 10000);
            Extramural E1 = new Extramural("Henry", 21, 8, 3, 3000, "History");
            Extramural E2 = new Extramural("Liam", 20, 9, 2, 4000,  "Maths");
            Extramural E3 = new Extramural("Louis", 19, 4, 2, 1000,  "Economy");
            Extramural E4 = new Extramural("Harry", 22, 6, 4, 6000, "Business");

            Console.WriteLine("All: ");
            Console.WriteLine();
            Person[] kinds = { P1, P2, P3, P4, S1, S2, S3, S4, E1, E2, E3, E4 };

            foreach (Person persons in kinds)
            {
                persons.Print();
                
            }

            int a = 0;
            foreach (Person p in kinds)
            {
                if (p is Pupil )
                {
                    Pupil p1 = p as Pupil;
                    if (p1 != null && p1.level > 4)
                    {
                        a++;
                    }
                }
            }
            Console.WriteLine($"Количество старшеклассников в школе = {a}");
            Console.WriteLine();

            int b = 0;
            foreach (Person p in kinds)
            {
                if (p is Student)
                {
                    Student s1 = p as Student;
                    if (s1 != null && s1.course == 1)
                    {
                        b++;
                    }
                }
            }
            Console.WriteLine($"Количество первокурсников = {b}");
            Console.WriteLine();
           
            int c = 0;
            foreach (Person p in kinds)
            {
                if (p is Extramural)
                {
                    Extramural e1 = p as Extramural;
                    if (e1 != null && e1.direction == "Business")
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine($"Количество студентов на направлении Business = {c}");
            Console.WriteLine();
        }
    }
}
