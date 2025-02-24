namespace FizzBuzz
{
    class Program 
    {
        static void Main(string[] args)
            {
                for(int counter = 1; counter <= 255; counter++)
                {
                    string[] outputArray = new string[5];
                    int[] divisors = {3, 5, 7, 11, 13, 17};

                    foreach (int divisor in divisors)
                    {
                        if (RemainderZero(counter, divisor))
                        {
                            outputArray = CreateArray(outputArray, divisor);
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
        
        public static bool IsNotNullArray(string[] outputArray)
        {
            foreach (var element in outputArray)
            {
                if (element != null)
                    return true;
            }
            return false;
        }
        
        public static bool RemainderZero(int counter, int divisor)
        {
            if (counter % divisor == 0)
            return true;
            else 
            {
                return false;
            }
        }
        public static string[] CreateArray(string[] outputArray, int divisor)
        {
            if (divisor == 11)
            {
                outputArray[0] = "Bong";
                return outputArray;
            }
            if (divisor == 3)
            {
                outputArray[1] = "Fizz";
            }
            if (divisor == 13)
            {
                outputArray[2] = "Fezz"; 
            }
            if (divisor == 5)
            {
                outputArray[3] = "Buzz";
            }
            if (divisor == 7)
            {
                outputArray[4] = "Bang";
            }
            if (divisor == 17)
            {
                Array.Reverse(outputArray);
            }
        return outputArray;
        }
    }
}