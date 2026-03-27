using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalProgramming
{
    public class Exercise001
    {
        public static Func<int, int> SquareIt = num => num * num;

        public static Func<int, int> AddOne = num => num + 1;
        
    }
}
