# BinarySearch

```C#
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
```
 
