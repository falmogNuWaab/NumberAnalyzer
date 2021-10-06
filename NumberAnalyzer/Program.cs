using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int oPut;
            bool cbit = false;
            string uName;

            Console.WriteLine("Welcome to the Number Analyzer where we Analyze numbers");
            Console.WriteLine("Let's begin! I will need some info before we get started");
            Console.Write("What is your name? ");
            uName = Console.ReadLine();
            Console.WriteLine($"\nNice to meet you, {uName}");

            while (!cbit)
            {
                bool thatsOdd = false;
                Console.Write($"\n{uName} Enter a number between 1 and 100: ");
                input = Console.ReadLine();
                if (!int.TryParse(input, out oPut)) //check if it's a number
                {
                    Console.WriteLine($"Hey, {uName}, {input} was not a number");
                    Console.WriteLine("Do you want to try again?(y/n)"); //ask if the user would like to try again
                    input = Console.ReadLine();
                    if (input.ToLower().StartsWith("n"))
                    {
                        //If the user enters a word that starts with the letter N we assume they do not want to try again
                        cbit = true;
                        Console.WriteLine($"It was a pleasure working with you today {uName}. Have a nice life.");
                        break;
                    } 
                    else
                    {
                        continue; //for all other responses we assume they do
                    }
                } 
                else
                {
                    //We know it's a number, lets make sure it's within 1-100
                    if(oPut>=100 || oPut <= 1)
                    {
                        Console.WriteLine($"Sorry, {uName}, but {oPut} must be between 1 and 100");
                        Console.WriteLine("Do you want to try again? (y/n)"); //ask if the user would like to try again
                        input = Console.ReadLine();
                        if (input.ToLower().StartsWith("n"))
                        {
                            //If the user enters a word that starts with the letter N we assume they do not want to try again
                            cbit = true;
                            Console.WriteLine($"It was a pleasure working with you today {uName}. Have a nice life.");
                            break;
                        }
                        else
                        {
                            continue; //for all other responses we assume they do
                        }
                    }
                }
                //Here we know that it is both a number and it is between 1 and 100
                if(oPut % 2 != 0) //Determine if the supplied number is odd or even
                {
                    thatsOdd = true;
                    Console.WriteLine($"{oPut} Odd");
                } 
                else if  ((oPut >= 2 && oPut<= 25) && thatsOdd == false)
                {
                    Console.WriteLine($"Even and less than 25");
                } 
                else if ((oPut>25 && oPut<60) && thatsOdd == false)
                {
                    Console.WriteLine($"Even");
                } 
                else if (oPut > 60 && thatsOdd == false)
                {
                    Console.WriteLine($"{oPut} Even");
                }

                //This is the last check to see if there are other number to be repeatedly analyzed
                Console.WriteLine($"\nDo you want to analyze any other numbers, {uName}? (y/n)"); //ask if the user would like to try again
                input = Console.ReadLine();
                if (input.ToLower().StartsWith("n"))
                {
                    //If the user enters a word that starts with the letter N we assume they do not want to try again
                    cbit = true;
                    Console.WriteLine($"It was a pleasure working with you today {uName}. Have a nice life.");
                }
                else
                {
                    continue; //for all other responses we assume they do
                }
            }


        }
    }
}
