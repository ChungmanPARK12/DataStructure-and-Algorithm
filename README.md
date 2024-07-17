 
 # Data Structures and Algorithm

![Algorithm1](https://github.com/ChungmanPARK12/DataStructure-and-Algorithm/assets/162090754/98076081-09af-4981-9529-d9b87629c5c9)

# Overview

<h2>Purpose</h2>

The purpose of this project is to gain a strong understanding of various data structures and algorithms, learn how to implement and handle different methods and systems in `C#` , and test them using NUnit to ensure their correctness and efficiency.

<h2>Features</h2>

- **Binary Search**
- **Sequential Search**
- **Bubble Sort**
- **Node**
- **Linked List**
- **Binary Search Tree**
- **NUnit Testing**

<h2>Debugging Process</h2>

- **Setting Breakpoints**: Set Breakpoints in the code to start debugging and pressing 'F5'.
- **Stepping Through Code**: Use 'F10' to step over each line of code and 'F11' to step in to methods for detailed.
- **Checking Output**: Utilize 'console.Writeline' statements to print variable and outputs.

# Getting Started
<h2>System Requirements</h2>

To operate this supermarket system, you will need the following:

- **Class Library(.NET Framework)**
- ![NET](https://github.com/ChungmanPARK12/DataStructure-and-Algorithm/assets/162090754/b6777594-ddae-4d2a-8bcb-c2d6d0559822)

<h2>Installation</h2>

- **IDE**: An integrated development environment(IDE) makes development easier [official website](https://visualstudio.microsoft.com/)
- **Visual Studio**: A powerful IDE for Windows and MacOS, which provides extensive feature for C# development. 
- **Visual Studio 2019**: Requires Windows 7 or Windowes 10 recommended.
- **Visual Studio 2022**: Requires Windows 10 or higher.

- **Clone the Repository**:
   ```bash
   git https://github.com/ChungmanPARK12/DataStructure-and-Algorithm.git
   cd <Algorithm_and_NUnitTest/Class_Library>

# Alorithms

<h2>Binary Search</h2>
A fast algorithm for finding a target value within a sorted array by repeatedly dividing the search interval in half, reducing time complexity to O(log n).


* ### Example of Code [Click here](https://github.com/ChungmanPARK12/BinarySearch.git)

<h2>Sequantial Search</h2>
A linear search, involves checking each element of a list one-by-one until the target value is found or the list ends. It has a time complexity of O(n).


* ### Example of Code [Click here](https://github.com/ChungmanPARK12/SequentialSearch.git)

<h2>Bubble Sort</h2>
A simple sorting algorithm that repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. This process is repeated until the list is sorted. Its time complexity is O(n²).

* ### Ascending and Descending sort 

* ### Example of Code [Click here](https://github.com/ChungmanPARK12/BubbleSort.git)

<h2>Node</h2>
A fundamental unit used to build linked lists, trees, and graphs. It typically contains data and references (or pointers) to other nodes, forming complex structures.

### Traverse Pre Order
* Visit the root node.
* Traverse the left subtree.
* Traverse the right subtree.

### Traverse In Order
* Traverse the left subtree.
* Visit the root node.
* Traverse the right subtree.

### Traverse Post Order
* Traverse the left subtree.
* Traverse the right subtree.
* Visit the root node.

 ### Example of Code [Click here](https://github.com/ChungmanPARK12/Node.git)

 <h2>Single Linked List</h2>
A linear data structure where each element (node) contains data and a reference (or pointer) to the next node in the sequence. The first node is called the head, and the last node points to null, indicating the end of the list.

* ### Example of Code [Click here](https://github.com/ChungmanPARK12/SingleLinkedList.git)

* ### Single Linked List Node
```C#
 public class SingleLinkedListNode<T>
    {
        public SingleLinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public SingleLinkedListNode<T> Next { get; set; }
    }
``` 
<h2>Doubly Linked List</h2>
A linear data structure where each node contains data and two references (or pointers): one to the next node and one to the previous node. This allows traversal in both directions *(forward and backward)*.

* ### Example of Code [Click here](https://github.com/ChungmanPARK12/DoublyLinkedList.git)

* ### Doubly Linked List Node
```C#
  public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public DoubleLinkedListNode<T> Next { get; set; }
        public DoubleLinkedListNode<T> Previous { get; set; }
    }
```
# Class 
<h2>ICompareble Student Class Interface</h2>

- **Properties: Program, DateRegistered, StudentId**
- **Constructor: Initializes properties**
- **Operators: ==, !=**
- **Interfaces: Implements IComparable (Student)**
- **Methods: Equals, GetHashCode, ToString**

* ### Example of Code [Click here](https://github.com/ChungmanPARK12/Student.git)

<h2>Program Class</h2>

Demonstrates operations on data structures including arrays, single and double linked lists, and binary trees. It features methods for testing sequential search, binary search, bubble sort, and linked list manipulations.

* ### Example of Code [Click here](https://github.com/ChungmanPARK12/Program.git)

<h2>Utility Class</h2>

Provides methods for sorting and searching arrays of Student objects, including bubble sort (ascending and descending), binary and sequential search operations and the method of UNitTesting.

* ### Example of Code [Click here](https://github.com/ChungmanPARK12/Utility.git)

# NUnit Testing

<h2>NUnit Test Class</h2>

 To test Some methods from the Program class, verifying expected outputs using assertions and capturing console output.

* ### Example of Code 
```C#
  [Test]
        public void TestSequentialSearch()
        {
            string Expected = "Result Found: 2";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Class_Library_Assignment.Program.TestSequentialSearch();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
```
|Algorithim|Expected Output|Actual Output|Pass/Fail| 
|--|--|--|--|
|Sequential Search|Result Found 2|Result Found 2|Pass|

## Summary

## Summary

This Data Structure and Algorithm project provides a comprehensive collection of essential algorithms and data structures. It includes implementations and explanations for sorting, searching, graphs, trees, and more. Designed for efficiency and clarity, this project serves as a valuable resource for learning and applying fundamental concepts in computer science.



## Thank you

Thank you for visiting my github :)


