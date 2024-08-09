# Program

```C#
 public class Program
    {
        static Student[] students = {
            new Student("math", "06/May", 3),
            new Student("english", "08/Dec", 1),
            new Student("spanish", "11/Nov", 4),
            new Student("Science", "09/Oct", 2),
            new Student("Soccer", "09/Oct", 5),
            new Student("Badminton", "09/Oct", 7),
            new Student("Running", "09/Oct", 9),
            new Student("Racing", "09/Oct", 8),
            new Student("Science", "09/Oct", 11),
            new Student("math", "May/Jan", 10)
        };

        static Student node1 = new Student("math", "06/May", 3);
        static Student node2 = new Student("english", "08/Dec", 1);
        static Student node3 = new Student("Running", "09/Oct", 9);
        static Student node4 = new Student("Science", "09/Oct", 11);
        static Student node5 = new Student("Badminton", "09/Oct", 7);

        // Test in NUnit

        public static void TestSequentialSearch() 
        {
            Utility.NUnitSequentialSearch(students);
        }
        public static void TestBinarySearch()
        {
            Utility.NUnitBinarySearch(students);
        }
        public static void TestBubbleSort() 
        {
            Utility.NUnitBubbleSort(students);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Student Lists \n");
            for (int i = 0; i < students.Length; i++) // List of students 
            {
                Console.WriteLine(students[i] + " ");
            }

            // Sequential Search
            Utility.SequentialSearch(students);
            Console.WriteLine("\n");

            // Binary Search
            Utility.BinarySearch(students);
            Console.WriteLine("\n");

            // Bubble Descending Students
            Console.WriteLine("Lists in Descending Order StudentID \n");
            Console.ReadLine();
            Utility.BubbleSortDescending(students);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].StudentId);
            }

            // Bubble Ascending Order of students
            Console.WriteLine("Lists in Ascending Order StudentID \n");
            Console.ReadLine();
            Utility.BubbleSortInAscending(students);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].StudentId);
            }
            Console.WriteLine("\n");

            //Double linked list
            DoubleLinkedList<Student> nodes = new DoubleLinkedList<Student>();
            Console.WriteLine("Double Linked List Test \n");
            Console.ReadLine();
            // AddFirst nodes
            nodes.AddFirst(node3);
            nodes.AddFirst(node2);
            nodes.AddFirst(node1);
            Console.WriteLine("Node 3, 2 and 1 are added at the First" + "\n");
            foreach (Student n in nodes)
            {
                Console.WriteLine("Program :" + n.Program +" " + "DateRegistered :" + n.DateRegistered + " " + "Student ID" + n.StudentId);
            }
            Console.WriteLine("\n");

            // AddLast nodes
            Console.WriteLine("Add Last nodes\n");
            Console.ReadLine();
            nodes.AddLast(node4);
            nodes.AddLast(node5);
            Console.WriteLine("Node 4 and 5 are added at the last" + "\n");
            foreach (Student n in nodes)
            {
                Console.WriteLine("Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "Student ID" + n.StudentId);
            }
            Console.WriteLine("Contain Node 1 to 5 \n");

            // Contain function
            Console.WriteLine("Contain function \n");
            Console.ReadLine();
            Console.WriteLine(" Node2 found True / False: " + nodes.Contains(node2));
            Console.WriteLine(" Node5 found True / False: " + nodes.Contains(node5));

            foreach (Student n in nodes)
            {
                Console.WriteLine("Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "Student ID" + n.StudentId);
            }
            Console.WriteLine("\n");

            // Remove First
            Console.WriteLine("Remove First Node");
            Console.ReadLine();
            Console.WriteLine("-------First Node deleted-------");
            nodes.RemoveFirst();
            foreach (Student n in nodes)
            {
                Console.WriteLine("Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "Student ID" + n.StudentId);
            }
            Console.WriteLine("\n");

            // Remove Last
            Console.WriteLine("Remove Last Node");
            Console.ReadLine();
            //Console.WriteLine("Last Node will is deleted");
            nodes.RemoveLast();
            foreach (Student n in nodes)
            {
                Console.WriteLine("Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "Student ID" + n.StudentId);
            }
            Console.WriteLine("-------The Last Node deleted--------\n");

            // Test Single Linke List
            SingleLinkedList<Student> nodesForSingle = new SingleLinkedList<Student>();
            Console.WriteLine("Single Linked List Test \n");
            Console.ReadLine();
            // AddFirst nodes
            nodesForSingle.AddFirst(node3);
            nodesForSingle.AddFirst(node2);
            nodesForSingle.AddFirst(node1);
            Console.WriteLine("Node 3, 2 and 1 are added at the First, Node for single" + "\n");
            foreach (Student n in nodesForSingle)
            {
                Console.WriteLine("Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "Student ID" + n.StudentId);
            }
            Console.WriteLine("\n");

            // AddLast nodes
            Console.WriteLine("Add last nodes \n");
            Console.ReadLine();
            Console.WriteLine("node 4 and 5 are added at the last, Node for single" + "\n");
            nodesForSingle.AddLast(node4);
            nodesForSingle.AddLast(node5);
            foreach (Student n in nodesForSingle)
            {
                Console.WriteLine("Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "Student ID" + n.StudentId);
            }
            Console.WriteLine("Contain Nodes 1 to 5 \n");

            // Contain function
            Console.WriteLine("Contain function \n");
            Console.ReadLine();
            Console.WriteLine(" Node2 found True / False: " + nodesForSingle.Contains(node2));
            Console.WriteLine(" Node5 found True / False: " + nodesForSingle.Contains(node5));

            foreach (Student n in nodesForSingle)
            {
                Console.WriteLine("Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "Student ID" + n.StudentId);
            }
            Console.WriteLine("\n");

            // Remove First
            Console.WriteLine("Remove First Node");
            Console.ReadLine();
            Console.WriteLine("-------First Node deleted-------");
            nodesForSingle.RemoveFirst();
            foreach (Student n in nodesForSingle)
            {
                Console.WriteLine("Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "Student ID" + n.StudentId);
            }
            Console.WriteLine("\n");

            // Remove Last
            Console.WriteLine("Remove Last Node");
            Console.ReadLine();
            nodesForSingle.RemoveLast();
            foreach (Student n in nodesForSingle)
            {
                Console.WriteLine("Program :" + n.Program + "DateRegistered :" + n.DateRegistered + "Student ID" + n.StudentId);
            }
            Console.WriteLine("-------First Node deleted------- \n");

            // Test Binary Tree
            Console.WriteLine("Test Binary Tree");
            Console.ReadLine();
            BinaryTree binaryTree = new BinaryTree();
            // BinarySearch Tree
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(3);
            binaryTree.Add(4);
            binaryTree.Add(5);
            binaryTree.Add(6);
            binaryTree.Add(7);

            Node node = binaryTree.Find(5);
            if (node != null)
            {
                Console.WriteLine($"Node found: {node.Data}");
            }
            else
            {
                Console.WriteLine("Node not found");
            }
            
            int depth = binaryTree.GetTreeDepth();
            Console.WriteLine($"Tree Depth: {depth}");

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();
        }
    }

```
 
