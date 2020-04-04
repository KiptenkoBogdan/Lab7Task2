using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task2_3
{
    public class Person
    {
        public string sirname, name;
        public int age;
        public double weight;
        public Person()
        { }
        public int GetAge
        {
            get
            {
                return this.age;
            }
        }
        public override string ToString()
        {
            string line = String.Empty;
            line += ("\nName: " + sirname + " " + name);
            line += ("\nAge: " + age);
            line += ("\nWeight: " + weight);
            return line;
        }
    }
}
