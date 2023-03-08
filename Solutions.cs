using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programming_fundamentals
{
    internal class Solutions
    {
        public static void swap_two_integers(int IntegerOne, int IntegerTwo)
        {
            //Problem statement 
            /* 1. Write a program to swap two integers*/
            Console.WriteLine($"Traditonal method of Program to swap two integers");
            int  temp = 0;

            Console.WriteLine("Before Swap");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);

            temp = IntegerOne;
            IntegerOne = IntegerTwo;
            IntegerTwo = temp;

            Console.WriteLine("After Swaped");
            Console.WriteLine("A = " + IntegerOne);
            Console.Write("B = " + IntegerTwo + "\n");

            ProgramSeparator();
        }

        public static void swap_two_integers_WithOut_Temp(int IntegerOne, int IntegerTwo)
        {
            //Problem statement 
            /* 2. Write a program to swap two integers without using a temporary variable*/
            Console.WriteLine($"Program to swap two integers without using temp varaible");
            
            Console.WriteLine("Before Swap");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);

            IntegerOne = IntegerOne + IntegerTwo;
            IntegerTwo = IntegerOne - IntegerTwo;
            IntegerOne = IntegerOne - IntegerTwo;

            Console.WriteLine("After Swaped");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);
           
            ProgramSeparator();
        }
       
        public static void swap_two_integers_WithOut_Arimethics_Method1(int IntegerOne, int IntegerTwo)
        {
            //Problem statement 
            /* 3. Write a program to swap two integers without using a temporary variable and without involving arithmetic operations that may cause overflow. */
            /*Console.WriteLine($"Program to swap two integers without using a temporary variable and without involving arithmetic operations that may cause overflow");
            //int IntegerOne = 99, IntegerTwo = 98;*/

            Console.WriteLine("Before Swap");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);

            string binaryNumOfIntegerOne = ConvertDecimalToBinary(IntegerOne);
            string binaryNumOfIntegerTwo = ConvertDecimalToBinary(IntegerTwo);

            string AfterOprA = ApplyANDoPr(binaryNumOfIntegerOne, binaryNumOfIntegerTwo);
            string AfterOprB = ApplyORoPr(binaryNumOfIntegerOne, binaryNumOfIntegerTwo);

            //Console.WriteLine(AfterOprB); Console.WriteLine(AfterOprA);

            IntegerOne = Convert.ToInt32(AfterOprB, 2);
            IntegerTwo = Convert.ToInt32(AfterOprA, 2);

            Console.WriteLine("After Swaped");
            Console.WriteLine("A = " + IntegerOne);
            Console.Write("B = " + IntegerTwo + "\n");
            ProgramSeparator();
        }

        public static void Swap_two_integers_WithOut_Arithmetics(int IntegerOne, int IntegerTwo)
        {
            //Problem statement 
            /* 3. Write a program to swap two integers without using a temporary variable and without involving arithmetic operations that may cause overflow. */

            Console.WriteLine("Before Swap");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);

            IntegerOne = IntegerOne ^ IntegerTwo;
            IntegerTwo = IntegerOne ^ IntegerTwo;
            IntegerOne = IntegerOne ^ IntegerTwo;

            Console.WriteLine("After Swaped");
            Console.WriteLine("A = " + IntegerOne);
            Console.Write("B = " + IntegerTwo + "\n");
            ProgramSeparator();

        }
        public static string ConvertDecimalToBinary(int decimalNum)
        {
            string result = "";

            while (decimalNum > 0)
            {
                result += decimalNum % 2;
                decimalNum /= 2;
            }

            return reverseMyString(result);
        } 

        public static int ConvertBinaryToDecimal(string str)
        {
            int temp = 0;
            int j = 0;
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                int a = Convert.ToInt32(str[i]);
                int b = Convert.ToInt32(Math.Pow(2, j));
                temp += a * b;
                j++;
            }

            return temp;
        }

        public static string reverseMyString(string str)
        {
            string result = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                result = result + str[i];
            }

            return result;
        }

        public static string ApplyANDoPr(string strA, string strB)
        {
            string resultStr = "";

            int strLengthA = strA.Length, strLengthB = strB.Length, temp = 0;

            if (strLengthA > strLengthB)
            {
                temp = strLengthA - strLengthB;
                strB = CorrectBinaryLength(strB, temp);
            }
            else
            {
                temp = strLengthB - strLengthA;
                strA = CorrectBinaryLength(strA, temp);
            }

            for (int i = 0; i < strA.Length; i++)
            {
                if ((strA[i] == '1') && (strB[i] == '1'))
                    resultStr += "1";
                else
                    resultStr += "0";
            }

            return resultStr;
        }

        public static string ApplyORoPr(string strA, string strB)
        {
            string resultStr = "";

            int strLengthA = strA.Length, strLengthB = strB.Length, temp = 0;

            if (strLengthA > strLengthB)
            {
                temp = strLengthA - strLengthB;
                strB = CorrectBinaryLength(strB, temp);
            }
            else
            {
                temp = strLengthB - strLengthA;
                strA = CorrectBinaryLength(strA, temp);
            }

            for (int i = 0; i < strA.Length; i++)
            {
                if ((strA[i] == '0') && (strB[i] == '0'))
                    resultStr += "0";
                else
                    resultStr += "1";
            }

            return resultStr;
        }

        public static string CorrectBinaryLength(string str, int Length)
        {
            string resultStr = "";

            while (Length > 0) 
            {
                resultStr += "0";
                Length--;
            } 

            return resultStr + str;
        } 

        public static void CheckOddEven(int num)
        {
            //Problem statement
            //4. Write a program to find whether the given number is Odd or Even 
            Console.Write($"Program to find whether the given number is Odd or Even :  {num}");
            
            if (num%2 == 0)
                Console.Write(" -> Is an Even number\n");
            else if(num%2 == 1)
                Console.WriteLine(" -> Is an Odd number\n");
            
            ProgramSeparator();
        }

        public static void IsLeapYear(int year)
        {
            //Problem statement
            //5. Write a program to find whether the given year is Leap Year or not 
            Console.Write($"Program to find whether the given year is Leap Year or not :  {year}");
            if (year % 4 == 0)
                Console.Write(" -> Is A Leap Year \n");
            else 
                Console.Write(" -> Not A Leap Year \n");
            
            ProgramSeparator();
        }

        public static void GreatestSmallestThreeNums(int A, int B, int C, bool IsGreatest)
        {
            //Problem statement
            //6. Write a program to find the greatest and smallest of three numbers. 
            
            int temp = 0;
            if (IsGreatest)
            {
                if ((B > A) && (B > A))
                    temp = B;
                else if ((C > A) && (C > B))
                    temp = C;
                else
                    temp = A;

                Console.Write($"The Greatest of {A}, {B} and {C} is {temp} \n");
            }
            else
            {
                if ((A > C) && (B > C))
                    temp = C;
                else if ((C > A) && (B > C))
                    temp = A;
                else
                    temp = B;

                Console.Write($"The Smallest of {A}, {B} and {C} is {temp} \n");
            }
            ProgramSeparator();
        }

        public static void IsArmstrongNum(int num)
        {
            //Problem statement
            //7. Write a program to check whether a given integer is an Armstrong Number or Not.
            Console.Write($"Program to check whether a given integer is Armstrong Number or Not :  {num}");
            int temp = 0, result = 0;
            int CpyNum = num;
            while (num > 0)
            {
                temp = num % 10;
                result += (temp * temp * temp);
                num /= 10;
            }

            if ((CpyNum - result) == 0)
                Console.Write($" -> Is a armstrong number \n ");
            else
                Console.Write($" -> Not a armstrong number \n ");

            ProgramSeparator();
        }

        public static void IsNumPalindrome(int num)
        {
            //Problem statement
            //8. Write a program to check whether a given integer is Palindrome or Not.

            Console.Write($"Program to check whether a given integer is Palindrome or Not :  {num}  ");

            int res = 0, temp = 0 ,CpyNum = num;
            while (num > 0)
            {
                temp = num % 10;
                res = (res * 10) + temp;
                num /= 10;
            }

            if ((CpyNum - res) == 0)
                Console.Write($" -> Is a Palindrome Number \n");
            else
                Console.Write($" -> Not a Palindrome Number \n");

            ProgramSeparator();
        }

        public static void SumOfDgt(int num)
        {
            //Problem statement
            //9. Write a program to find the Sum of the digits of a given number 
            
            Console.Write($"program to find the Sum of the digits of a given number {num}  ");
            
            int temp = 0, res = 0, CpyNum = num;

            while (num > 0)
            {
                temp = num % 10;
                res += temp;
                num /= 10;
            }
            Console.Write($" : {res} \n");
            ProgramSeparator();
        }

        public static void divisibleBy7Btw1ToN(int N)
        {
            //Problem statement
            //10. Write a program to print the numbers that are divisible by 7 between 1 and N. 

            Console.WriteLine($"Printing number that are divisible by 7 between 1 to {N} : ");
            
            for (int i = 1; i < N; i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
            }
            ProgramSeparator();
        }

        public static void SumOfSquaresBtw1ToN(int N)
        {
            //Problem statement
            //11. Write a program to print the sum of squares of all numbers between 1 and N
            Console.WriteLine($"Printing Sum of Squares of number between 1 to {N} : ");
            
            for (int i = 1;i < N; i++)
            {
                Console.WriteLine((i * i));
            }
            ProgramSeparator();
        }

        public static void ProgramSeparator()
        {
            for (int i = 1; i < 150; i++)
                Console.Write("*");
            Console.WriteLine();
        }

        //public
    }
}
