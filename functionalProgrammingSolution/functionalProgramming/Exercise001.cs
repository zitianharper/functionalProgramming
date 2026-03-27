using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalProgramming
{
    public class Exercise001
    {

      
       


        public static Func<string, string, int> SumIndicies = (word1, word2)
            => word1.IndexOf("a") + word2.IndexOf("e");
                
        
        public static Func<string, bool> GrammarCheck = toCheck => toCheck.StartsWith("A") && toCheck.EndsWith("!") ;

        public static Func<int, int> AddTen = int1 => int1 + 10;

        public static Func<int, int> SquareIt = num => num * num;

        public static Func<int, int> AddOne = num => num + 1;

    }
}
