using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Square
    {
        static void Main(string[] args)
        {
            /* SR2
            //Creating a square shape create with use of and
            Console.WriteLine("This is a Square shape created with C#");
            Console.WriteLine(" ______");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|______|");
            Console.ReadLine(); 
                          
            //Creating a triangle shape create with use of and
            Console.WriteLine("This is a Square shape created with C#");
            Console.WriteLine("    /\\    ");
            Console.WriteLine("   /  \\   ");
            Console.WriteLine("  /    \\  ");
            Console.WriteLine(" /      \\ ");
            Console.WriteLine("/________\\");
            Console.ReadLine(); 

            //Creating a square shape create with use of and
            Console.WriteLine("This is a Square shape created with C#");
            Console.WriteLine(" ___________");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|___________|");
            Console.ReadLine(); 
                         
            //Creating a right-angle triangle with use of | \ _
            Console.WriteLine("THis is a right-angle triangle created with C#");
            Console.WriteLine("|\\");
            Console.WriteLine("| \\");
            Console.WriteLine("|  \\");
            Console.WriteLine("|___\\");
            Console.ReadLine();*/



            /* SR3
            //First day experience at Techtorium
            Console.WriteLine("My First Day at Techtorium");
            Console.WriteLine("");
            Console.WriteLine("In all honestly I didnt know what to expect on my first day. As I hadn't been to school" +
            "since 2008 it was nerve wrecking at first. After getting to know some of the boys and that we all at TechTorium" +
            "to learn as we didnt know much about Software Development, it was reasurring that other were in the same boat as I.");
            Console.ReadLine();*/



            /* SR4
            //Confidence rating from 1-10
            /*int a, b, c, d, e, f, g, h, i, j;
            a = 1; b = 2; c = 3; d = 4; e = 5; f = 6; g= 7; h = 8; i = 9; j = 10;

            //Confidence rating from 1-10
            Console.WriteLine("Rating myself on the following traits!");
            Console.WriteLine("");
            Console.WriteLine("My confidence:" + h);
            Console.ReadLine();*/



            /* SR5
            string name = " Ciaran Cain";
            string highSchool = " Sancta Maria College";
            int studentlD = 846500688;
            string trainersName = " Beerinder Singh";
            int mobile = 0276104614; 
            string hobbies = " playing video games, building computers 8 watching movies.";

            //Gathering details on the person sitting next to me
            Console.WriteLine("Gathering details on the fellow student sitting next to me!");
            Console.WriteLine("");
            Console.WriteLine("Students Name:" + name);
            Console.WriteLine("Students High School:" + highSchool);
            Console.WriteLine("Students Techtorium ID: " + studentlD);
            Console.WriteLine("Students Trainer Name:" + trainersName);
            Console.WriteLine("Students Contact Number:" + mobile);
            Console.WriteLine("Students Hobbies: " + hobbies); 
            Console.ReadLine();*/



            /* SR6
            //Checking if student sitting to me is elder or younger than me
           
            Console.WriteLine("Checking if student sitting to me is elder than I or not!\n\n");

            Console.WriteLine("Richard enter your age:");
            int richardAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Cairan enter your age:");
            int cairanAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(richardAge > cairanAge);
            Console.ReadLine(); */



            /* SR7
            //Checking if one is eligible to vote or not
            int vote_age;
            Console.WriteLine("Checking if one is old enough to vote or not.");
            Console.Write("\n\n\n");
            Console.Write("Find out now if you are eligible to case a vote:\n");
            Console.Write("__________________________________________________");
            Console.Write("\n\n");


            Console.Write("Please enter your age : ");
            vote_age = Convert.ToInt32(Console.ReadLine());

            if (vote_age < 18)
            {
                Console.Write("\n\n");
                Console.Write("Sorry, You are currently not eligible to vote.\n");
                Console.Write("You will be able to vote {0} year(s) from now.\n\n", 18 - vote_age);
            }
            else
                Console.Write("\n\nCongratulations! You are eligible for casting your vote.");

            Console.ReadLine();*/



            /* SR8
            //Checking entered number is positive or negative
            Console.WriteLine("Checking entered number is positive or negative.\n\n");

            Console.WriteLine("Please enter a random number: ");      
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number > 0)
            {
                Console.WriteLine("The number you have entered is a positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine("This number is nor postive or negative.");
            }
            else
            {
                Console.WriteLine("The number you have entered is negative.");
            }
            Console.ReadLine();*/



            /* SR9 
             //Age difference between David and Luke
             Console.WriteLine("Who is older - David or Luke.\n\n");

             Console.WriteLine("David enter your age:");
             int davidAge = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("\n");

             Console.WriteLine("Luke enter your age:");
             int lukeAge = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("\n");

             if (davidAge > lukeAge)
             {
                 Console.WriteLine("David is older by " + (davidAge - lukeAge) + " years.");
             }
             else if (davidAge == lukeAge)
             {
                 Console.WriteLine("You are both the same age.");
             }
             else  
             {
                 Console.WriteLine("David is younger.");
             }
             Console.ReadLine();*/



            /* SR10
            //Number check - odd or even
             Console.WriteLine("Checking if entered number is odd or even.\n\n");

             Console.WriteLine("Please enter a random number: ");

             int num = Convert.ToInt32(Console.ReadLine());

             if (num % 2 == 0)
             {
                 Console.WriteLine("Number you have entered is even");
             }      
             else
             {
                 Console.WriteLine("Number you have entered is odd");
             }
             Console.ReadLine();*/



            /* SR 11
            Console.WriteLine("Student Grades based on achieved grades");
            Console.WriteLine("_______________________________________\n\n");

            Console.WriteLine("Enter the number of students: ");
            int numOfStudents = int.Parse(Console.ReadLine());

            string[] names = new string[numOfStudents];
            int[] marks = new int[numOfStudents];
            string[] grades = new string[numOfStudents];

            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine("Enter the name of student " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
                Console.WriteLine("Enter the marks for " + names[i] + ": ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numOfStudents; i++)
            {
                int mark = marks[i] / 5;
                switch (mark)
                {
                    case 10:
                        grades[i] = "A+";
                        break;
                    case 9:
                        grades[i] = "A";
                        break;
                    case 8:
                        grades[i] = "A-";
                        break;
                    case 7:
                        grades[i] = "B+";
                        break;
                    case 6:
                        grades[i] = "B";
                        break;
                    case 5:
                        grades[i] = "B-";
                        break;
                    case 4:
                        grades[i] = "C+";
                        break;
                    case 3:
                        grades[i] = "C";
                        break;
                    case 2:
                        grades[i] = "C-";
                        break;
                    default:
                        grades[i] = "F";
                        break;
                }
            }

            Console.WriteLine("Grades:");
            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine(names[i] + ": " + grades[i]);
            }
            Console.ReadLine(); */



            /* SR 12
            Console.WriteLine(" Building a basic calculator:");
            Console.WriteLine("_____________________________\n\n");

            Console.WriteLine("Please enter first number(s): ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Enter an arithemic/operator (+, -, *, /): ");
            string arithemic = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Please enter second number(s): ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            double result;

            switch (arithemic)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Answer = " + result);
                    Console.ReadLine();
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Answer = " + result);
                    Console.ReadLine();
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Answer = " + result);
                    Console.ReadLine();
                    break;
                case "/":
                    if (num2 == 0)
                        Console.WriteLine("Cannot divide by zero");
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Answer = " + result);
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    Console.ReadLine();
                    break;
            } */


            /* SR 13
            //Adding the digits of numbers given
            Console.WriteLine("Tallying the numbers entered by user(s)");
            Console.WriteLine("_______________________________________\n\n");

            Console.WriteLine("Please enter a two or more numbers: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine("The total of the digits entered is: " + sum);
            Console.ReadLine(); */



            /* SR 14
            Console.WriteLine("Swaping the numbers entered by user(s)");
            Console.WriteLine("______________________________________\n\n");

            Console.WriteLine("Please enter two or more numbers: ");
            int number = int.Parse(Console.ReadLine());
            int reversedNumber = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number /= 10;
            }

            Console.WriteLine("\nThe numbers entered switch around is: " + reversedNumber);
            Console.ReadLine(); */



            /* SR 15
            Console.WriteLine("Simple Game of Rock | Paper | Scissors");
            Console.WriteLine("______________________________________\n\n");

            Console.WriteLine("Rock, Paper, Scissors Game");
            Console.WriteLine("Choose Rock | Paper | Scissors to start: Rock (R), Paper (P), or Scissors (S)\n");

            string player1 = Console.ReadLine().ToUpper();
            string computer = GetComputerChoice();

            Console.WriteLine("Player chose " + player1 + " and Computer chose " + computer);
            Console.WriteLine(GetWinner(player1, computer));

            Console.ReadLine();
            }

            static string GetComputerChoice()
            {
                Random random = new Random();
                int choice = random.Next(1, 4);
                switch (choice)
                {
                    case 1: return "R";
                    case 2: return "P";
                    default: return "S";
                }
            }

            static string GetWinner(string player1, string computer)
            {
                if (player1 == computer)
                {
                    return "Tough One! It's a draw!";
                }
                else if (player1 == "R" && computer == "S" || // || returns true "1 " or false "0"
                         player1 == "P" && computer == "R" || // && if both are inputs are true or not
                         player1 == "S" && computer == "P")
                {
                    return "CONGRATS! You win!";
                }
                else
                {
                    return "OOPS! Computer wins!";
                }*/


            /* Console.WriteLine("Enter the marks scored by the student: ");
             int marks = Convert.ToInt32(Console.ReadLine());

             if (marks >= 90)
             {
                 Console.WriteLine("Grade: A+");
             }
             else if (marks >= 85 && marks < 89)
             {
                 Console.WriteLine("Grade: A");
             }
             else if (marks >= 80 && marks < 84)
             {
                 Console.WriteLine("Grade: A-");
             }
             else if (marks >= 75 && marks < 79)
             {
                 Console.WriteLine("Grade: B+");
             }
             else if (marks >= 70 && marks < 74)
             {
                 Console.WriteLine("Grade: B");
             }
             else if (marks >= 65 && marks < 69)
             {
                 Console.WriteLine("Grade: B-");
             }
             else if (marks >= 60 && marks < 64)
             {
                 Console.WriteLine("Grade: C+");
             }
             else if (marks >= 55 && marks < 59)
             {
                 Console.WriteLine("Grade: C");
             }
             else if (marks >= 50 && marks < 54)
             {
                 Console.WriteLine("Grade: C-");
             }
             else
             {
                 Console.WriteLine("Grade: F");
             }

             Console.ReadLine();*/
        }

    }
}


      