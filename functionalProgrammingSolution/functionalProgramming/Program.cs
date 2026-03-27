using System.ComponentModel.DataAnnotations;

namespace functionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Exercise002.GetCoolPeople().ForEach(email => Console.WriteLine(email));
            Console.WriteLine(Exercise001.CheckValidEmail("hello@northcoders.co.uk"));

            Console.WriteLine(Exercise001.SumIndicies("apple", "elephant"));

            List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };

            foreach(string word in words)
            {
                Console.WriteLine(Exercise001.GrammarCheck(word));

            }


        }
    }
}
