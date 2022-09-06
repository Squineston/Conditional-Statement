using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expected grade:");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 98)
            {
                Console.WriteLine("Your letter grade is A+");
            }

            else if (grade < 98 && grade >= 92)
            {
                Console.WriteLine("Your letter grade is A");
            }

            else if (grade < 92 && grade >= 90)
            {
                Console.WriteLine("Your letter grade is A-");
            }

            else if (grade < 90 && grade >= 88)
            {
                Console.WriteLine("Your letter grade is B+");
            }

            else if (grade < 88 && grade >= 82)
            {
                Console.WriteLine("Your letter grade is B");
            }

            else if (grade < 82 && grade >= 80)
            {
                Console.WriteLine("Your letter grade is B-");
            }

            else if (grade < 80 && grade >= 78)
            {
                Console.WriteLine("Your letter grade is C+");
            }

            else if (grade < 78 && grade >= 72)
            {
                Console.WriteLine("Your letter grade is C");
            }

            else if (grade < 72 && grade >= 70)
            {
                Console.WriteLine("Your letter grade is C-");
            }

            else if (grade < 70 && grade >= 68)
            {
                Console.WriteLine("Your letter grade is D+");
            }

            else if (grade < 68 && grade >= 62)
            {
                Console.WriteLine("Your letter grade is D");
            }

            else if (grade < 62 && grade >= 60)
            {
                Console.WriteLine("Your letter grade is D-");
            }

            else 
            {
                Console.WriteLine("Your letter grade is F");
            }
        }
    }
}
