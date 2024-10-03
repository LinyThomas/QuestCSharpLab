using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestCSharpLab
{
    internal class Part1
    {
        public void Assignments()
        {
            ///Lab 1: Hello, World! and Basic Input/output

            //// Task 1: Print "Hello, World!"
            //Console.WriteLine("Hello, World!");

            //// Task 2: Personalized greeting
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, " + name + "!");
            ////***************************************************************************

            ////Lab 2: Input/output with Strings

            //Console.Write("Enter your full name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Hello, {name}! You are {age} years old.");

            //// Task 2: Ask for favorite color
            //Console.Write("What is your favorite color? ");
            //string color = Console.ReadLine();

            //Console.WriteLine($"Nice to meet you, {name}. I see your favorite color is {color}!");
            ////***********************************************************************************

            //// Lab3: : Input/output with Arithmetic Operations
            //Console.Write("Enter the first number: ");
            //double number1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //double number2 = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Sum: {number1 + number2}");
            //Console.WriteLine($"Difference: {number1 - number2}");
            //Console.WriteLine($"Product: {number1 * number2}");

            //// Task 2: Check for division by zero
            //if (number2 != 0)
            //{
            //    Console.WriteLine($"Quotient: {number1 / number2}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Division by zero is not allowed.");
            //}
            ////*****************************************************************************

            ////Lab 4: Temperature Conversion

            //Console.Write("Enter temperature in Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());

            //// Convert Celsius to Fahrenheit
            //double fahrenheit = (celsius * 9 / 5) + 32;

            //Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");

            ////***************************************************************************

            ////Lab 5: Simple Interest Calculation

            //Console.Write("Enter the principal amount: ");
            //double principal = double.Parse(Console.ReadLine());

            //Console.Write("Enter the rate of interest: ");
            //double rate = double.Parse(Console.ReadLine());

            //Console.Write("Enter the time in years: ");
            //double time = double.Parse(Console.ReadLine());

            //// Calculate simple interest
            //double simpleInterest = (principal * rate * time) / 100;

            //Console.WriteLine($"The simple interest is: {simpleInterest:F2}");

            ////******************************************************************************

            ////Lab 6: Calculating the Area of a Circle

            //const double PI = 3.14159;

            //Console.Write("Enter the radius of the circle: ");
            //double radius = double.Parse(Console.ReadLine());

            //// Calculate area
            //double area = PI * radius * radius;

            //Console.WriteLine($"The area of the circle is: {area:F2}");

            ////***********************************************************************************
            //Lab 7: Input/output with Time Calculation

            //Console.Write("Enter the number of seconds: ");
            //int totalSeconds = int.Parse(Console.ReadLine());

            //// Calculate hours, minutes, and remaining seconds

            // int hours = totalSeconds / 3600;
            // int minutes = (totalSeconds % 3600) / 60;
            // int seconds = totalSeconds % 60;

            //Console.WriteLine($"{hours} hours, {minutes} minutes, and {seconds} seconds.");

            ////***************************************************************************

            ////Lab 8:String Length and Character Count

            //Console.Write("Enter a string: ");
            // string input = Console.ReadLine();

            // // Remove spaces and calculate the length
            // string trimmedInput = input.Replace(" ", "");
            // int length = trimmedInput.Length;

            //Console.WriteLine($"The number of characters (excluding spaces) is: {length}");

            ////****************************************************************************

            ////Lab 9: Body Mass Index (BMI) Calculator

            //double weight = 70.0;  // in kilograms
            //double height = 1.75;  // in meters

            //double bmi = weight / (height * height);

            //Console.WriteLine($"The BMI is {bmi}");

            ////**************************************************************************************

            ////Lab 10: Variables and Constants

            //int age = 25;
            //float temperature = 98.6f;
            //const double pi = 3.14159;
            //char grade = 'A';
            //string name = "John";
            //bool isStudent = true;

            //Console.WriteLine($"Age: {age} (int)");
            //Console.WriteLine($"Temperature: {temperature} (float)");
            //Console.WriteLine($"Pi: {pi} (double)");
            //Console.WriteLine($"Grade: {grade} (char)");
            //Console.WriteLine($"Name: {name} (string)");
            //Console.WriteLine($"Is Student: {isStudent} (bool)");

            ////******************************************************************************

            //Lab 11: Calculate Area of Circle & Rectangle

            //const double Pi = 3.14159;

            //// Circle area
            //Console.WriteLine("Enter the radius of the circle: ");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //double areaCircle = Pi * radius * radius;
            //Console.WriteLine("Area of the circle: " + areaCircle);

            //// Rectangle area
            //Console.WriteLine("Enter the length of the rectangle: ");
            //double length = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the width of the rectangle: ");
            //double width = Convert.ToDouble(Console.ReadLine());
            //double areaRectangle = length * width;
            //Console.WriteLine("Area of the rectangle: " + areaRectangle);

            ////**********************************************************************************

            ////Lab 12: Using Constants

            //const double PI = 3.14159;
            //const int DAYS_IN_WEEK = 7;
            //double radius = 5.0;
            //double circumference = 2 * PI * radius;

            //Console.WriteLine($"The circumference of the circle with radius {radius} is {circumference}");
            //Console.WriteLine($"There are {DAYS_IN_WEEK} days in a week.");

            ////***************************************************************************

            ////Lab 13: Calculating Area of Rectangle

            // const double INCH_TO_CM = 2.54;
            // double width = 10.0;  // in inches
            // double height = 5.0;  // in inches

            // double areaInInches = width * height;
            // double areaInCm = areaInInches * (INCH_TO_CM * INCH_TO_CM);

            //Console.WriteLine($"Area in square inches: {areaInInches}");
            //Console.WriteLine($"Area in square centimeters: {areaInCm}");

            ////***************************************************************************************

            ////Lab 14: C# Coding Standards

            //// Declare variables
            //string employeeName = "Alice Johnson";
            //int employeeAge = 30;
            //double monthlySalary = 4000.00;

            //// Display employee details
            //Console.WriteLine("Employee Name: " + employeeName);
            //Console.WriteLine("Employee Age: " + employeeAge);
            //Console.WriteLine("Monthly Salary: $" + monthlySalary);

            ////********************************************************************************
            
////Lab 15: C# Coding Standards

            ////Provided Code:
            //int num1 = 5;
            //int num2 = 3;
            //Console.WriteLine(num1 + num2);

            ////Refactored Solution:
            //// Declare two integer variables
            //int firstNumber = 5;
            //int secondNumber = 3;

            //// Calculate and display the sum
            //Console.WriteLine("Sum: " + (firstNumber + secondNumber));

            ////*********************************************************************************


            ////Lab 16: Assignment Operator

            //int a = 5;
            //double b = 10.5;
            //string text = "Hello, C#";

            //Console.WriteLine("Integer a = " + a);
            //Console.WriteLine("Double b = " + b);
            //Console.WriteLine("Text = " + text);

            ////***********************************************************************

            ////Lab 17: Find the Power of a Number

            //// Get base and exponent from the user
            //Console.Write("Enter the base number: ");
            //double baseNumber = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //double exponent = Convert.ToDouble(Console.ReadLine());

            //// Calculate the power
            //double result = Math.Pow(baseNumber, exponent);

            //// Display the result
            //Console.WriteLine($"\n{baseNumber} raised to the power of {exponent} = {result}");

            ////********************************************************************************

            ////Lab 18: Check Voting Eligibility

            //// Get age and citizenship status from the user
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Are you a citizen? (yes/no): ");
            //string citizenship = Console.ReadLine().ToLower();

            //// Check eligibility using relational and logical operators
            //bool isEligible = (age >= 18) && (citizenship == "yes");

            //// Display the result
            //if (isEligible)
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}

            ////**********************************************************************************

            ////Lab 19: Determine if a Person is Eligible for a Loan

            //// Get input from the user
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter your yearly income: ");
            //double income = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Do you have any outstanding loans? (yes/no): ");
            //string outstandingLoan = Console.ReadLine().ToLower();

            //// Check loan eligibility using relational and logical operators
            //bool isEligible = (age >= 21) && (income >= 30000) && (outstandingLoan == "no");

            //// Display the result
            //if (isEligible)
            //{
            //    Console.WriteLine("You are eligible for a loan.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for a loan.");
            //}

            ////************************************************************************************

            ////Lab 20: Grade Classification

            //Console.Write("Enter your percentage score: ");
            //double percentage = Convert.ToDouble(Console.ReadLine());

            //// Determine the grade using relational and logical operators
            //string grade;
            //if (percentage >= 90)
            //    grade = "A";
            //else if (percentage >= 80)
            //    grade = "B";
            //else if (percentage >= 70)
            //    grade = "C";
            //else if (percentage >= 60)
            //    grade = "D";
            //else
            //    grade = "F";

            //// Display the grade
            //Console.WriteLine($"\nYour grade is: {grade}");

            ////*********************************************************************************

            ////Lab 21: Check if a Character is a Vowel or Consonant

            //Console.Write("Enter a character: ");
            //char ch = Char.ToLower(Console.ReadKey().KeyChar);

            //// Check if the character is a vowel using logical OR
            //bool isVowel = (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');

            //// Display the result
            //if (isVowel)
            //{
            //    Console.WriteLine($"\n{ch} is a vowel.");
            //}
            //else
            //{
            //    Console.WriteLine($"\n{ch} is a consonant.");
            //}

            ////********************************************************************************


            ////Lab 22: Check If a Number is Positive, Negative, or Zero

            //// Get input from the user
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //// Check if the number is positive, negative, or zero using relational operators
            //if (num > 0)
            //{
            //    Console.WriteLine($"{num} is positive.");
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine($"{num} is negative.");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is zero.");
            //}

            ////********************************************************************************
            ////Lab 23: Check if a Number is Divisible by 5 and 11


            //// Get a number from the user
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //// Check if the number is divisible by both 5 and 11
            //if (num % 5 == 0 && num % 11 == 0)
            //{
            //    Console.WriteLine($"{num} is divisible by both 5 and 11.");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is not divisible by both 5 and 11.");
            //}

            ////*************************************************************************

            ////Lab 24: Simple Calculator

            //// Get two numbers from the user
            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //// Get the operator from the user
            //Console.Write("Enter an operator (+, -, *, /): ");
            //char op = Console.ReadLine()[0];

            //// Perform the operation based on the operator
            //if (op == '+')
            //{
            //    Console.WriteLine($"Result: {num1 + num2}");
            //}
            //else if (op == '-')
            //{
            //    Console.WriteLine($"Result: {num1 - num2}");
            //}
            //else if (op == '*')
            //{
            //    Console.WriteLine($"Result: {num1 * num2}");
            //}
            //else if (op == '/')
            //{
            //    // Check if the divisor is not zero
            //    if (num2 != 0)
            //    {
            //        Console.WriteLine($"Result: {num1 / num2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Division by zero is not allowed.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator.");
            //}
            ////**************************************************************************

            ////Lab 25: Find Whether a Character is a Vowel or Consonant

            //// Get a character from the user
            //Console.Write("Enter a character: ");
            //char ch = Char.ToLower(Console.ReadKey().KeyChar);

            //// Check if the character is a vowel or consonant
            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("\nThe character is a vowel.");
            //}
            //else if (Char.IsLetter(ch))
            //{
            //    Console.WriteLine("\nThe character is a consonant.");
            //}
            //else
            //{
            //    Console.WriteLine("\nInvalid input. Please enter a letter.");
            //}

            ////***************************************************************

            ////Lab 26: Swap two values
            ////Solution 1 (With a Third Variable):
            //int a = 5, b = 10, temp;

            //// Swap using third variable
            //temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine("After swapping: a = " + a + ", b = " + b);
            ////Solution 2 (Without a Third Variable):
            //static void Main()
            //{
            //    int a = 5, b = 10;

            //    // Swap without third variable
            //    a = a + b;
            //    b = a - b;
            //    a = a - b;

            //    Console.WriteLine("After swapping: a = " + a + ", b = " + b);
            //}
            ////***************************************************************************

            ////Lab 27: Perform Arithmetic Operations
            //Console.WriteLine("Enter the first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //// Perform arithmetic operations
            //Console.WriteLine("Addition: " + (num1 + num2));
            //Console.WriteLine("Subtraction: " + (num1 - num2));
            //Console.WriteLine("Multiplication: " + (num1 * num2));
            //Console.WriteLine("Division: " + (num1 / num2));
            //Console.WriteLine("Modulus: " + (num1 % num2));

            //// Increment and decrement operations
            //num1++;
            //num2--;
            //Console.WriteLine("After increment, num1 = " + num1);
            //Console.WriteLine("After decrement, num2 = " + num2);

            ////************************************************************************************

            ////Lab 28: Find the Average of Three Numbers

            //// Get three numbers from the user
            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the third number: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());

            //// Calculate the average
            //double average = (num1 + num2 + num3) / 3;

            //// Display the result with two decimal places
            //Console.WriteLine($"\nThe average of the three numbers is: {average:F2}");

            ////*********************************************************************************

            ////Lab 29: Currency Conversion

            //// Assume conversion rate (1 USD = 0.85 EUR)
            //double conversionRate = 0.85;

            //// Get the amount in USD from the user
            //Console.Write("Enter the amount in USD: ");
            //double amountUSD = Convert.ToDouble(Console.ReadLine());

            //// Convert to EUR
            //double amountEUR = amountUSD * conversionRate;

            //// Display the result
            //Console.WriteLine($"\nAmount in EUR: {amountEUR:F2}");

            ////*****************************************************************************

            ////Lab 30: Input is within a range

            //Console.WriteLine("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //// Relational and logical operators
            //if (num >= 1 && num <= 100)
            //{
            //    Console.WriteLine(num + " is within the range of 1 to 100.");
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine(num + " is even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(num + " is odd.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(num + " is out of the range of 1 to 100.");
            //}

            ////****************************************************************************

            ////Lab 31: Check a number is divisible by 3 & 5

            //Console.WriteLine("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine(num + " is divisible by both 3 and 5.");
            //}

            ////**************************************************************

            ////Lab 32: Check whether a given year is leap year

            //Console.WriteLine("Enter a year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //if (year % 4 == 0)
            //{
            //    if (year % 100 == 0)
            //    {
            //        if (year % 400 == 0)
            //        {
            //            Console.WriteLine(year + " is a leap year.");
            //        }
            //        else
            //        {
            //            Console.WriteLine(year + " is not a leap year.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(year + " is a leap year.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(year + " is not a leap year.");
            //}

            ////******************************************************************************
            ///
            ////Lab 33: Check whether a number is positive, even and greater than 50

            //Console.WriteLine("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num > 0)
            //{
            //    if (num % 2 == 0)
            //    {
            //        if (num > 50)
            //        {
            //            Console.WriteLine(num + " is positive, even, and greater than 50.");
            //        }
            //        else
            //        {
            //            Console.WriteLine(num + " is positive and even but not greater than 50.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(num + " is positive but odd.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(num + " is not positive.");
            //}

            ////***************************************************************

            ////Lab 34: Calculate student grade

            //// Get marks for three subjects from the user
            //Console.WriteLine("Enter marks for Subject 1: ");
            //int subject1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter marks for Subject 2: ");
            //int subject2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter marks for Subject 3: ");
            //int subject3 = Convert.ToInt32(Console.ReadLine());

            //// Check if the student has passed all subjects
            //if (subject1 >= 40 && subject2 >= 40 && subject3 >= 40)
            //{
            //    // Calculate average & grade
            //    double average = (subject1 + subject2 + subject3) / 3.0;
            //    Console.WriteLine("Student has passed all subjects.");

            //    // Check for distinction
            //    if (average >= 70)
            //    {
            //        Console.WriteLine("Distinction with an average of " + average);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Average grade: " + average);
            //    }
            //}
            //else
            //{
            //    // If the student has failed, count the number of failed subjects
            //    int failedSubjects = 0;

            //    if (subject1 < 40)
            //    {
            //        failedSubjects++;
            //    }
            //    if (subject2 < 40)
            //    {
            //        failedSubjects++;
            //    }
            //    if (subject3 < 40)
            //    {
            //        failedSubjects++;
            //    }

            //    Console.WriteLine("Student has failed in " + failedSubjects + " subject(s).");
            //}


            ////*******************************************************************

            ////Lab 35: Salary and Tax Calculation 

            //// Input: Salary and age of the employee
            //Console.WriteLine("Enter your annual salary: ");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //double tax = 0;

            //// Check if the salary is above the tax-free limit
            //if (salary >= 10000)
            //{
            //    // If salary is between $10,000 and $50,000
            //    if (salary <= 50000)
            //    {
            //        tax = salary * 0.10; // 10% tax
            //    }
            //    // If salary is above $50,000
            //    else
            //    {
            //        tax = salary * 0.20; // 20% tax
            //    }

            //    // Check if the person is a senior citizen (age 60 or above)
            //    if (age >= 60)
            //    {
            //        Console.WriteLine("As a senior citizen, you get a $5,000 exemption.");
            //        double taxableIncome = salary - 5000;
            //        if (taxableIncome < 0)
            //        {
            //            tax = 0;
            //        }
            //        else
            //        {
            //            if (salary <= 50000)
            //            {
            //                tax = taxableIncome * 0.10;
            //            }
            //            else
            //            {
            //                tax = taxableIncome * 0.20;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Your calculated tax is: $" + tax);

            ////*******************************************************************
            /*
            //using variables
            int age = 25;
            float temperature = 98.6f;
            double pi = 3.14159;
            char grade = 'A';
            string name = "John";
            bool isStudent = true;

            Console.WriteLine($"Age: {age} (int)");
            Console.WriteLine($"Temperature: {temperature} (float)");
            Console.WriteLine($"Pi: {pi} (double)");
            Console.WriteLine($"Grade: {grade} (char)");
            Console.WriteLine($"Name: {name} (string)");
            Console.WriteLine($"Is Student: {isStudent} (bool)");

            //using constants

            const double PI = 3.14159;
            const int DAYS_IN_WEEK = 7;
            double radius = 5.0;
            double circumference = 2 * PI * radius;

            Console.WriteLine($"The circumference of the circle with radius {radius} is {circumference}");
            Console.WriteLine($"There are {DAYS_IN_WEEK} days in a week.");

            //swap wo variables

            int a = 5;
            int b = 10;

            Console.WriteLine($"Before swap: a = {a}, b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After swap: a = {a}, b = {b}");
            /*
            //Calculating Area of Rectangle

            const double INCH_TO_CM = 2.54;
            double width = 10.0;  // in inches
            double height = 5.0;  // in inches

            double areaInInches = width * height;
            double areaInCm = areaInInches * (INCH_TO_CM * INCH_TO_CM);

            Console.WriteLine($"Area in square inches: {areaInInches}");
            Console.WriteLine($"Area in square centimeters: {areaInCm}");

            //Simple Interest Calculation

            double principal = 1000.0;
            double rate = 5.0;  // in percentage
            int time = 2;  // in years

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine($"Simple Interest for Principal {principal}, Rate {rate}%, and Time {time} years is: {simpleInterest}");

            //Temperature Conversion (Celsius to Fahrenheit)
            double celsius = 25.0;
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");

            //Average of Three Numbers

            int num1 = 15;
            int num2 = 20;
            int num3 = 25;

            double average = (num1 + num2 + num3) / 3.0;

            Console.WriteLine($"The average of {num1}, {num2}, and {num3} is {average}");

            // Compound Interest Calculation

            double principal1 = 1000.0;
            double rate1 = 0.05;  // 5% annual interest
            int time1 = 5;  // in years
            int compoundingsPerYear = 4;  // quarterly

            double amount = principal * Math.Pow(1 + (rate / compoundingsPerYear), compoundingsPerYear * time);

            Console.WriteLine($"Total amount after {time} years: {amount}");

            //Calculate Perimeter and Area of a Rectangle

            double length1 = 10.0;
            double width1 = 5.0;

            double perimeter = 2 * (length1 + width1);
            double area = length1 * width1;

            Console.WriteLine($"Perimeter of the rectangle is {perimeter}");
            Console.WriteLine($"Area of the rectangle is {area}");

            //Body Mass Index (BMI) Calculator

            double weight1 = 70.0;  // in kilograms
            double height1 = 1.75;  // in meters

            double bmi = weight1 / (height1 * height1);

            Console.WriteLine($"The BMI is {bmi}");

            //Calculate Time in Minutes and Seconds

            int totalSeconds = 367;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            Console.WriteLine($"{totalSeconds} seconds is equal to {minutes} minutes and {seconds} seconds");

            //Distance Between Two Points (2D)

            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = 4.0;
            double y2 = 6.0;

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"The distance between the two points is {distance}");

            //Circle Calculations

            const double PI1 = 3.14159;
            double radius1 = 7.5;

            double circumference1 = 2 * PI1 * radius1;
            double area1 = PI1 * Math.Pow(radius1, 2);

            Console.WriteLine($"Circumference of the circle is {circumference1}");
            Console.WriteLine($"Area of the circle is {area1}");
            */
        }
    }
}
