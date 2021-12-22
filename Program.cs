using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Reminder!!!\n If you are too lazy to enter the " +
                "hole students in your class, just enter 2 hardworking students" +
                "and 2 lazy students");

            Console.Write(" How many students in your class?\n > ");

            int studentCount = int.Parse(Console.ReadLine());
            var studentsName = new string[studentCount];
            var studentsGrade = new int[studentCount];

            for (int eachStudent = 0; eachStudent < studentCount; eachStudent++)
            {
                Console.Write(" Student Name:\n > ");
                studentsName[eachStudent] = Console.ReadLine();

                Console.Write(" Student Grade:\n > ");
                studentsGrade[eachStudent] = int.Parse(Console.ReadLine());
            }

            for (int student = 0; student < studentCount; student++)
            {
                Console.WriteLine($" Name: {studentsName[student]},  Grade: {studentsGrade[student]}");
            }




            Console.ReadKey();
        }
    }
}
