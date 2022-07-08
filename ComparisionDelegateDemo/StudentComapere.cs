﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisionDelegateDemo
{
    internal class StudentComapere : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
            {
                return 1;
            }
            else if (x.Marks < y.Marks)
                return -1;
            else 
                return 0;
        }
    }
}
