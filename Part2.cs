using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestCSharpLab
{
    internal class Part2
    {
        ////Lab 1: Multiplication Table
        //Console.WriteLine("Enter a number");
        //int number = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Multiplication Table of {number}");
        //for (int i = 0; i < 100; i++)
        //{
        //    Console.WriteLine($"{number} * {i} = {number*i}");
        //}

        ////*******************************************************************

        ////Lab 2: Display right angled triangle
        //Console.WriteLine("Enter the number of rows: ");
        //int rows = Convert.ToInt32(Console.ReadLine());

        //for (int i = 1; i <= rows; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}

        ////******************************************************************

        ////Lab 3: Sum of all even numbers between 1 and 100

        //int number = 1;
        //int sum = 0;

        //while (number <= 100)
        //{
        //    if (number % 2 == 0)
        //    {
        //        sum += number;
        //    }
        //    number++;
        //}

        //Console.WriteLine($"Sum of all even numbers between 1 and 100 is: {sum}");

        ////******************************************************************

        ////Lab 4: Multiplication table from 1 to 5 

        //int num = 1;

        //while (num <= 5)
        //{
        //    int multiplier = 1;

        //    while (multiplier <= 10)
        //    {
        //        Console.WriteLine($"{num} x {multiplier} = {num * multiplier}");
        //        multiplier++;
        //    }

        //    Console.WriteLine();
        //    num++;
        //}

        ////******************************************************************

        ////Lab 5: Print a positive number

        //int number;

        //do
        //{
        //    Console.WriteLine("Enter a positive number (or a negative number to stop): ");
        //    number = Convert.ToInt32(Console.ReadLine());

        //    if (number >= 0)
        //    {
        //        Console.WriteLine($"You entered: {number}");
        //    }

        //} while (number >= 0);

        //Console.WriteLine("You entered a negative number. Exiting...");

        ////********************************************************************

        ////Lab 6: Create menu driven calculator

        //char choice;

        //do
        //{
        //    double num1, num2, result = 0;
        //    char operation;

        //    Console.WriteLine("Enter the first number: ");
        //    num1 = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Enter the second number: ");
        //    num2 = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Enter the operation (+, -, *, /): ");
        //    operation = Convert.ToChar(Console.ReadLine());

        //    switch (operation)
        //    {
        //        case '+':
        //            result = num1 + num2;
        //            break;
        //        case '-':
        //            result = num1 - num2;
        //            break;
        //        case '*':
        //            result = num1 * num2;
        //            break;
        //        case '/':
        //            result = num1 / num2;
        //            break;
        //        default:
        //            Console.WriteLine("Invalid operation.");
        //            break;
        //    }

        //    Console.WriteLine($"The result is: {result}");

        //    Console.WriteLine("Do you want to perform another calculation? (y/n): ");
        //    choice = Convert.ToChar(Console.ReadLine());

        //} while (choice == 'y' || choice == 'Y');

        //Console.WriteLine("Exiting calculator...");

        ////**************************************************************

        ////Lab 7:Print all numbers from 1 to 100
        //for (int i = 1; i <= 100; i++)
        //{
        //    if (i % 3 == 0)
        //    {
        //        continue; // Skip numbers divisible by 3
        //    }

        //    if (i > 50)
        //    {
        //        break; // Stop the loop if number exceeds 50
        //    }

        //    Console.WriteLine(i);
        //}

        //****************************************************************

        ////Lab 8: Sum of Odd Numbers

        //int sum = 0;

        //for (int i = 1; i <= 100; i += 2)
        //{
        //    sum += i;
        //}

        //Console.WriteLine($"The sum of odd numbers between 1 and 100 is: {sum}");

        ////********************************************************************
        ////Lab 9: Factorial Calculation 

        //Console.WriteLine("Enter a number to find its factorial: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int factorial = 1;
        //int i = 1;

        //while (i <= num)
        //{
        //    factorial *= i;
        //    i++;
        //}

        //Console.WriteLine($"Factorial of {num} is: {factorial}");

        ////*****************************************************************

        ////Lab 10: Number Pyramid 

        //Console.WriteLine("Enter the number of rows: ");
        //int rows = Convert.ToInt32(Console.ReadLine());
        //int i = 1;

        //while (i <= rows)
        //{
        //    int j = 1;
        //    while (j <= i)
        //    {
        //        Console.Write($"{i} ");
        //        j++;
        //    }
        //    Console.WriteLine();
        //    i++;
        //}

        ////**********************************************************

        ////Lab 11: Guess the Number Game

        //Random random = new Random();
        //char playAgain;

        //do
        //{
        //    int randomNumber = random.Next(1, 101);
        //    int guess;
        //    int attempts = 0;

        //    do
        //    {
        //        Console.WriteLine("Guess a number between 1 and 100: ");
        //        guess = Convert.ToInt32(Console.ReadLine());
        //        attempts++;

        //        if (guess > randomNumber)
        //        {
        //            Console.WriteLine("Too high!");
        //        }
        //        else if (guess < randomNumber)
        //        {
        //            Console.WriteLine("Too low!");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Correct! You guessed it in {attempts} attempts.");
        //        }

        //    } while (guess != randomNumber);

        //    Console.WriteLine("Do you want to play again? (y/n): ");
        //    playAgain = Convert.ToChar(Console.ReadLine());

        //} while (playAgain == 'y' || playAgain == 'Y');

        //Console.WriteLine("Thank you for playing!");

        ////**************************************************************

        ////Lab 12: Simple Calculator 

        //Console.WriteLine("Enter the first number: ");
        //double num1 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Enter the second number: ");
        //double num2 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Enter an operation (+, -, *, /): ");
        //char operation = Convert.ToChar(Console.ReadLine());

        //double result = 0;

        //switch (operation)
        //{
        //    case '+':
        //        result = num1 + num2;
        //        break;
        //    case '-':
        //        result = num1 - num2;
        //        break;
        //    case '*':
        //        result = num1 * num2;
        //        break;
        //    case '/':
        //        if (num2 != 0)
        //        {
        //            result = num1 / num2;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Division by zero is not allowed.");
        //            return;
        //        }
        //        break;
        //    default:
        //        Console.WriteLine("Invalid operation.");
        //        return;
        //}

        //Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");


        //////*************************************************************

        //Lab 13: Sum of Digits
        //Console.WriteLine("Enter a number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;

        //do
        //{
        //    sum += number % 10;
        //    number /= 10;
        //} while (number != 0);

        //Console.WriteLine($"The sum of the digits is: {sum}");

        //*******************************************************

        ////Lab 14: Finding the Largest Number 
        //int largest = int.MinValue;

        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"Enter number {i}: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (number > largest)
        //    {
        //        largest = number;
        //    }
        //}

        //Console.WriteLine($"The largest number is: {largest}");

        ////*******************************************************

        ////Lab 15: Sum of Squares

        //Console.WriteLine("Enter the upper limit: ");
        //int limit = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //int i = 1;

        //while (i <= limit)
        //{
        //    sum += i * i;
        //    i++;
        //}

        //Console.WriteLine($"The sum of squares from 1 to {limit} is: {sum}");

        ////******************************************************************

        ////Lab 16: Countdown Timer 

        //int count = 10;

        //do
        //{
        //    Console.WriteLine(count);
        //    count--;
        //    Thread.Sleep(1000); // Pause for 1 second
        //} while (count > 0);

        //Console.WriteLine("Countdown complete!");

        ////*****************************************************

        ////Lab 17: Finding the First Multiple of 5 Using break in a Loop

        //int[] numbers = { 3, 7, 11, 14, 16, 20, 22, 25 };

        //foreach (int number in numbers)
        //{
        //    if (number % 5 == 0)
        //    {
        //        Console.WriteLine($"First multiple of 5 is: {number}");
        //        break;
        //    }
        //}

        ////**************************************************************

        ////Lab 18: Print Non-Multiples of 3 Using continue in a Loop
        //for (int i = 1; i <= 20; i++)
        //{
        //    if (i % 3 == 0)
        //    {
        //        continue; // Skip numbers divisible by 3
        //    }

        //    Console.WriteLine(i);
        //}

        ////*********************************

        ////Lab 19: Checking for Palindrome Using while Loop  
        //Console.WriteLine("Enter a number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int temp = number, reverse = 0;

        //while (temp != 0)
        //{
        //    int remainder = temp % 10;
        //    reverse = reverse * 10 + remainder;
        //    temp /= 10;
        //}

        //if (number == reverse)
        //{
        //    Console.WriteLine($"{number} is a palindrome.");
        //}
        //else
        //{
        //    Console.WriteLine($"{number} is not a palindrome.");
        //}

        ////****************************************************************

        ////Lab 20: Average of Positive Numbers Using do-while Loop

        //int sum = 0, count = 0, number;

        //do
        //{
        //    Console.WriteLine("Enter a positive number (negative to stop): ");
        //    number = Convert.ToInt32(Console.ReadLine());

        //    if (number >= 0)
        //    {
        //        sum += number;
        //        count++;
        //    }

        //} while (number >= 0);

        //if (count > 0)
        //{
        //    double average = (double)sum / count;
        //    Console.WriteLine($"The average of the entered numbers is: {average}");
        //}
        //else
        //{
        //    Console.WriteLine("No positive numbers were entered.");
        //}

        ////********************************************************

        ////Lab 21: Reverse a Number Using do-while Loop

        //Console.WriteLine("Enter a number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int reverse = 0;

        //do
        //{
        //    int remainder = number % 10;
        //    reverse = reverse * 10 + remainder;
        //    number /= 10;
        //} while (number > 0);

        //Console.WriteLine($"Reversed number: {reverse}");

        //*******************************************************

        //: Menu-Driven String Operations 

        //Console.WriteLine("Enter a string: ");
        //string input = Console.ReadLine();

        //Console.WriteLine("Choose an operation:");
        //Console.WriteLine("1. Reverse the string");
        //Console.WriteLine("2. Convert to uppercase");
        //Console.WriteLine("3. Convert to lowercase");
        //Console.WriteLine("4. Find the length of the string");
        //char choice = Convert.ToChar(Console.ReadLine());

        //switch (choice)
        //{
        //    case '1':
        //        char[] charArray = input.ToCharArray();
        //        Array.Reverse(charArray);
        //        Console.WriteLine("Reversed string: " + new string(charArray));
        //        break;
        //    case '2':
        //        Console.WriteLine("Uppercase string: " + input.ToUpper());
        //        break;
        //    case '3':
        //        Console.WriteLine("Lowercase string: " + input.ToLower());
        //        break;
        //    case '4':
        //        Console.WriteLine("Length of the string: " + input.Length);
        //        break;
        //    default:
        //        Console.WriteLine("Invalid choice.");
        //        break;
        //}

        //*****************************************************

        //Lab 23: Skip Multiples of 4

        //for (int i = 1; i <= 50; i++)
        //{
        //    if (i % 4 == 0)
        //    {
        //        continue; // Skip multiples of 4
        //    }

        //    Console.WriteLine(i);
        //}
        //******************************************************

        ////Lab 24: Fibonacci Sequence 
        //int first = 0, second = 1, next;

        //Console.WriteLine("Fibonacci sequence: ");
        //Console.WriteLine(first);
        //Console.WriteLine(second);

        //for (int i = 3; i <= 10; i++)
        //{
        //    next = first + second;
        //    Console.WriteLine(next);

        //    first = second;
        //    second = next;
        //}

        ////****************************************************

        ////Lab 25: Find All Armstrong Numbers 
        //int number = 1;

        //while (number <= 500)
        //{
        //    int sumOfCubes = 0, temp = number;

        //    while (temp != 0)
        //    {
        //        int digit = temp % 10;
        //        sumOfCubes += digit * digit * digit;
        //        temp /= 10;
        //    }

        //    if (sumOfCubes == number)
        //    {
        //        Console.WriteLine($"{number} is an Armstrong number.");
        //    }

        //    number++;
        //}
        ////***************************************************
        ///
        ////Lab 26: Menu-Driven Number System Conversion 
        //Console.WriteLine("Choose an option:");
        //Console.WriteLine("1. Binary to Decimal");
        //Console.WriteLine("2. Decimal to Binary");
        //Console.WriteLine("3. Decimal to Hexadecimal");
        //int choice = Convert.ToInt32(Console.ReadLine());

        //switch (choice)
        //{
        //    case 1:
        //        Console.WriteLine("Enter a binary number: ");
        //        string binary = Console.ReadLine();
        //        int decimalValue = Convert.ToInt32(binary, 2);
        //        Console.WriteLine($"Decimal: {decimalValue}");
        //        break;

        //    case 2:
        //        Console.WriteLine("Enter a decimal number: ");
        //        int decimalNum = Convert.ToInt32(Console.ReadLine());
        //        string binaryValue = Convert.ToString(decimalNum, 2);
        //        Console.WriteLine($"Binary: {binaryValue}");
        //        break;

        //    case 3:
        //        Console.WriteLine("Enter a decimal number: ");
        //        int decimalNumber = Convert.ToInt32(Console.ReadLine());
        //        string hexValue = Convert.ToString(decimalNumber, 16);
        //        Console.WriteLine($"Hexadecimal: {hexValue.ToUpper()}");
        //        break;

        //    default:
        //        Console.WriteLine("Invalid option");
        //        break;
        //}


        ////************************************************************

        ////Lab 27: Reverse a String 

        //Console.WriteLine("Enter a string: ");
        //string input = Console.ReadLine();
        //string reversed = "";

        //for (int i = input.Length - 1; i >= 0; i--)
        //{
        //    reversed += input[i];
        //}

        //Console.WriteLine($"Reversed string: {reversed}");

        ////*********************************************************

        ////Lab 28: Count Vowels and Consonants in a String 
        //Console.WriteLine("Enter a string: ");
        //string input = Console.ReadLine().ToLower();
        //int vowels = 0, consonants = 0;

        //for (int i = 0; i < input.Length; i++)
        //{
        //    if ("aeiou".Contains(input[i]))
        //    {
        //        vowels++;
        //    }
        //    else if (char.IsLetter(input[i]))
        //    {
        //        consonants++;
        //    }
        //}

        //Console.WriteLine($"Vowels: {vowels}");
        //Console.WriteLine($"Consonants: {consonants}");

        ////**********************************************************

        ////Lab 29: Find Maximum and Minimum 

        //int max = int.MinValue;
        //int min = int.MaxValue;
        //int number;

        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.WriteLine($"Enter number {i}: ");
        //    number = Convert.ToInt32(Console.ReadLine());

        //    if (number > max)
        //    {
        //        max = number;
        //    }

        //    if (number < min)
        //    {
        //        min = number;
        //    }
        //}

        //Console.WriteLine($"Maximum: {max}");
        //Console.WriteLine($"Minimum: {min}");

        ////******************************************************************

        //Console.WriteLine("Enter a number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int count = 0;

        //while (number != 0)
        //{
        //    number /= 10;
        //    count++;
        //}

        //Console.WriteLine($"The number of digits is: {count}");

        //*************************************************************

    }
}
