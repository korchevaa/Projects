using System;

namespace Izpitvane_29._09._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // На първа задача от теста x[2]=23; трябва да има връщане назад :(
            //zad 1
            int n = int.Parse(Console.ReadLine());
            int count = 0; int proiz=1;
            int min = 0;
            while (n!=0)
            {
                int x = n; 
                if (n%5==0)
                {
                    count++;
                }
                n = int.Parse(Console.ReadLine());
                if (n%2!=0)
                {
                    proiz = x * n;
                }        

            }
            Console.WriteLine($"Kratni na 5: {count}");
            Console.WriteLine($"proiz: {proiz}");
            Console.WriteLine($"min: {min}");
            Console.WriteLine("end");

            // zadacha 2
            string name = Console.ReadLine();
            int age= int.Parse(Console.ReadLine());
            string organz= Console.ReadLine();
            Employee emp = new Employee();
            emp.Name = name;
            emp.Age = age;
            emp.Organization = organz;
            Console.WriteLine(emp);
           

        }
    }
}
