using System;
using System.Linq;
using System.Text;

namespace ConditionalStatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfThree();
            //GetMaxOfFive();
            //CalculatePerimeterAndArea();
            //DivInRange();
            //GetMax();
            //SumOfFive();
            //PrintNumbersUpTo();
            //PrintNotDivisible();
            //MinOrMaxOfFive();
            //DrawTriangle();
            //ConvertFromDecimalToBinary();
            //PrintInRandomOrder();
            //FizzBuzz();
            //CompanyInfo();
        }

        #region 01 Calculate te sum of 3 int`s readed from the console
        /*Write a program that reads from the console three numbers of type int and prints their sum.*/
        public static void SumOfThree()
        {
            Console.Write("Please enter First number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter Second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter Third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine($"The sum is: {sum}");
        }
        #endregion

        #region 02 Get the maximum number from 5 numbers readed from console
        /*Write a program that reads five numbers from the console and prints the greatest of them.*/
        public static void GetMaxOfFive()
        {
            Console.Write("Please enter First number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter Second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter Third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter Forth number: ");
            int forthNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter Fifth number: ");
            int fifthNumber = int.Parse(Console.ReadLine());
            int max = firstNumber;

            if ((firstNumber >= secondNumber) && (firstNumber >= thirdNumber) && (firstNumber >= forthNumber) && (firstNumber >= fifthNumber))
            {
                max = firstNumber;
            }
            else if ((secondNumber >= firstNumber) && (secondNumber >= thirdNumber) && (secondNumber >= forthNumber) && (secondNumber >= fifthNumber))
            {
                max = secondNumber;
            }
            else if ((thirdNumber >= firstNumber) && (thirdNumber >= secondNumber) && (thirdNumber >= forthNumber) && (thirdNumber >= fifthNumber))
            {
                max = thirdNumber;
            }
            else if ((forthNumber >= firstNumber) && (forthNumber >= secondNumber) && (forthNumber >= thirdNumber) && (forthNumber >= fifthNumber))
            {
                max = forthNumber;
            }
            else
            {
                max = fifthNumber;
            }
            Console.WriteLine(max);
        }


        #endregion

        #region 03 Calculate Perimeter and Area of an Circle knowing radius
        /*Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.*/
        public static void CalculatePerimeterAndArea()
        {
            Console.Write("Please enter the circle`s radius: ");
            int radius = int.Parse(Console.ReadLine());
            const decimal Pi = 3.141592653589793M;
            decimal perimeter = 2 * Pi * radius;
            Console.WriteLine($"The perimeter of the circle with radius {radius} is: {perimeter}.");
            decimal area = Pi * radius * radius;
            Console.WriteLine($"The area of the circle with radius {radius} is: {area}.");
        }



        #endregion

        #region 04 Count the numbers divisible with 5 from an interval
        /*Write a program that reads from the console two integer numbers (int) and prints how many numbers between them 
        exist that are divisible with 5. such that the remainder of their division by 5 is 0.
        Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.*/
        public static void DivInRange()
        {
            Console.Write("Please enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int biggest = 0;
            int smallest = 0;
            int counter = 0;
            int startInterval = 0;
            if (num1 > num2)
            {
                biggest = num1;
                smallest = num2;
                startInterval = num2;
            }
            else
            {
                biggest = num2;
                smallest = num1;
                startInterval = num1;
            }

            while (smallest < biggest)
            {
                if (smallest % 5 == 0)
                {
                    counter++;
                }
                smallest++;
            }
            Console.WriteLine($"Between {startInterval} and {biggest}, there are {counter} numbers divisible with 5.");
        }
        #endregion

        #region 05 Get maximum without conditional statements
        /*Write a program that reads two numbers from the console and prints the greater of them. 
        Solve the problem without using conditional statements and with conditional statements.*/
        public static void GetMax()
        {
            Console.Write("Please enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            int max = (a > b) ? a : b;
            Console.WriteLine(max);
        }

        #endregion

        #region 06 Sum for five int`s with one validity check
        /*Write a program that reads five integer numbers and prints their sum. 
        If an invalid number is entered the program should prompt the user to enter another number(only once)*/
        public static void SumOfFive()
        {
            //Console.Write("Please enter first number: ");
            //int number = int.Parse(Console.ReadLine());
            string[] value = new string[5];
            int sum = 0;
            bool correct = true;


            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Please enter number {i + 1}: ");
                char[] inserted = Console.ReadLine().ToCharArray();
                if (char.IsDigit(inserted[0]))
                {
                    value[i] = inserted[0].ToString();
                }
                else
                {
                    Console.Write($"Please enter number {i + 1} again: ");
                    inserted = Console.ReadLine().ToCharArray();
                    correct = char.IsDigit(inserted[0]);
                }
            }
            if (correct)
            {
                foreach (var number in value)
                {
                    sum += int.Parse(number);
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("You re-entered an invalid number.");
            }
        }
        #endregion

        #region 07 Print numbers between 1 to N
        /*Write a program that prints on the console the numbers from 1 to N. 
         * The number N should be read from the standard input.*/
        public static void PrintNumbersUpTo()
        {
            Console.Write("Please enter a value for N: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.Write($"{i}, ");
                i++;
            }

        }



        #endregion

        #region 08 Print numbers between 1 and N which are not divisible with 3 and 7 simultaneous
        /*Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. 
         * The number N should be read from the standard input.*/
        public static void PrintNotDivisible()
        {
            Console.Write("Please enter a value for N: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if ((i % 3 != 0) || (i % 7 != 0))
                {
                    Console.Write($"{i}, ");
                }
                i++;
            }
        }
        #endregion

        #region 09 Read 5 integers and print minimum or maximum
        /*Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.*/
        public static void MinOrMaxOfFive()
        {
            int[] myArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Please enter number {i + 1} of 5: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Valoarea minima din array este: {myArray.Min()}\nValoarea maxima este {myArray.Max()}.");
        }
        #endregion

        #region 10 Draw a triangle from stars, using a user given size
        /*Write program that outputs a triangle made of stars with variable size, depending on an input parameter. 
         Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number. 
         The output is a series of lines printed on the console, forming a triangle of variable size.

                Input 2:   
                Output:    
                *   
                **
                *
                
                */
        public static void DrawTriangle()
        {
            Console.Write("Please enter the size: ");
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row < size; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int row = size; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region 11 Converts a given number from decimal to binary notation
        /*Write a program that converts a given number from decimal to binary notation (numeral system).*/
        public static void ConvertFromDecimalToBinary()
        {
            Console.Write("Please enter a decimal number: ");
            int number = int.Parse(Console.ReadLine());
            int tempNumber = number;
            string result = "";
            while (number > 1)
            {
                int remainder = number % 2;
                result = remainder.ToString() + result;
                number = number / 2;
            }
            result = number.ToString() + result;

            Console.WriteLine($"The decimal number {tempNumber}, converted to binary is: {result}");
        }

        #endregion

        #region 12 Print numbers between 1 and N in random order
        /*Write a program that by a given integer N prints the numbers from 1 to N in random order*/
        public static void PrintInRandomOrder()
        {
            Console.Write("Please enter a value for N: ");
            int numberN = int.Parse(Console.ReadLine());
            int[] myArray = new int[numberN];
            for (int i = 1; i <= numberN; i++)
            {
                myArray[i - 1] = i;
            }
            Random randNumber = new Random();
            for (int i = myArray.Length; i > 0; i--)
            {
                int j = randNumber.Next(i);
                int k = myArray[j];
                myArray[j] = myArray[i - 1];
                myArray[i - 1] = k;
            }
            foreach (var elem in myArray)
            {
                Console.Write($"{elem}, ");
            }
        }
        #endregion

        #region 13 FizzBuzz
        /* A program which iterates the integers from 1 to 50.
         For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
         For numbers which are multiples of both three and five print "FizzBuzz".

        Output : 
                fizzbuzz
                1
                2
                fizz
                4 
                buzz
        */
        public static void FizzBuzz()
        {
            int i = 1;
            while (i <= 50)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        #endregion

        #region 14 Program that reads information about the company and its manager and then prints it on the console
        /* A given company has name, address, phone number, fax number, web site and manager. 
        The manager has name, surname and phone number. Write a program that reads information about the company
        and its manager and then prints it on the console.*/
        public static void CompanyInfo()
        {
            StringBuilder companyInfo = new StringBuilder();
            Console.Write("Please enter the company name: ");
            companyInfo.Append($"Company:       {Console.ReadLine()} \n");
            Console.Write("Please enter the company address: ");
            companyInfo.Append($"Address:       { Console.ReadLine()} \n");
            Console.Write("Please enter the company phone number: ");
            companyInfo.Append($"Phone number:  { Console.ReadLine()} \n");
            Console.Write("Please enter the company fax number: ");
            companyInfo.Append($"Fax number:    { Console.ReadLine()} \n");
            Console.Write("Please enter the company website: ");
            companyInfo.Append($"Website:       { Console.ReadLine()} \n");
            Console.Write("Please enter the manager name: ");
            companyInfo.Append($"Manager:       { Console.ReadLine()} ");
            Console.Write("Please enter the manager surname: ");
            companyInfo.Append($"{ Console.ReadLine()} \n");
            Console.Write("Please enter the manager telephone number: ");
            companyInfo.Append($"Phone no:      { Console.ReadLine()} ");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(companyInfo);
            Console.WriteLine("****************************************************************************");
        }
        #endregion
    }
}
