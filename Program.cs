namespace FizzBuzz
{
    class Program 
    {
        static void Main(string[] args)
            {
                for(int counter = 1; counter <= 195; counter++)
                {
                    string output = "";
                    if (counter % 13 == 0)
                    {
                        output += "Fezz"; 
                    }
                    if (counter % 3 == 0)
                    {
                        output = "Fizz" + output;
                    }
                    if (counter % 5 == 0)
                    {
                        output += "Buzz";
                    }
                    if (counter % 7 == 0)
                    {
                        output += "Bang";
                    }
                    if (counter % 11 == 0)
                    {
                        output = "Bong";
                    }
                    if (counter % 17 == 0)
                    {
                        output = "Need to reverse array";
                    }
                    if (output.Length > 0)
                    {
                        Console.Write($"{output} ");
                    }
                    else 
                    {
                        Console.Write($"{counter} ");
                    }
                }
            }
    }
}
