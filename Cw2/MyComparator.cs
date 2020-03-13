using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
    class MyComparator : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if(x.fName == y.fName)
            {
                if(x.lName == y.lName)
                {
                    if(x.index == y.index)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int GetHashCode(Student obj)
        {
            int result = obj.fName.GetHashCode() + obj.lName.GetHashCode() + obj.index.GetHashCode();
            return result;
        }
    }
}
