//Author: Colby D
//Course: COMP003A
//Faculty: Jonathan Rodrigo Cruz
//Purpose: Calculate average grades using arrays and lists in C#

namespace COMP003A.LectureActivity4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare an array to store 5 grades
            int[] grades = new int[5];

            // declare a list to store student names
            List<string> studentNames = new List<string>();

            //collect, validate, then store the grades
            for(int i = 0; i < grades.Length; i++)
            {
                int grade = -1;
                while(grade < 0 || grade > 100)
                {
                    Console.Write($"Enter grade for student {i + 1} (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out grade)) //check if input is a valid integer
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            grades[i] = grade;
                        }
                        else
                        {
                            Console.WriteLine("GRade must be between 0 and 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        grade = -1; //Resets grade to an invalid value to re-enter the loop
                    }
                }
            }
            //Calculate the average grade
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            double average = sum / grades.Length;

            //Display the grades and average
            Console.WriteLine("\nGrades: ");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade); // Display each grade stored in the array
            }
            Console.WriteLine($"Average Grade: {average:F2}");

            // Collect students names
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter name for student {i + 1}: ");
                studentNames.Add(Console.ReadLine()); // Add the enterd name 
            }

            Console.WriteLine("\nStudent Names: ");
            for(int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"Student {i + 1}: {studentNames[i]}"); //Display each student name with their index
            }
        }
    }
}
