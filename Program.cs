//See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
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

//int a = 45; int b = 70;
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

//int[] itemPrice = [460, 885, 1150, 225, 964, 870, 665, 750];

//foreach (var item in itemPrice)
//{
//    Console.WriteLine(item);
//}

//string[] countries = ["pak", "Iran", "China", "Afg", "Ban",];

// Array . sort(countries);
//Array.Reverse(countries);


//foreach (var country in countries)
//    Console.WriteLine(country);

//Console.WriteLine(Array.IndexOf(countries, "china");
//Console.WriteLine(Array.IndexOf(countries, "pak");

// <-- 20 oct tuesday -->

//int[,] multiArr =
//{
//    {56, 65},
//    {11, 22},
//    {33, 44},
//    {77, 88},
//    {43, 23},
//    {32, 35},
//    {98, 89}
//};

//Console.WriteLine(multiArr[5, 0]);

//  -- FOR LOOP -- 

//for (int i = 0; i < multiArr.GetLength(0); i++)
//{
//    for (int j = 0; j < multiArr.GetLength(1); j++)
//    {
//        Console.Write(multiArr[i, j] + " ");
//    }

//    Console.WriteLine();

//}

// <-- C# unintialized variable bool = ture , int = 0, str = null by de

// < -- math.power -->

//Console.WriteLine(Math.Pow(2, 3));

// <-- jagged array -->
// <-- size of sub array is not fixed -->

//string[][] skillSet =
//{
//    new string [6] {"HTML", "CSS", "JS", "Bootstrap","SEO", "UIUX" },
//    new string [5] {"MySQL", "PHP", "LARAVEL","CMS", "FME" },
//    new string [4] {"SQL SERVER", "C#","DOTNET", "Angular" },
//    new string [3] {"MongoDB", "ReactJS", "EXPRESSJS" },
//    new string [2] {"DART", "FLUTTER" }
//};

//Console.WriteLine(skillSet[2][2]);

//  <-- FOR LOOP -->

//for (int i = 0; i < skillSet.Length; i++)
//{
//    for (int j = 0; j < skillSet[i].Length; j++)
//    {
//        Console.WriteLine(skillSet[i][j]);
//    }
//}

// <-- FOREACH LOOP -->

//foreach (string[] skills in skillSet)
//{
//    foreach (string skill in skills)
//    {
//        Console.WriteLine(skill);
//    }
//}


// <-- FUNCTION IN C# -->

// <-- Return type funName() {body} -->

// <-- no return on parameter -->

// <-- void greet -->
//{
// console.writeLine("good afternoon 2509c2");
//}

// <-- calling -->
//greet();
//greet();
//greet();

// <-- no return with parameter 
//void Greet(string name)
//{
//    Console.WriteLine($"Hi, {name}, Good Afternoon!");
//}

// <-- Calling -->
//Greet("Humaira");
//Greet("Bisma");
//Greet("Iqra");

//  <-- return no parameter -->
//string greet()
//{
//    return "wellcome to our company!";
//}

// <-- calling -->
//Console.WriteLine(greet());

//int Add ()
//{
//    return 32 + 35; 
//}
//Console.WriteLine(Add());

/// <-- return with parameter -->

//string empDetails(string name , byte age)
//{
//    return ($"Employee name: {name}. \nEmployee age; {age}");
//}

//// <-- CALLING --> 


//Console.WriteLine(empDetails("Bisma", 16));

// <-- Data structure -->
// <-- collections -->
// <-- generic collection + database zaroor batni prhte hai | fixed data type  -->
// <-- list, stack, queen, dictionary  -->
// <-- methods -->
// <-- list: add, remove, contains, addrange,removerange -->


//List<string> SuperCars = new List<string>();
//SuperCars.Add("super");
//SuperCars.Add("Mark x");
//SuperCars.Add("BMW");
//SuperCars.Add("Audi");



//List<string> Cars = new List<string>();
//Cars.Add("Accord");
//Cars.Add("city");
//Cars.Add("Civic");
//Cars.Add("carolla");
//Cars.Add("cultus");

//Console.WriteLine(Cars[4]);
//Console.WriteLine(Cars.Count);
//Console.WriteLine(Cars.Contains("civic"));
//Console.WriteLine(Cars.Remove("cultus"));
//Cars.RemoveAt(0);


//Cars.AddRange(SuperCars);
//Cars.Insert(3, "bOSS");
//Cars.RemoveRange(1, 5);


//foreach (string Car in Cars)
//{
//    Console.WriteLine(Car);
//}


// <-- QUEUE ( FIFO : First in First Out ) -->
// <-- ENQUEUE : Add / Insert  -->

//Queue<string> stdNames = new Queue<string>();
//stdNames.Enqueue("Imran");
//stdNames.Enqueue("Hunzila");
//stdNames.Enqueue("Saqib");
//stdNames.Enqueue("Rayyan");
//stdNames.Enqueue("Ali");
//stdNames.Enqueue("Ali");
//stdNames.Enqueue("Nabeel");

//// <-- DEQUEUE : Remove / Delete -->
//stdNames.Dequeue(); // <-- DELETE 1  name imran -->
//stdNames.Dequeue(); //  <-- hunzila -->
//stdNames.Dequeue(); //  <-- saqib -->


//foreach ( var name in stdNames)
//{
//    Console.WriteLine(name);    
//}


// <-- STACK ( FIFO : LAST in First Out ) -->
// <-- PUSH : Add / Insert  -->

//Stack <string> birds = new Stack<string>();
//birds.Push("Electus");
//birds.Push("Amazan");
//birds.Push("Finch");
//birds.Push("Maccow");
//birds.Push("Love Birds");


// <-- POp : Remove / Delete -->
//birds.Pop();//    // <-- love birds delete -->


//foreach (var name in birds)
//{
//    Console.WriteLine(name);
//}

// <-- Dictionary(key : value ) -->
// <-- Add , remove -->

//Dictionary<string, string> empDetails = new Dictionary<string, string>();

//empDetails.Add("empName", "Haris");
//empDetails.Add("empDesignation", "DCAH");
//empDetails.Add("empAddress", "johar khi");
//empDetails.Add("empImg", "haris.jpg");
//empDetails.Add("empEmail", "haris@aptechnorth.adu.pk");
//empDetails.Add("empPass", "haris7778");

//Console.WriteLine(empDetails["empImg"]);

//foreach(var item in empDetails)
//{
//    Console.WriteLine(item.Key + " : " +  item.Value);
//}

//foreach (var item in empDetails)
//{
//    string[] test = (item.ToString().Split(','));
//    string key = test[0].Trim('[');
//    string value = test[1].Trim(']');
//    //string key = test[0];
//    //string value = test[1];

//    Console.WriteLine(key);
//    Console.WriteLine(value);
//    Console.WriteLine(item);

//    Console.WriteLine($"The employee has key property: {key} and value property: {value}");
//}

//Dictionary<string, int> Sub = new Dictionary<string, int>();

//Sub.Add("Maths", 100);
//Sub.Add("English", 80);
//Sub.Add("Computer", 95);
//Sub.Add("Urdu", 70);
//Sub.Add("Physics", 65);
//Sub.Add("Isl", 98);

//foreach (var s in Sub)
//{
//    Console.WriteLine(s.Key + " : " + s.Value);
//}


// <-- hashTable --> 

//Hashtable students = new Hashtable();
//students.Add("stdName", "Imran");
//students.Add("stdMarks", 89);
//students.Add("StdExamStatus", "Pass");
//students.Add("stdImg", "imran.jpg");
//students.Add("stdValid", true);
//Console.WriteLine(students["stdName"]);

// <-- 27-oct-Tuesady -->

//Console.WriteLine(students.Contains("stdMarks"));
//Console.WriteLine(students.ContainsValue(89));

//foreach (DictionaryEntry student in students)
//{
//    Console.WriteLine(student.Key + " : " + student.Value);
//}
//Console.WriteLine(students.GetHashCode());

// <-- NON-GENERIC Collection (No FIC DATATYPES) -->
// < -- ARRAYLIST -->

//ArrayList Cars = new ArrayList();
//Cars.Add("Civic");
//Cars.Add("Honda");
//Cars.Add(1800);
//Cars.Add(.70f);
//Cars.Add(true);

//Console.WriteLine(Cars.Count);
////Console.WriteLine(Cars.Contains("boss"));
//Cars.RemoveAt(3);


//foreach (var Car in Cars)
//{
//    Console.WriteLine(Car);
//}

// <-- String Methods

//string test = """{ "name" : "John Doe" } """;
//string test = "John Doe";

//string test = "we are learning  \"C#\"";

//Console.WriteLine(test);
//Console.WriteLine(test.Replace("learning", "Mastering"));

// <-- CODING BEST PRACTICES -->
// <-- Indentation (readable by using spaces and new linces ) .-->
// <-- Meaningful identifiers(variable
// <-- comments -->
// <-- errors ( exception handling) -->
// <-- less repeatation -->

// <-- OOP(Object oriented programming) -->




















