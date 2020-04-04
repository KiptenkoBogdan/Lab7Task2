using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task2_3
{
    public class SortByAge: IComparer
    {
        public int Compare(Object o1, Object o2)
        {
            Person p1 = (Person)o1;
            Person p2 = (Person)o2;
            return p1.GetAge.CompareTo(p2.GetAge);
        }
    }
}
