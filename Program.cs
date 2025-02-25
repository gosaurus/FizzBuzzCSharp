namespace FizzBuzz
{
    class Program 
    {
        static void Main(string[] args)
            {
                for(int counter = 1; counter <= 255; counter++)
                {
                    List<string> outputArray = [];
                    int[] divisors = {3, 5, 7, 11, 13, 17};

                    foreach (int divisor in divisors)
                    {
                        if (counter % divisor == 0)
                        {
                            outputArray = populateArray(outputArray, divisor);
                        }
                    }
                    if (outputArray.Contains("Bong"))
                    {
                        Console.WriteLine($"{counter} Bong ");
                    }
                    else if (IsNotNullArray(outputArray)) 
                    {
                        Console.WriteLine($"{counter} {String.Join("", outputArray)} ");
                    }
                    else 
                    {
                        Console.WriteLine($"{counter} ");
                    }
                }
            }
        
        public static bool IsNotNullArray(List<string> outputArray)
        {
            foreach (var element in outputArray)
            {
                if (element != null)
                    return true;
            }
            return false;
        }
        
        public static List<string> populateArray(List<string> outputArray, int divisor)
        {
            if (divisor == 11)
            {
                outputArray.Add("Bong");
            }
            if (divisor == 3)
            {
                outputArray.Add("Fizz");
            }
            if (divisor == 13)
            {
                outputArray.Add("Fezz"); 
            }
            if (divisor == 5)
            {
                outputArray.Add("Buzz");
            }
            if (divisor == 7)
            {
                outputArray.Add("Bang");
            }
            if (divisor == 17)
            {
                outputArray.Reverse();
            }
        return outputArray;
        }
    }
}