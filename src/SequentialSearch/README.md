# SequentialSearch

```C#
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
```
 
