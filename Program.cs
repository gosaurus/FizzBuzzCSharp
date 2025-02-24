using System;
using System.Text;

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
                        output = SplitString(output);
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
        public static string SplitString(string output)
        {
            int numberOfWords = (output.Length + 1) / 4;
            string[] outputArray = new string[numberOfWords];

            for (var index = 1; index <= output.Length; index++)
            {
                if (index % 4 == 0)
                {
                    string outputSubString = output.Substring(index - 4, 3);
                    outputArray[index-4] = outputSubString;
                    Console.WriteLine("Output so far ",outputArray, "end \n");
                }
            }
            Array.Reverse(outputArray);
            string reversedOutput = JoinArray(outputArray);
            return reversedOutput;
        }

        public static string JoinArray(string[] outputArray)
        {
            string output = string.Join("", outputArray);
            return output;
        }
    }
}
