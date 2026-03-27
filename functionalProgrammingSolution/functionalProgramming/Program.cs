namespace functionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };

            foreach(string word in words)
            {
                Console.WriteLine(Exercise001.GrammarCheck(word));

            }


        }
    }
}
