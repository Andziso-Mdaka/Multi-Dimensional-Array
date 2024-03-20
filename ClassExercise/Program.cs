using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   int? number = null;

               if (args.Length > 0) // if argument length is more than 0 do..
               {
                   number = args[0].Length;
               }

               if (number is null) // if number is equivalent to null do...
               {
                   Console.WriteLine("'number' requires a value and cannot be null ");
               }
               else
               {
                   Console.WriteLine(
                       $"'number' doubled is {number * 2}.");
               }


               var studentName = "Johnson";
               Console.WriteLine(studentName); 

            Console.WriteLine("Enter a text"); /// request for user input
            var text = Console.ReadLine(); // read the user input

            var upperCase = text.ToUpper();
            Console.WriteLine(upperCase); // print user input in all caps 



            // creating a tuple with two elements
            var person = (name: "Lusukama", age: 42);

            // accessing tuple elements using named fields
            Console.WriteLine($"Name: {person.name} , Age: {person.age}");

            // creating a tuple without specifying field names
            var coordinates = (30, 50);

            //Accessing tuple elements using positional notation
            Console.WriteLine($"X:{coordinates.Item1}, Y: { coordinates.Item2}");

            // Deconstructing a tuple into indivdual variables
            (string name, int age) = person;
            Console.WriteLine($"Name: {name}, Age: {age} \n");

            var facilitator =
                new { Title = "Software Developer",
                YearOfHiring = "2020"};
            var facilitator2 =
                new
                {
                    Title = "Graphic Designer",
                    YearOfHiring = "2024"
                };

            Console.WriteLine($"{facilitator.Title} ({facilitator.YearOfHiring})");

            Console.WriteLine($"{facilitator2.Title} ({facilitator2.YearOfHiring})"); 

            string[] languages = { "c#", "cobol" };
            Console.WriteLine(languages[0]);
            Console.WriteLine(languages[1]); 

            string[] studentName = new string[4];
            Console.WriteLine("Enter 4 students:");

            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine($"student {i + 1}:");
                // get input from user
                studentName[i] = Console.ReadLine();
            }

            //display students
            Console.WriteLine("\n Learner names");

            foreach (string name in studentName) {
                Console.WriteLine(name);
            }
            

            int[,] matrix =
            {
                {1,2,3,4 }, {5,6,7,8}, {9,10,11,12 }

            };

            // return the array

            Console.WriteLine("2D Array: ");
            for (int row  = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine(matrix[row, col] + " \t");
                }
                Console.WriteLine();
            }



            string[,] name =
            {
                {"martin","andzi","yandi","kai" }, {"jacob","carti","drake","savage"}, {"super","man","jack","mike" }

            };

            // return the array

            Console.WriteLine("2D Array: ");
            for (int row = 0; row < name.GetLength(0); row++)
            {
                for (int col = 0; col < name.GetLength(1); col++)
                {
                    Console.WriteLine(name[row, col] + " \t");
                }
                Console.WriteLine();
            }


          

            var animal=
               new
               {
                   name = "Springbok",
                   type = "deer"
               };
            var car =
               new
               {
                   name = "Big Body GLE",
                   brand = "Mercedes"
               };
            
            Console.WriteLine($"{animal.name} ({animal.type})");
            Console.WriteLine($"{car.name} ({car.brand})");  


            Console.WriteLine("enter the size of your array");
            int size = Convert.ToInt32( Console.ReadLine());
            // declare an array with sixe detemined by user input

            int[] numbers = new int[size];

            //populate the array with some values for demonstration

            for (int i = 0; i < size; i++)
            {
                numbers[i] = i * 10;
            }

            Console.WriteLine("Array Elements");
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
         



            Console.WriteLine("Enter a month of the year");
            string input = Console.ReadLine();

            switch (input.ToLower()) {
                case "january":
                    Console.WriteLine("Go to school");
                    break;
                case "february":
                    Console.WriteLine("prepare for test");
                    break;
                case "march":
                    Console.WriteLine("Go on holiday");
                    break;
                case "april":
                    Console.WriteLine("its April");
                    break;
                case "may":
                    Console.WriteLine("its May");
                    break;
                case "june":
                    Console.WriteLine("its June");
                    break;
                case "july":
                    Console.WriteLine("its July");
                    break;
                case "august":
                    Console.WriteLine("its August");
                    break;
                case "september":
                    Console.WriteLine("its September");
                    break;
                case "october":
                    Console.WriteLine("its October");
                    break;
                case "november":
                    Console.WriteLine("its November");
                    break;
                case "december":
                    Console.WriteLine("its December");
                    break;
                default:
                    Console.WriteLine("incorrect input");
                    Main(args);
                    break;



            } */


            Console.WriteLine("How many students do you have?");
            int NumberOfStudents = Convert.ToInt32(Console.ReadLine());

            const int StudentInfoLength = 3; // Name, Gender, DOB

           
            string[,] students = new string[NumberOfStudents, StudentInfoLength];

            
            for (int i = 0; i < NumberOfStudents; i++)
            {
                Console.WriteLine($"Enter details for Student {i + 1}:");

                
                Console.WriteLine("Name: ");
                students[i, 0] = Console.ReadLine();

                
                Console.WriteLine("Gender: ");
                students[i, 1] = Console.ReadLine();

                
                Console.WriteLine("Date of Birth (MM/DD/YYYY): ");
                students[i, 2] = Console.ReadLine();

                Console.WriteLine(); 
            }

            // Display the entered student information
            Console.WriteLine("Entered Student Information:");
            for (int i = 0; i < NumberOfStudents; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                Console.WriteLine($"Name: {students[i, 0]}");
                Console.WriteLine($"Gender: {students[i, 1]}");
                Console.WriteLine($"Date of Birth: {students[i, 2]}");
                Console.WriteLine(); 
            }

          

        }
        














    }
    

}
