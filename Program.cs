//See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;

Console.WriteLine("Hello, World");

////DATATYPES
////String

//String userName = "Humaira";

//char bloodGroup = 'A';

//Console.WriteLine(userName + " " + bloodGroup);

////numbers

//byte age = 255;  //Max num 255

//int qaidiNo = 804;

//long largeNum = 1346577838829446L;

//float height  = 5.11F;

//double dNum = 990.7880;

//decimal deciNum = 778899.5687M;

////Boolean

//bool isValid = false;

// Print Output
//Console.WriteLine("Age: " + age);
//Console.WriteLine("Qaidi No: " + qaidiNo);
//Console.WriteLine("Large Number: " + largeNum);
//Console.WriteLine("Height: " + height);
//Console.WriteLine("Double Number: " + dNum);
//Console.WriteLine("Decimal Number: " + deciNum);
//Console.WriteLine("Is Valid: " + isValid);


//// Arithmetic Operators
//Console.WriteLine(66 + 45);
//Console.WriteLine(66 - 45);
//Console.WriteLine(66 * 45);
//Console.WriteLine(66 / 45);
//Console.WriteLine(66 % 45);

//Console.Write(" ");


//Assignment Operator
//int num = 12;

//Console.WriteLine(num += 4); //num + 4
//Console.WriteLine(num -= 4); //num - 4
//Console.WriteLine(num *= 4); //num * 4
//Console.WriteLine(num /= 4); //num / 4
//Console.WriteLine(num %= 4); //num % 4


//Comparison Operators

int a = 45; int b = 70;
//Console.WriteLine(a == b); //False
//Console.WriteLine(a != b); //True
//Console.WriteLine(a >= b); //False
//Console.WriteLine(a <= b); //True
//Console.WriteLine(a < b); //True
//Console.WriteLine(a > b); //False

// Logical Operators(AND &&, OR ||, NOT ! )
//AND
// True  True = True
// True  False = False
// False  True = False
// False  False = False

//Console.WriteLine(a <= b && a != b); // True
//Console.WriteLine(a >= b && a != b); // False

//OR
// True  True = True
// True  False = True
// False  True = True
// False  False = False

//Console.WriteLine(a <= b || a != b); // True
//Console.WriteLine(a >= b || a != b); // True
//Console.WriteLine(a >= b || a == b); // False

//NOT
//Console.WriteLine(a != b); //True
//Console.WriteLine(!(a == b)); //True
//Console.WriteLine(!(a != b)); //False


//do
//{
//    Console.WriteLine("Enter Salary (or type exit to close):");
//    string input = Console.ReadLine();

//    if (input.ToLower() == "exit")
//        break;

//    int salary = Int32.Parse(input);

//    if (salary > 90000 && !(salary >= 120000))
//    {
//        Console.WriteLine("Good Salary...");
//    }
//    else if (salary < 90000)
//    {
//        Console.WriteLine("Do you get fuel allowance? (or type exit to close)");
//        string answer = Console.ReadLine();

//        if (answer.ToLower() == "exit")
//            break;

//        answer = answer.ToLower();

//        if (answer == "yes" || answer == "y")
//        {
//            Console.WriteLine("Sounds Good");
//        }
//        else if (answer == "no" || answer == "n")
//        {
//            Console.WriteLine("Try to switch your job...");
//        }
//        else
//        {
//            Console.WriteLine("Please enter yes or no");
//        }
//    }
//    else
//    {
//        Console.WriteLine("MASHALLAH!");
//    }

//} while (true);

//// SWITCH 1 - 7 // Monday == 1, Tuesday ==2

//Console.WriteLine("Enter num b/w 1 to 7");
//int num = int32.Parse(Console.ReadLine());

//switch (num)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Invalid Num");
//        break;
//}

// string interpolation 

//int twentythree = 23;
//Console.WriteLine($"Ahsan age is {twentythree}");

// FOR LOOP 

//for( int i = 1; i <= twentythree; i ++)
//{
//    Console.WriteLine( i );

//}

//for (int i = 50; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

// -- ODD NUMS

//for (int i = 1; i <= 101; i++)
//{
//     if(i%2 != 0)

//{
//    Console.WriteLine(i);
//}
//}

// -- EVEN NUMS

//for (int i = 1; i <= 101; i++)
//{
//    if (i % 2 == 0)

//    {
//        Console.WriteLine(i);
//    }
//}

// -- PRIME NUMBER

// -- WHILE NUMBER

//while (twentythree < 25 )
//{
//    Console.WriteLine(twentythree);
//    twentythree++;
//}

// -- DO WHILE LOOP (Atleas 1 time excute it.)
//int j = 23;

//do
//{
//    Console.WriteLine("j");
//}
//while (j < 23);

// -- salary system 

//int num;

//char ans;

//do
//{
//    Console.WriteLine("Enter any number");
//    num = Convert.ToInt32(Console.ReadLine());

//    if(num % 2 == 0)
//    {
//        Console.WriteLine("Even Number");
//    }
//    else
//    {
//        Console.WriteLine("Odd Number");
//    }
//        Console.WriteLine("Do you want to continue? press Y");
//    ans = Convert.ToChar(Console.ReadLine());

//} while (ans == 'Y' || ans == 'y') ;

// -- Array fixed size

//int[] temperatures = new int[6];
//temperatures[0] = 23;
//temperatures[1] = 33;
//temperatures[2] = 40;
//temperatures[3] = 42;
//temperatures[4] = 16;
//temperatures[5] = 20;

//Console.WriteLine(temperatures[5]);

int[] itemPrice = [460, 885, 1150, 225, 964, 870, 665, 750];

foreach (var item in itemPrice)
{
    Console.WriteLine(item);
}

string[] countries = ["pak", "Iran", "China", "Afg", "Ban",];

// Array . sort(countries);
//Array.Reverse(countries);


//foreach (var country in countries)
//    Console.WriteLine(country);

// Console.WriteLine(Array.IndexOf(countries, "china");
// Console.WriteLine(Array.IndexOf(countries, "pak");























