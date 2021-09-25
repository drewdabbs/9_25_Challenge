using System;
using System.Collections.Generic;

namespace _9_25_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze:
            // Part 1 - Print every letter of the word "Supercalifragilisticexpialidocious"
            // to the console, one at a time.
            // Part 2 - Next, do the same, except only print the letter if it's an 'i'.
            // If it's any other letter, print "Not an i".

            // P1: Suggestion?: use Console.WriteLine to print out: char S = 'S';
            // noting to not repeat char and that 'S' and 's' are different char
            // P2: If Else statement? If char = 'i' Console.WriteLine(i);
            // Else Console.WriteLine("Not an i");

            

            Console.WriteLine("Print Supercalifragilisticexpialidocious");  // String of authors  
            string word = "supercalifragilisticexpialidocious";
            char[] charArray = word.ToCharArray();




            foreach(char letter in charArray)
            {
                
                if(letter != 'i')
                {
                    Console.WriteLine("Not an i"); 
                }
                else
                {
                    Console.WriteLine(letter);
                }
             
            }
            foreach (char letter in charArray)
            {
                Console.WriteLine(letter);
            }



            


            // or

            // Severa Cox's code

            string superCopy = "Supercalifragilisticexpialidocious";
            string superLongWord = superCopy.ToLower();
            foreach(char letter in superLongWord)
            {
                Console.WriteLine(letter);
            }
            foreach(char letter in superLongWord)
            {
                var writeLine = (letter == 'i') ? "i" : "not and i";
                Console.WriteLine(writeLine);
            }


            // Silver:
            // After that, print the number of letters in the word
            // (do this with code, not by counting manually and hard-coding the number).

            // Suggestions?

            // Severa Cox's code

            Console.WriteLine(superLongWord.Length);





            // Gold:
            // In part 2 of Bronze, also determine if the letter is 'L'.
            // If it is, print 'L'.

            // Suggestion?: As above If char = 'i'; Console.WriteLine(i);
            // If char = 'l'; Console.WriteLine(l);
            // Else Console.WriteLine("Not an 'i' or a 'l'.)

            // Severa Cox's code

            foreach (char letter in superLongWord)
            {
                var writeLine = (letter == 'i' || letter == 'l') ? letter.ToString() : "not and i";
                Console.WriteLine(writeLine);
            }
            Console.ReadKey();

        }
    }
}
