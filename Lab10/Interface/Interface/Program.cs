using interfaces;
using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив:");
            Extramural e1 = new Extramural( 92, "Физкультура");
            Extramural e2 = new Extramural( 75, "Английский");
            Student s1 = new Student( 120);
            Student s2 = new Student( 90);
            Student s3 = new Student( 100);
            Person [] mas = { e1, e2, s1, s2, s3 };
            foreach (Person p in mas)
            {
                Console.WriteLine();
                p.Print();
            }

            Console.WriteLine(s2.Equals(s3)); //сравнение
            //новый массив с группировкой по поведению
            Student st1 = new Student();
            Student st2 = new Student();
            IRandomCreate[] mas1 = { e1, e2, s1, s2, s3, st1, st2 };
            for (int j = 0; j < mas1.Length; j++)
            {
                mas1[j] = mas1[j].RandomCreate();
            }
            Console.WriteLine("\nЕщё один массив:");
            foreach (var c in mas1)
            {
                Console.WriteLine();
                c.Print();
            }
            //генерация рандомных персон
            Random rnd = new Random();
            bool ok;
            int size;
            do
            {
                Console.WriteLine("\nВведите количество элементов в массиве");
                ok = int.TryParse(Console.ReadLine(), out size);
                if (!ok) Console.WriteLine("Введено не целое число");
                else if (size <= 0)
                {
                    Console.WriteLine("Ошибка. Введите положительное число");
                    ok = false;
                }
            } while (!ok);
            Person [] mas2 = new Person[size];
            for (int i = 0; i < mas2.Length; i++)
            {
                int k = rnd.Next(1, 5);
                //if (k == 0)
                  //  mas2[i] = new Person();
                //else
                    if (k % 2 == 0) mas2[i] = new Extramural();
                else mas2[i] = new Student();
                mas2[i] = (Person)mas2[i].RandomCreate();
            }
            Console.WriteLine("Новый массив:");
            foreach (var c in mas2)
            {
                c.Print();
            }

            Console.WriteLine("\nСортировка по коэффициенту интеллекта");
             Array.Sort(mas2, new IQSort());
            
            foreach (Person c in mas2)
                c.Print();

            //масссив школьников
            Console.WriteLine("\nВсе школьники:");
            Pupil[] emas = new Pupil[size];
            for (int e = 0; e < emas.Length; e++)
            {
                emas[e] = new Pupil();
                emas[e] = (Pupil)emas[e].RandomCreate();
            }
            foreach (var p in emas)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nСортировка по имени:");
            Array.Sort(emas);
            foreach (Pupil t in emas)
                Console.WriteLine(t);
            //поиск
            Console.WriteLine("\nПоиск");
            Console.WriteLine("Введите имя ученика:");
            string find = Console.ReadLine();
            int nom = Array.BinarySearch(emas, new Pupil(0, find, 0));
            if (nom < 0) Console.WriteLine("Такой персоны нет");
            else Console.WriteLine($"pos={nom + 1}");
            //клонирование
            Console.WriteLine("\nКлонирование:");
            Pupil clone = (Pupil)emas[0].Clone();
            Console.WriteLine(clone);
            clone.Name = "clone " + clone.Name;
            clone.id.number = 100;
            Console.WriteLine($"Клон: {clone}");
            Console.WriteLine($"Объект: {emas[0]}");

            //копированиие
            Console.WriteLine("\nПоверхностное копирование");
            if (size > 1) { Pupil copy = (Pupil)emas[1].ShallowCopy();
                Console.WriteLine(copy);
                copy.Name = "copy " + copy.Name;
                copy.id.number = 200;
                Console.WriteLine($"Копия: {copy}");
                Console.WriteLine($"Объект: {emas[1]}");
            }
            else
            { Pupil copy = (Pupil)emas[0].ShallowCopy(); 
           
                Console.WriteLine(copy);
                copy.Name = "copy " + copy.Name;
                copy.id.number = 200;
                Console.WriteLine($"Копия: {copy}");
                Console.WriteLine($"Объект: {emas[0]}");
            }
    }
    }
}
