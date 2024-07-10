using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Assignment
{
    public class Utility
    {
        public static void BubbleSortDescending(Student[] students)
        {
            Student temp;
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - 1 - i; j++)
                {
                    if (students[j].StudentId < students[j + 1].StudentId)
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubbleSortInAscending(Student[] students)
        {
            Student temp;
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - 1 - i; j++)
                {
                    if (students[j].StudentId > students[j + 1].StudentId)
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }

        public static int BinarySearch(Student[] students)
        {
            Console.WriteLine("Please insert Student ID to Binary Search");
            int searchFor = int.Parse(Console.ReadLine());
            int start = 0;
            int end = students.Length - 1;
            bool isFound = false;
            while (start <= end)
            {
                int i = (start + end) / 2;
                if (searchFor.Equals(students[i].StudentId))
                {
                    isFound = true;
                    Console.WriteLine("Student ID found at index : " + i);
                    return i;
                }
                else if (searchFor < students[i].StudentId)
                {
                    end = i - 1;
                }
                else
                {
                    start = i + 1;
                }

            }

            if (isFound == false)
            {
                Console.WriteLine($"{searchFor} Could not find in the lists");
            }
            return -1;

        }

        public static void SequentialSearch(Student[] students)
        {
            Console.WriteLine("Please insert Student ID to Sequential Search");
            int inputId = int.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (inputId == students[i].StudentId)
                {
                    Console.WriteLine("Student ID found at index : " + i);
                    isFound = true;
                    break;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("Could not Found");
            }
        }

        public static void NUnitSequentialSearch(Student[] students)
        {
            int inputId = 3;
            bool isFound = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (inputId == students[i].StudentId)
                {
                    Console.WriteLine("Result Found: " + i);
                    isFound = true;
                    break;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("Could not find");
            }
        }


        public static int NUnitBinarySearch(Student[] students)
        {
            int searchFor = 6;
            int start = 0;
            int end = students.Length - 1;
            bool isFound = false;
            Array.Sort(students);
            while (start <= end)
            {
                int i = (start + end) / 2;
                if (searchFor.Equals(students[i].StudentId))
                {
                    isFound = true;
                    Console.WriteLine($"Result is {students[i]}");
                    return i;
                }
                else if (searchFor < students[i].StudentId)
                {
                    end = i - 1;
                }
                else
                {
                    start = i + 1;
                }

            }

            if (isFound == false)
            {
                Console.WriteLine("Could not find the result");
            }
            return -1;

        }

        public static void NUnitBubbleSort(Student[] students)
        {
            Student temp;
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - 1 - i; j++)
                {
                    if (students[j].StudentId > students[j + 1].StudentId)
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("BubbleSorted");
        }

    }
}
