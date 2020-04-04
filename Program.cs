using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab7Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"people.txt";
            Queue younger = new Queue();
            List<String> temp = new List<String>();
            List<String> less = new List<String>();
            ArrayList people = new ArrayList();

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split();
                    Person p = new Person();

                    p.sirname = words[0];
                    p.name = words[1];
                    try
                    {
                        p.age = int.Parse(words[2]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    try
                    {
                        p.weight = double.Parse(words[3]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    people.Add(p);

                    if (p.age < 40)
                    {
                        younger.Enqueue(line);
                    }
                    else
                    {
                        temp.Add(line);
                    }
                }
            }

            foreach (String item in temp)
                younger.Enqueue(item);

            Console.WriteLine("\t2.)People younger than 40 are first in queue (using Queue)");

            foreach(String item in younger.ToArray())
                Console.WriteLine("{0}", item);

            people.Sort(new SortByAge());

            Console.WriteLine("\n\t3.)People sorted by age (using ArrayList)");

            foreach (object item in people)
                Console.WriteLine(item.ToString());

            Console.ReadKey();
        }
    }
}
