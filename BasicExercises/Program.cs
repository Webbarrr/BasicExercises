using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace BasicExercises
{
    class Program
    {
        // https://www.w3resource.com/csharp-exercises/basic/index.php
        static void Main(string[] args)
        {
            int a, b, c, d;
            string s;

            string sentence = "The quick brown fox jumps over the lazy dog.";
            int[] intArray = { 4, 8, 15, 16, 23, 42, 4, 9, 15, 17, 23, 43 ,4 };
            int[] intArrayExtra = { 18, 8, 15, 16, 23, 42, 4, 9, 15, 17, 23, 43 ,10 };
            int[] x = { 3, 12, 86, 14, 90, 23, 11, 15, 30, 4, 18 };
            int[] smallIntArray = { 101, 86, 320 };

            //// 1. Write a C# Sharp program to print Hello and your name in a separate line.
            //Console.WriteLine("Hello");
            //Console.WriteLine("James Webber");

            //// 2.Write a C# Sharp program to print the sum of two numbers.
            //Console.WriteLine(6 + 9);

            //// 3. Write a C# Sharp program to print the result of dividing two numbers.
            //Console.WriteLine(6 / 9);

            //// 4. Write a C# Sharp program to print the result of the specified operations.
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5) % 7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            //// 5.Write a C# Sharp program to swap two numbers.
            //a = AskForNumber("Input a first number: ");
            //b = AskForNumber("Input a second number: ");
            //Console.WriteLine("After swapping:");
            //SwapInts(ref a, ref b);
            //Console.WriteLine("First Number: {0} Second Number: {1}", a, b);

            //// 6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
            //a = AskForNumber("Give me a number to multiply: ");
            //b = AskForNumber("Give me a second number to multiply: ");
            //c = AskForNumber("Give me a third number to multiply: ");
            //Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, a * b * c);

            //// 7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
            //a = AskForNumber("Give me a number:");
            //b = AskForNumber("And another number:");
            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //Console.WriteLine("{0} - {1} = {2}", a, b, a-b);
            //Console.WriteLine("{0} * {1} = {2}", a, b, a*b);
            //Console.WriteLine("{0} / {1} = {2}", a, b, a/b);
            //Console.WriteLine("{0} mod {1} = {2}", a, b, a % b);

            //// 8. Write a C# Sharp program that takes a number as input and print its multiplication table.
            //a = AskForNumber("Give me another number:");
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            //}

            //// 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            //a = AskForNumber("Give me a number");
            //b = AskForNumber("Give me a second number");
            //c = AskForNumber("Give me a third number");
            //d = AskForNumber("Give me a fourth number");
            //Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", a, b, c, d, (a + b + c + d) / 4);

            //// 10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
            //a = AskForNumber("Enter first number (x): ");
            //b = AskForNumber("Enter second number (y): ");
            //c = AskForNumber("Enter third number (z): ");
            //Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x + y)*z is {3} and (x*y) + (y*z) is {4}", a, b, c, (a + b)*c, (a*b) + (b*c));

            //// 11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
            //a = AskForNumber("How old are you?");
            //Console.WriteLine("You look older than {0}", a);

            //// 12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), 
            ////     and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}
            //a = AskForNumber("Give me a number: ");
            //WeirdLoop(a);

            //// 13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
            //a = AskForNumber("Give me a number: ");
            //DrawARectangle(a);

            //// 14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
            //a = AskForNumber("Enter the amount of celsious: ");
            //Console.WriteLine("{0} celsius is {1} Kelvin or {2} Fahrenheit.", a, (a + 273), (a * 1.8) + 32);

            //// 15. Write a C# program remove specified a character from a non-empty string using index of a character.
            //s = AskQuestion("Give me a word or a sentence");
            //a = AskForNumber("Give me a number between 1 & " + s.Length);
            //Console.WriteLine(RemoveChar(s, a - 1));

            //// 16. Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            //s = AskQuestion("Give me a word: ");
            //Console.WriteLine(SwapFirstAndLastChars(s));

            //// 17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
            //Console.WriteLine(sentence[0] + sentence + sentence[0]);

            //// 18. Write a C# program to check two given integers and return true if one is negative and one is positive.
            //a = AskForNumber("Give me a number: ");
            //b = AskForNumber("One more number: ");
            //Console.WriteLine(((a >= 0 && b < 0) || (a < 0 && b >= 0)));

            //// 19.Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
            //a = AskForNumber("Give me a number: ");
            //b = AskForNumber("One more number: ");
            //Console.WriteLine(ReallyBadCalculator(a, b));

            //// 20.Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number. 
            //a = AskForNumber("Give me a number: ");
            //b = AskForNumber("One more number: ");
            //Console.WriteLine("The difference is {0}", Difference(a, b));

            //// 21.Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            //a = AskForNumber("Give me a number ");
            //b = AskForNumber("One more number: ");
            //Console.WriteLine(CheckSum(a, b));

            //// 22. Write a C# program to check if an given integer is within 20 of 100 or 200.
            //a = AskForNumber("Give me a number: ");
            //Console.WriteLine(WithinRangeOfX(a, 20, 100));
            //Console.WriteLine(WithinRangeOfX(a, 20, 200));

            //// 23. Write a C# program to convert a given string into lowercase.
            //Console.WriteLine(sentence);
            //Console.WriteLine(Lower(sentence));

            //// 24.Write a C# program to find the longest word in a string.
            //Console.WriteLine("The biggest word in this sentence '{0}' is '{1}'", sentence, BiggestWordInString(sentence));

            //// 25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            //Console.WriteLine("All the odd numbers from 1 to 99!");
            //AllOddNumbersInRange(99);

            //// 26. Write a C# program to compute the sum of the first 500 prime numbers.
            //Console.WriteLine("The sum of the first 500 primes is: {0:d}", SumOfNPrimes(500));

            //// 27. Write a C# program and compute the sum of the digits of an integer.
            //a = DigitsOfInteger(AskForNumber("Give me a number bigger than 9: "));
            //Console.WriteLine(a);

            //// 28. Write a C# program to reverse the words of a sentence.
            //Console.WriteLine(sentence);
            //Console.WriteLine(RevStr(sentence));

            //// 29.Write a C# program to find the size of a specified file in bytes.
            //Console.WriteLine("The solution for this file is {0:D} bytes!", FileSize(@"c:\Users\james.webber\source\repos\C#\BasicExercises\BasicExercises.sln"));

            //// 30. Write a C# program to convert a hexadecimal number to decimal number.
            //s = "2A5";
            //Console.WriteLine("Did you know that {0} in decimal is {1}", s, HexToDec(s));

            //// 31. Write a C# program to multiply corresponding elements of two arrays of integers.
            //int[] a1 = { 1, 3, -5, 4 };
            //int[] a2 = { 1, 4, -5, -2 };
            //MultiplyTwoArrays(a1, a2);

            //// 32. Write a C# program to create a new string of four copies, taking last four characters from a given string. 
            //// If the length of the given string is less than 4 return the original one.
            //Console.WriteLine("Sample String: {0} = {1}", sentence, FourCopies(sentence));
            //Console.WriteLine(FourCopies("cat"));

            //// 33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7
            //Console.WriteLine((IsXMultipleOfN(15, 3) || IsXMultipleOfN(15, 7)));

            ////34. Write a C# program to check if a string starts with a specified word.
            //Console.WriteLine(BeginsWith(sentence, "The"));
            //Console.WriteLine(BeginsWith(sentence, "the"));

            //// 35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
            //a = AskForNumber("Give me a number that's <100: ");
            //b = AskForNumber("Give me a number that's >100: ");
            //Console.WriteLine((a < 100) && (b > 100));

            //// 36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
            //a = AskForNumber();
            //b = AskForNumber();
            //Console.WriteLine((Exercise36(a) || Exercise36(b)));

            //// 37.Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".
            //Console.WriteLine("Test Data:");
            //Console.Write("PHP Tutorial");
            //Console.WriteLine("Found 'HP'!");
            //Console.WriteLine(Exercise37("PHP Tutorial", "HP"));

            //// 38. Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH".
            //Console.WriteLine(Exercise38("PHP Tutorial"));
            //s = AskQuestion("Give me a word:");
            //Console.WriteLine(Exercise38(s));

            //// 39. Write a C# program to find the largest and lowest values from three integer values.
            //a = AskForNumber();
            //b = AskForNumber();
            //c = AskForNumber();
            //Exercise39(a, b, c);

            //// 40.Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
            //a = AskForNumber();
            //b = AskForNumber();
            //Console.WriteLine(Exercise40(a, b));

            //// 41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
            //Console.WriteLine(Exercise41(sentence));

            //// 42. Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case.
            //Console.WriteLine(Exercise42(sentence));

            //// 43.Write a C# program to check if a given string starts with "w" and immediately followed by two "ww".
            //s = AskQuestion("Give me a website address");
            //Console.WriteLine(Exercise43(s));

            //// 44. Write a C# program to create a new string of every other character (odd position) from the first position of a given string.
            //Console.WriteLine(Exercise44("Hello World!"));

            //// 45. Write a C# program to count a specified number in a given array of integers.
            //a = AskForNumber();
            //Console.WriteLine("{0} appears in the array {1} time(s).", a, Exercise45(a,intArray));

            //// 46. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
            //Console.WriteLine(Exercise46(4, intArray));
            //Console.WriteLine(Exercise46(43, intArray));
            //Console.WriteLine(Exercise46(23, intArray));

            //// 47. Write a C# program to compute the sum of all the elements of an array of integers.
            //Console.WriteLine(Exercise47(intArray));

            //// 48. Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.
            //Console.WriteLine(Exercise48(intArray));

            //// 49.Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.
            //Console.WriteLine(Exercise49(intArray, intArrayExtra));

            //// 50. Write a C# program to rotate an array (length 3) of integers in left direction.
            //Console.WriteLine("[{0}]", string.Join(", ", Exercise50(intArray)));

            //// 51.  Write a C# program to get the larger value between first and last element of an array (length 3) of integers.
            //Console.WriteLine(Exercise51(intArray));

            //// 52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
            //Console.WriteLine(string.Join(",", Exercise52(intArray, intArrayExtra, smallIntArray)));

            //// 53. Write a C# program to check if an array contains an odd number.
            //Console.WriteLine(Exercise53(intArray));

            //// 54.Write a C# program to get the century from a year.
            //Console.WriteLine(Exercise54(DateTime.Today));

            //// 55. Write a C# program to find the pair of adjacent elements that has the largest product of an given array.
            //Exercise55(intArray);

            //// 56. Write a C# program to check if a given string is a palindrome or not.
            //Console.WriteLine(Exercise56("aaa"));
            //Console.WriteLine(Exercise56("aab"));

            //// 57.Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers.
            //// TODO - Queried with w3resource as seems identical to question 55

            //// 58. Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range.
            //Exercise58(new int[] { 1,3,4,7,9});

            //// 59. Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array.
            //Console.WriteLine(Exercise59(new int[] { 1, 3, 5 }));
            //Console.WriteLine(Exercise59(new int[] { 0, 10 }));
            //Console.WriteLine(Exercise59(new int[] { 1,3,1,3 }));

            //// 60. Write a C# program to calculate the sum of all the integers of a rectangular matrix except those integers which are located below an integer of value 0.
            //int[][] matrix = new int[][] 
            //{
            //        new int[]{0, 2, 3, 2},
            //        new int[]{0, 6, 0, 1},
            //        new int[]{4, 0, 3, 0}
            //};
            //Console.WriteLine(Exercise60(matrix));

            //// 61. Write a C# program to sort the integers in ascending order without moving the number -5.
            //int[] temp = Exercise61(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 },-5);
            //foreach (var item in temp)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //// 62. Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string.
            //Console.WriteLine(Exercise62("p(rq)st"));
            //Console.WriteLine(Exercise62("(p(rq)st)"));
            //Console.WriteLine(Exercise62("ab(cd(ef)gh)ij"));

            Console.ReadLine();
        }
        private static void SwapInts(ref int int1, ref int int2)
        {
            int temp = 0;
            temp = int1;

            int1 = int2;
            int2 = temp;
        }
        private static int AskForNumber(string Question = "Give me a number")
        {
            string temp = "";
            int n = 0;

            do
            {
                Console.WriteLine(Question);
                temp = Console.ReadLine();
                if (int.TryParse(temp, out n))
                    break;
            } while (true);

            return int.Parse(temp);
        }
        private static string AskQuestion(string Question)
        {
            Console.WriteLine(Question);
            return Console.ReadLine();
        }
        private static void WeirdLoop(int n)
        {
            string template = "{0} {1} {2} {3}";
            string strN = n.ToString();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(template, strN, strN, strN, strN);
                Console.WriteLine(template.Replace(" ", ""), strN, strN, strN, strN);
            }
        }
        private static void DrawARectangle(int n)
        {
            string s = n.ToString();
            string template = "{0} {1} {2}";

            Console.WriteLine(template, s, s, s);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(template, s, (s.Length == 1) ? " " : Space(s.Length - 1), s);
            }
            Console.WriteLine(template, s, s, s);
        }
        private static string Space(int n)
        {
            string retVal = "";
            for (int i = 0; i < n + 1; i++)
            {
                retVal += " ";
            }
            return retVal;
        }
        private static string RemoveChar(string str, int n)
        {
            try
            {
                return str.Remove(n, 1);
            }
            catch (Exception)
            {
                return str;
            }
        }
        private static string SwapFirstAndLastChars(string str)
        {
            return str[LastIndexOfString(str)] + str.Substring(1, LastIndexOfString(str) - 1) + str[0];
        }
        private static int LastIndexOfString(string str)
        {
            return str.Length - 1;
        }
        private static int ReallyBadCalculator(int num1, int num2)
        {
            return (num1 == num2) ? num1 * 3 : num1 + num2;
        }
        private static int Difference(int num1, int num2)
        {
            int n = Math.Abs(num1 - num2);
            return (num1 > num2) ? n * 2 : n;
        }
        private static bool CheckSum(int num1, int num2)
        {
            return (num1 == 20 || num2 == 20 || num1 + num2 == 20) ? true : false;
        }
        private static bool WithinRangeOfX(int n, int range, int x)
        {
            return (Math.Abs(n - x) <= range) ? true : false;
        }
        private static string Lower(string yourString)
        {
            return yourString.ToLower();
        }
        private static string BiggestWordInString(string yourString)
        {
            string[] mySentence = yourString.Split(new[] { " " }, StringSplitOptions.None);
            string biggestWord = "";
            int maxLen = 0;

            foreach (string word in mySentence)
            {
                if (word.Length > maxLen)
                {
                    biggestWord = word;
                    maxLen = word.Length;
                }
            }

            return biggestWord;
        }
        private static void AllOddNumbersInRange(int n)
        {
            for (int i = 0; i < n + 1; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
        private static bool IsPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int x = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 2; i <= x; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
        private static int SumOfNPrimes(int n)
        {
            int mySum = 0;
            int i = 1;
            int counter = 1;
            while (counter < n + 1)
            {
                if (IsPrime(i))
                {
                    mySum += i;
                    counter++;
                }
                i++;
            }
            return mySum;
        }
        private static int DigitsOfInteger(int n)
        {
            string myString = n.ToString();
            int mySum = 0;
            int tmp = 0;

            foreach (char letter in myString)
            {
                int.TryParse(letter.ToString(), out tmp);
                mySum += tmp;
            }

            return mySum;
        }
        private static string RevStr(string yourString)
        {
            char[] charArray = yourString.ToCharArray();
            Array.Reverse(charArray);
            string revString = "";
            foreach (char item in charArray)
            {
                revString += item;
            }
            return revString;
        }
        private static long FileSize(string filePath)
        {
            FileInfo f = new FileInfo(filePath);
            long.TryParse(f.Length.ToString(), out long bytes);
            return bytes;
        }
        private static int HexToDec(string hexVal)
        {
            int dec = int.Parse(hexVal, NumberStyles.HexNumber);
            return dec;
        }
        private static void MultiplyTwoArrays(int[] i1, int[] i2)
        {
            if (i1.Length == i2.Length)
            {
                for (int i = 0; i < i1.Length; i++)
                {
                    Console.Write(i1[i] * i2[i] + " ");
                }
            }
        }
        private static string FourCopies(string yourString)
        {
            if (yourString.Length < 4) return yourString;
            int strLen = LastIndexOfString(yourString);
            string retVal = "";

            for (int i = 0; i < 4; i++)
            {
                retVal += yourString.Substring(strLen - 4);
            }

            return retVal;
        }
        private static bool IsXMultipleOfN(int x,int n)
        {
            return (x % n == 0);
        }
        private static bool BeginsWith(string yourString,string substring)
        {
            return (yourString.StartsWith(substring));
        }
        private static bool Exercise36(int n)
        {
            return (n >= -10 && n <= 10);
        }
        private static string Exercise37(string yourString, string substring)
        {
            return yourString.Replace(substring, "");
        }
        private static string Exercise38(string yourString)
        {
            return (yourString.StartsWith("PH") ? "PH" : yourString);
        }
        private static void Exercise39(int n1, int n2, int n3)
        {
            int largest = Math.Max(n1, Math.Max(n2, n3));
            int lowest = Math.Min(n1, Math.Min(n2, n3));
            Console.WriteLine("Largest of the three numbers is {0}", largest);
            Console.WriteLine("Smallest of the three numbers is {0}", lowest);
        }
        private static int Exercise40(int x,int y)
        {
            int n = 20;
            if (x == y) return 0;
            int val1 = Math.Abs(x - n);
            int val2 = Math.Abs(y - n);
            return (val1 < val2 ? x : y);
        }
        private static bool Exercise41(string yourString)
        {
            int count = yourString.Count(s => s == 'w');
            return (count >= 1 && count <= 3);
        }
        private static string Exercise42(string yourString)
        {
            if (yourString.Length < 4) return yourString.ToUpper();
            return yourString.Substring(0, 4).ToUpper() + yourString.Substring(4, LastIndexOfString(yourString)-4);
        }
        private static bool Exercise43(string yourString)
        {
            if (yourString.StartsWith("w"))
            {
                if (yourString.StartsWith("www")) return true;
            }
            return false;
        }
        private static string Exercise44(string yourString)
        {
            int counter = 1;
            string retVal = "";
            foreach (char letter in yourString)
            {
                if (counter % 2 != 0) retVal += letter;
                counter++;
            }
            return retVal;
        }
        private static int Exercise45(int yourNumber,int[] intArray)
        {
            int counter = 0;
            foreach (int num in intArray)
            {
                if (yourNumber == num) counter++;
            }
            return counter;
        }
        private static bool Exercise46(int yourNumber, int[] intArray)
        {
            return (intArray.Length < 1) ? false : (intArray[0] == yourNumber || intArray[intArray.Length - 1] == yourNumber);
        }
        private static int Exercise47(int[] intArray)
        {
            int retVal = 0;
            foreach (int num in intArray)
            {
                retVal += num;
            }
            return retVal;
        }
        private static bool Exercise48(int[] intArray)
        {
            return (intArray.Length >= 1 && intArray[0] == intArray[intArray.Length - 1]);
        }
        private static bool Exercise49(int[] firstIntArray, int[] secondIntArray)
        {
            if (firstIntArray.Length < 1 || secondIntArray.Length < 1) return false;
            return (firstIntArray[0] == secondIntArray[0] || firstIntArray[firstIntArray.Length - 1] == secondIntArray[secondIntArray.Length - 1]);
        }
        private static int[] Exercise50(int[] intArray)
        {
            var tmp = intArray[0];
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                intArray[i] = intArray[i + 1];
            }
            intArray[intArray.Length - 1] = tmp;
            return intArray;
        }
        private static int Exercise51(int[] intArray)
        {
            int[] sortedArray = intArray.OrderBy(i => i).ToArray();
            return sortedArray[sortedArray.Length - 1];
        }
        private static int[] Exercise52(int[] array1, int[] array2, int[] array3)
        {
            int[] retVal = new int[3];
            retVal[0] = array1[Median(array1)];
            retVal[1] = array2[Median(array2)];
            retVal[2] = array3[Median(array3)];

            return retVal;
        }
        private static int Median(int[] intArray)
        {
            return (intArray.Length - 1) / 2;
        }
        private static bool Exercise53(int[] intArray)
        {
            foreach (int i in intArray)
            {
                if (i % 2 != 0) return true;
            }
            return false;
        }
        private static string Exercise54(DateTime date)
        {
            return MakeOrdinal((date.Year / 100) + 1);
            
        }
        private static string MakeOrdinal(int num)
        {
            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }
            switch (num % 10)
            {
                case 1: return num + "st";
                case 2: return num + "nd";
                case 3: return num + "rd";
                default: return num + "th";
            }
        }
        private static int[] Exercise55(int[] intArray)
        {
            int[] retVal = new int[2];
            int n = 0;
            int maxSize = intArray.Length - 1;

            for (int i = 0; i < maxSize; i++)
            {
                if (i == maxSize) return retVal;
                if (intArray[i] * intArray[i+1] > n)
                {
                    retVal[0] = intArray[i];
                    retVal[1] = intArray[i + 1];
                    n = intArray[i] * intArray[i + 1];
                }
            }
            return retVal;
        }
        private static bool Exercise56(string yourString)
        {
            char[] charArray = yourString.ToCharArray();
            Array.Reverse(charArray);
            return (yourString.ToLower() == string.Join("",charArray).ToLower()?true:false);
        }
        private static int Exercise58(int[] intArray)
        {
            Array.Sort(intArray);
            int size = intArray.Length - 1;
            int counter = 0;

            for (int i = 0; i < size; i++)
            {
                counter += intArray[i + 1] - intArray[i] - 1;
            }

            return counter;
        }
        private static bool Exercise59(int[] intArray)
        {
            int[] tempArray = (int[]) intArray.Clone();
            Array.Sort(tempArray);
            return intArray.SequenceEqual(tempArray);
        }
        private static int Exercise60(int[][] matrix)
        {
            int rectangle = 0;
            int[] positions = new int[] { 1, 1, 1, 1 };
            foreach (int[] item in matrix)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (positions[i] == 0) item[i] = 0;
                    if (item[i] == 0) positions[i] = 0;
                    else
                    {
                        positions[i] = 1;
                        rectangle += item[i];
                    }
                }
            }
            return rectangle;
        }
        private static int[] Exercise61(int[] intArray,int ignore)
        {
            int x = 0;
            int[] tmp = intArray.Where(n => n != ignore).OrderBy(n => n).ToArray();
            return intArray.Select(n => n >= 0 ? tmp[x++] : ignore).ToArray();
        }
        private static string Exercise62(string yourString)
        {
            string retVal = null;
            retVal = yourString.Replace("(", null);
            retVal = retVal.Replace(")", null);

            char[] charArray = retVal.ToCharArray();
            Array.Reverse(charArray);
            return string.Join(null, charArray);
        }
    }
}