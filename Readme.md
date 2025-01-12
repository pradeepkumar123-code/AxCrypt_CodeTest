# Readme

## Problem Description

This project consists of solutions to two problems:

### Test 1: Sum Numbers from a File

Write a C# method that reads a file containing numbers (one number per line), parses the numbers, and returns their sum.

#### Input Format

- A string representing the path to the file.

#### Constraints

- The file will contain at least one number.
- The file may contain empty lines or lines with non-numeric characters.
- Each number will be an integer.
- Implement exception handling.

#### Output

- An integer representing the sum of all numbers in the file. If a line cannot be parsed as a number, it should be ignored.

#### Example

**Input File Content**:
1
2
3
foo
4
5
bar


**Output**:
15


#### Solution Highlights

- Handles empty lines and non-numeric characters gracefully.
- Includes exception handling for file reading errors.

---

### Test 2: Retrieve Overdue Books (Entity Framework Core)

Write an asynchronous method using Entity Framework Core that retrieves a list of books that were due to be returned more than 30 days ago from a library database. The results should be sorted in descending order by due date.

#### Input Format

- The method takes no arguments.

#### Constraints

- A `Book` class exists with the following properties:
  - `Title` (string)
  - `DueDate` (DateTime)
  - Other properties as necessary.
- A `LibraryContext` class exists that extends `DbContext` and includes a `DbSet<Book> Books`.

#### Output

- A `List<Book>` representing books overdue for more than 30 days, sorted by `DueDate` in descending order.

#### Solution Highlights

- Sorts the results by `DueDate` in descending order.
- Implements asynchronous programming for efficient database operations.

---

## Setup Instructions

### Prerequisites

- .NET 8.0
- Microsoft.EntityFrameworkCore 9.0.0
- Microsoft.EntityFrameworkCore.InMemory 9.0.0

### Execution
Run the tool and output will be visible in console

