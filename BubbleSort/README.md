# BubbleSort

```C#
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
```
 
