using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programming_fundamentals
{
    internal class Solutions
    {
        public static void swap_two_integers()
        {
            //Problem statement 
            /*Write a program to swap two integers*/

            int IntegerOne = 1, IntegerTwo = 2, temp = 0;

            Console.WriteLine("Before Swap");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);

            temp = IntegerOne;
            IntegerOne = IntegerTwo;
            IntegerTwo = temp;

            Console.WriteLine("After Swaped");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);
        }

        public static void swap_two_integers_WithOut_Temp()
        {
            //Problem statement 
            /*Write a program to swap two integers without using a temporary variable*/

            int IntegerOne = 1000, IntegerTwo = 2000;

            Console.WriteLine("Before Swap");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);

            if (IntegerOne > IntegerTwo)
            {
                IntegerOne = IntegerOne - IntegerTwo;
                IntegerTwo = IntegerTwo + IntegerOne;
            }
            else
            {
                IntegerTwo = IntegerTwo - IntegerOne;
                IntegerOne = IntegerOne + IntegerTwo;
            }

            Console.WriteLine("After Swaped");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);
        }
       
        public static void swap_two_integers_WithOut_Arimethics()
        {
            //Problem statement 
            /*Write a program to swap two integers without using a temporary variable and without involving arithmetic operations that may cause overflow. */

            int IntegerOne = 99, IntegerTwo = 98;

            Console.WriteLine("Before Swap");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);

            string binaryNumOfIntegerOne = ConvertDecimalToBinary(IntegerOne);
            string binaryNumOfIntegerTwo = ConvertDecimalToBinary(IntegerTwo);

            string AfterOprA = ApplyANDoPr(binaryNumOfIntegerOne, binaryNumOfIntegerTwo);
            string AfterOprB = ApplyORoPr(binaryNumOfIntegerOne, binaryNumOfIntegerTwo);

            Console.WriteLine(AfterOprB); Console.WriteLine(AfterOprA);

            IntegerOne = Convert.ToInt32(AfterOprB, 2);
            IntegerTwo = Convert.ToInt32(AfterOprA, 2);

            Console.WriteLine("After Swaped");
            Console.WriteLine("A = " + IntegerOne);
            Console.WriteLine("B = " + IntegerTwo);
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
            //Write a program to find whether the given number is Odd or Even 

            if (num%2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else if(num%2 == 1)
            {
                Console.WriteLine("Odd number");
            }
        }

        public static void IsLeapYear(int year)
        {
            //Problem statement
            //Write a program to find whether the given number is Odd or Even

            if (year % 4 == 0)
            {
                Console.WriteLine("Is A Leap Year");
            }
            else 
            {
                Console.WriteLine("Is Not A Leap Year");
            }
        }

        public static void GreatestSmallestThreeNums(int A, int B, int C, bool IsGreatest)
        {
            //Problem statement
            //Write a program to find the greatest and smallest of three numbers. 

            int temp = 0;
            if (IsGreatest)
            {
                if ((B > A) && (B > A))
                    temp = B;
                else if ((C > A) && (C > B))
                    temp = C;
                else
                    temp = A;

                Console.WriteLine($"The Greatest of {A}, {B} and {C} is {temp}");
            }
            else
            {
                if ((A > C) && (B > C))
                    temp = C;
                else if ((C > A) && (B > C))
                    temp = A;
                else
                    temp = B;

                Console.WriteLine($"The Smallest of {A}, {B} and {C} is {temp}");
            }
        }

        public static void IsArmstrongNum(int num)
        {
            //Problem statement
            //Write a program to check whether a given integer is an Armstrong Number or Not.

            int temp = 0, result = 0;
            int CpyNum = num;
            while (num > 0)
            {
                temp = num % 10;
                result += (temp * temp * temp);
                num /= 10;
            }

            if ((CpyNum - result) == 0)
                Console.WriteLine($"Given number {CpyNum} is a armstrong number");
            else
                Console.WriteLine($"Given number {CpyNum} is not a armstrong number");
        }

        public static void IsNumPalindrome(int num)
        {
            //Problem statement
            //Write a program to check whether a given integer is Palindrome or Not.

            int res = 0, temp = 0 ,CpyNum = num;
            while (num > 0)
            {
                temp = num % 10;
                res = (res * 10) + temp;
                num /= 10;
            }

            if ((CpyNum - res) == 0)
                Console.WriteLine($"Given number {res} is a Palindrome Number");
            else
                Console.WriteLine($"Given number {res} is not a Palindrome Number");
        }

        public static void SumOfDgt(int num)
        {
            //Problem statement
            //Write a program to find the Sum of the digits of a given number 

            int temp = 0, res = 0, CpyNum = num;

            while (num > 0)
            {
                temp = num % 10;
                res += temp;
                num /= 10;
            }
            Console.WriteLine($"The Sum of Digit of {CpyNum} is {res}");
        }
    }
}
