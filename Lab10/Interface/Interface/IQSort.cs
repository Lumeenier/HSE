using Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class IQSort : IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            Person p1 = (Person)obj1;
            Person p2 = (Person)obj2;
            if (p1.iQ < p2.iQ) return -1;
            else if (p1.iQ == p2.iQ) return 0;
            else
                return 1;
        }


    }
}
