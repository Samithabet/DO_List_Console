using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("enter 1 to add to list");
                Console.WriteLine("enter 2 to remove to list");
                Console.WriteLine("enter 3 to viwe to list");
                string num =Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("enter the task");
                        string task=Console.ReadLine();
                        list.Add(task);
                        break;
                    case "2":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("list is empty!!!");
                        }
                        Console.WriteLine("enter the task to remove");
                        string remove = Console.ReadLine();
                        list.Remove(remove);
                        break;
                    case"3":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("list is empty");
                        }
                        else
                        for (int i = 0; i < list.Count; i++)
                        {
                                Console.WriteLine(list[i]);
                        }
                        break;


                }
            
            
            }
            Console.ReadKey();
        }
    }
}
