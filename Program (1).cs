
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpitvane_Listove
{
    class Program
    {
        static void Main(string[] args)
        { //1
           /* List<string> str = Console.ReadLine().Split().ToList();
            string word = Console.ReadLine();
            if (str.Contains(word))
            {
               int ind= str.IndexOf(word);
                str.RemoveAt(ind);                
            }
            str[0].ToUpper();
           Console.WriteLine(string.Join(" ", str));*/
            //2
            int n = int.Parse(Console.ReadLine());
            List<string> str = new List<string>();
            for (int i = 0; i < n; i++)
            {
               str = Console.ReadLine().Split().ToList();
            }            
            string []line = Console.ReadLine().Split();
            string command = line[0];
            List<string> neww = new List<string>(str);
            while (command!="End")
           {              
                
                 if (command == "Add")
                 {
                      string name = Console.ReadLine();
                      int ind = int.Parse(Console.ReadLine());
                        neww.Insert(ind,name);
                 }
                 else if (command == "Shift")
                 {
                       string ind = Console.ReadLine();                      
                       neww.Add(Reverserr(str.IndexOf(ind)));                        
                 }                   
                     
              }            
            Console.WriteLine(string.Join(", ",neww));            
        }
        static string Reverserr(int s)
        {
            string result="";
            while (s!=0)
            {
                result += s % 10;
                s /= 10;
            }
            return result;
        }
        
    }
}
