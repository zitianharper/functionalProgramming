using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalProgramming
{
    public class Exercise002
    {
        public List<string> emailList = new List<string>
        { "rich.neat@boardgamer.com",
        "poppy.mcdonnell@irishdancer.com",
        "neil.hughes@walkingoncustard.com",
        "alice.yang@midfielder.com",
        "pippa.austin@musician.com"  };

        foreach (email in List<string> emailList)
            {
                Console.WriteLine(email);
            }

        public static Func<List<string>> GetCoolPeople = () =>

        
    }
}
