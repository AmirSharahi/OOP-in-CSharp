namespace ConsoleApp1
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var var in numbers)
            {
                sum += var;
            }
            return sum;
        }
    }
}