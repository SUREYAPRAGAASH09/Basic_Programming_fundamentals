using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programming_fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program to swap two integers 
            Solutions.swap_two_integers(90, 99);

            //2. Write a program to swap two integers without using a temporary variable
            Solutions.swap_two_integers_WithOut_Temp(91, 99);

            //3. Write a program to swap two integers without using a temporary variable and without involving arithmetic operations that may cause overflow
            Solutions.swap_two_integers_WithOut_Arimethics(90, 99);

            //4. Write a program to find whether the given number is Odd or Even
            Solutions.CheckOddEven(144);

            //5. Write a program to find whether the given year is Leap Year or not
            Solutions.IsLeapYear(2004);

            //6. Write a program to find the greatest and smallest of three numbers.
            Solutions.GreatestSmallestThreeNums(4, 9, 1, false);

            //7. Write a program to check whether a given integer is an Armstrong Number or Not.
            Solutions.IsArmstrongNum(156);

            //8. Write a program to check whether a given integer is Palindrome or Not.
            Solutions.IsNumPalindrome(151);

            //9. Write a program to find the Sum of the digits of a given number
            Solutions.SumOfDgt(1043);

            //10. Write a program to print the numbers that are divisible by 7 between 1 and N
            Solutions.divisibleBy7Btw1ToN(100);

            //11. Write a program to print the sum of squares of all numbers between 1 and N
            Solutions.SumOfSquaresBtw1ToN(10);

            Console.WriteLine("\nSuccessfully executed...!!! :) ");
            Console.ReadKey();
        }
    }
}
