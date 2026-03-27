using Shouldly;
using functionalProgramming;

namespace functionalPTesting
{
    public class Tests
    {
        
        [Test]
        public void AddOne_ReturnsOneMoreThanInput()
        {
            int input = 3;
            int expected = 4;

            int result = Exercise001.AddOne(input);

            result.ShouldBe(expected);
        }

        [Test]
        public void ReturnSquaredNumber()
        {
            int input = 2;
            int expected = 4;

            int result = Exercise001.SquareIt(input);

            result.ShouldBe(expected);
        }

        [Test]
        public void ReturnAddTen()
        {
            int input = 1;
            int result = Exercise001.AddTen(input);
            result.ShouldBe(11);
        }
    }
}