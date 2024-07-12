 
 # Data Structures and Algorithm

![Algorithm1](https://github.com/ChungmanPARK12/DataStructure-and-Algorithm/assets/162090754/98076081-09af-4981-9529-d9b87629c5c9)

# Overview

<h2>Purpose</h2>
The purpose of this project is to gain a strong understanding of various data structures and algorithms, learn how to implement and handle different methods and systems in C# , and test them using NUnit to ensure their correctness and efficiency.

<h2>Features</h2>

- **Binary Search**
- **Sequential Search**
- **Bubble Sort**
- **Linked List**
- **Binary Search Tree**
- **NUnit Testing**

<h2>Debugging Process</h2>

- **Code Review**: Regular reviews and tools like pylint and flake8 ensured code quality.
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



* ### Product Class

Defines a `Product` class with attributes for barcode, name, description, and price. Includes methods for printing details and comparing products by barcode.

* ### Transactions Class

Defines a `Transactions` class with attributes for date, barcode, and amount. Includes methods to retrieve the transaction date, barcode, and amount.

* ### CheckoutRegister Class

Defines a `CheckoutRegister` class to manage product scanning, payment processing, and transaction saving. Integrates with `SupermarketDAO` for database operations and handles shopping cart functionality.

<h2>Back End</h2>

![image description](https://github.com/ChungmanPARK12/SupermarketDAO/assets/162090754/d9e2a6e5-dacf-428f-ab48-50aa280b16b4)

* ### SupermarketDAO

Defines a `SupermarketDAO` class to manage supermarket data, including users, products, and transactions, using SQLite3 and OpenPyxl for database operations and report generation. 


* ### StartUp Login

This Class manages the supermarket data with `SupermarketDAO`, offering user login, product management, transaction tracking, and report generation, including bar charts and Excel reports, using SQLite3 and OpenPyxl.

## Thank you

Thank you for visiting my github :)


