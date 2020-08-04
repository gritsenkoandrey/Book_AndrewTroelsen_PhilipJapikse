using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Collections
{
    public class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x?.PersonAge > y?.PersonAge)
            {
                return 1;
            }

            if (x?.PersonAge < y?.PersonAge)
            {
                return -1;
            }

            return 0;
        }
    }
}
