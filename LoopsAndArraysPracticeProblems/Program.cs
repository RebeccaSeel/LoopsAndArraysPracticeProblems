using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndArraysPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //HOMEWORK DO IT PROBLEM
            //Create an array of lucky numbers(just any numbers you like). Using a foreach loop, print the following:
            //If the array holds the numbers 3, 5, 7, 11, 15, then the printed result should say
            //Your Lucky Number is: 3
            //Your Lucky Number is: 5
            //Your Lucky Number is: 7
            //Your Lucky Number is: 11
            //Your Lucky Number is: 15

            //int[] luckyNumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            //foreach (int matchNumber in luckyNumbers)
            //{
            //    if (matchNumber.Equals(3))
            //    {
            //        Console.WriteLine("Your lucky number is: 3");
            //    }
            //    else if (matchNumber.Equals(5))
            //    {
            //        Console.WriteLine("Your lucky number is: 5");
            //    }
            //    else if (matchNumber.Equals(7))
            //    {
            //        Console.WriteLine("Your lucky number is: 7");
            //    }
            //    else if (matchNumber.Equals(11))
            //    {
            //        Console.WriteLine("Your lucky number is: 11");
            //    }
            //    else if (matchNumber.Equals(15))
            //    {
            //        Console.WriteLine("Your lucky number is: 15");
            //    }
            //}

            //Console.WriteLine("==================");

            //HOMEWORK PROBLEM #2
            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.
            //for (int i = 0; i < 5 * 5; ++i)
            //{
            //    int a = i / 5 + 1;
            //    int b = i % 5 + 1;
            //    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            //}
            //or
            //int multNum = 1;
            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= 5; j++)
            //    {
            //        Console.WriteLine(multNum * j + " ");
            //    }
            //    multNum += 1;
            //    Console.WriteLine();
            //}
            //or, without an initial variable of multNum
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.WriteLine(i * j + " ");
            //    }
            //    i += 1;
            //    Console.WriteLine();
            //}
            //or allow user to enter numbers
            //int multNum = 1;
            //Console.WriteLine("Enter your first number:");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your second number:");
            //int secondNumber = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= firstNumber; i++)
            //{
            //    for (int j = 1; j <= secondNumber; j++)
            //    {
            //        Console.WriteLine(multNum * j + " ");
            //    }
            //    multNum += 1;
            //    Console.WriteLine();
            //}

            //Console.WriteLine("==================");

            //HOMEWORK PROBLEM #3
            //Create an array of your favorite movies.Print out each movie in the list, unless the move starts with a vowel. 
            //Hint: Research.startsWith()
            string[] favMovies = { "Pride & Prejudice", "The Transporter", "Avatar", "The Hobbit", "Woman in Black" };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (string movieTitle in favMovies)
            {
                if (movieTitle.StartsWith(vowels))
                {

                }
            }
            return true;

            Console.WriteLine("==================");



            //HOMEWORK #4
            //Write a console application that asks the user for an integer. 
            //If that integer is evenly divisible by 3, then write “You Won!” If it isn’t, write “You Lost.” 
            //Keep asking them for a number (looping) until they win.
            //Console.WriteLine("Please enter an integer:");
            //int userNum = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= userNum; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("You Won!");
            //        break;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("You Lost!");
            //        Console.WriteLine("Please enter another integer:");
            //        Console.ReadLine();
            //    }
            //}

            //Console.WriteLine("==================");


            //JORDAN ASSIGN #1
            //Write a console application that prints out hello world 10 times to the console
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("hello world");
            //}

            //Console.WriteLine("==================");


            //JORDAN ASSIGN #2
            //Write a console application and print out the numbers 1 to 100 to the console.
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //JORDAN ASSIGN #3
            //Write a console application that finds the sum of 1 to 20 and outputs that sum to the console. 
            //int number, sum = 0;
            //for (number = 1; number <= 20; number++)
            //{
            //    sum = sum + number;
            //}
            //Console.WriteLine("Sum = {0}", sum);
            //Console.ReadLine();


            //JORDAN ASSIGN #4
            //Write a console application that asks the user for word or phrase, 
            //print the number of vowels in that word to the console. 

            //int totalVowels = 0;
            //char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //Console.WriteLine("Enter a word or phrase: ");
            //string wordPhrase = Console.ReadLine().ToLower();

            //for (int i = 0; i<wordPhrase.Length; i++)
            //{
            //    if (vowels.Contains(wordPhrase[i]))
            //    {
            //        totalVowels++;
            //    }
            //}
            //Console.WriteLine("Your total number of vowels is: {0}", totalVowels);
            //Console.ReadLine();
            //Console.WriteLine("==================");


            //JORDAN ASSIGN #5
            //Create an integer array of 10 numbers and print those numbers to the console. Use both a for loop and a foreach loop. 
            //int[] myNumbers = { 8, 3, 5, 11, 21, 7, 42, 1, 67, 36 };
            //foreach (int number in myNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("==================");


            //JORDAN ASSIGN #6
            //Create a string variable and print all the elements of that string to the console. 
            //string[] aunts = { "Elizabeth", "Brenda", "Ruth", "Vivian" };
            //for (int i = 0; i < aunts.Length; i++)
            //{
            //    Console.WriteLine(aunts[i]);
            //}
            //Console.WriteLine("==================");


            //JORDAN ASSIGN #7
            //Create a string variable and print out that variable in reverse without using the reverse method. 
            //Hint: use loops XD
            //string fullName = "Rebecca Lynn Seel";
            //Console.WriteLine(fullName);
            //string reverseName = fullName;
            //for (int i = fullName.Length - 1; i >= 0; i--)
            //{
            //    reverseName = reverseName + fullName[i];
            //}
            //Console.WriteLine("Reverse  string variable  {0}", reverseName);



            //JORDAN ASSIGN #8
            //Math - n - Stuff
            //Write a Programing and ask the user for 2 numbers(N and M) Check to see if M is greater than N. 
            //Between N and M find all the numbers that are divisible by 3 with no remainder and print those numbers to the console. 
            Console.WriteLine("Enter your first number:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLIne("Enter your second number:");
            int M = int.Parse(Console.ReadLine());
            if (M > N)
            {
                Console.WriteLine("Number " + M + " is greater than " + N +);
            }
            Console.WriteLine(Check);
            for (int i = 1; i <= numMultiple; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(numMultiple);
                }




                //JORDAN ASSIGN #9
                //The Sound of M s c (Music)  
                //Create an Array for Music Instruments. The array must have a length of  7.Loop and remove all of the vowels.
                //Output the result to the console.Hint(You will need 2 for loops) (also look up the string method remove) 
                string[] instruments = { "oboe", "guitar", "flute", "drums", "cello", "mandolin", "banjo" };
                char[] vowelLetters = { 'a', 'e', 'i', 'o', 'u' };
                for (int i = 0; i < instruments.Length; i++)
                {
                    foreach (char vowel in vowelLetters)
                    {
                        int vowelIndex;
                        string shortInstruments = instruments[0];
                        while ((vowelIndex = shortInstruments.IndexOf(vowel)) != -1)
                        {
                            shortInstruments = shortInstruments.Substring(0, vowelIndex) + shortInstruments.Substring(vowelIndex + 1);
                        }
                    }

                    Console.WriteLine(instruments[i];
                }







                //JORDAN ASSIGN #10
                //Battle of the Sexes
                //Create an Array to hold these EXACT string values:
                //Beyonce(f)
                //David Bowie (m)
                //Elvis Costello(m)
                //Madonna(f)
                //Elton John(m)
                //Charles Aznavour(m)
                //Write a program to loop and count how many male and female artists there are and output that to the console.
                //Hint: Look up Contains string method
                string[] musicianNames = { "Beyonce(f)", "David Bowie(m)", "Elvis Costello(m)", "Madonna(f)", "Elton John(m)", "Charles Asnavour(m)" };
                foreach (string artist in musicianNames)
                {
                    Console.WriteLine(artist);
                }


                //JORDAN ASSIGN #11
                //lucky number slevin
                //Write a program which asks the user for a number and how many times that number should be repeated.
                //The program should output the first number repeated as many times as the user has indicated. 
                //Ex:
                //Enter a number: 7
                //How many times do you want to see that number: 3
                //777 
                //Console.WriteLine("Enter a number:");
                //int initialNumber = int.Parse(Console.ReadLine());
                //Console.WriteLine("How many times do you want to see that number:");
                //int repeatNumber = Convert.ToInt32(Console.ReadLine());
                //for (int i = 0; i<repeatNumber; i++)
                //{
                //    Console.Write(initialNumber);

                //}
                //Console.WriteLine();

                //JORDAN ASSIGN #12
                //Who's the biggest?  
                //Write a program that ask the user for 3 numbers then returns the biggest and the smallest numbers.
                //Bonus: Do not use Arrays
                Console.WriteLine("Enter your first number:");
                int numOne = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number:");
                int numTwo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your third number:");
                int numThree = int.Parse(Console.ReadLine());



                //JORDAN ASSIGN #13
                //Has your luck run out? 
                //You are an international Gem thief. You have broken into the heavily guarded Jewel vault in Beppu, Japan.
                //Just as you are about to get away with the make biggest heist in your LIFE. 
                //The doors lock and you’re trapped the only way out is to outsmart the computer's AI. 
                //Create an AI(program)  where the user has to guess what 3 numbers open the Jewel vault. 
                //The users only gets 5 chances per number.If the user gets any of the number right that reset the chances back to 5. 
                //The AI (program) should tell the user if their guess is too high or too low. 




                //JORDAN ASSIGN #14
                //Spider-man vs Joker?
                //Create a program that allows the user to become a super powered individual.
                //Ask the user for:
                //Their Age
                //Their Birth Year
                //Their Alter Ego name
                //Who their secret Identity is 
                //Create 2 Arrays one for Enhanced Abilities another for weakness. 
                //Have the user pick a number at random between the 0 and the length of the array this will choose the 
                //Enhanced Ability as well as the Weakness. Output your story to the console and have fun!!
                Console.WriteLine("What is your age?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your birth year?");
                int birthYear = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your Alter Ego name?");
                string altEgoName = Console.ReadLine();
                Console.WriteLine("What is your secret identity?");
                string secretIdent = Console.ReadLine();

            }
        }
    }
