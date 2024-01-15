# Guided Assignment - Implementing Insertion Sort in C#

## Introduction
In this assignment, you will focus on implementing and understanding the Insertion Sort algorithm in C#. Insertion Sort is a simple and efficient sorting algorithm, especially useful for small data sets. It builds the final sorted array one item at a time. This assignment will help you learn the basics of sorting algorithms and their practical implementation in C#.

### Pseudocode

```pseudocode
procedure insertionSort(arr: List of Comparable)
    // Get the length of the input array
    arrayLength = length(arr)
    
    // Iterate through the array starting from the second element
    for currentIndex from 1 to arrayLength - 1
        // Store the current element's value
        currentValue = arr[currentIndex]

        // Initialize the position for comparing the current element
        previousIndex = currentIndex - 1

        // Shift elements of the sorted part that are greater than currentValue
        while previousIndex >= 0 and arr[previousIndex] > currentValue
            arr[previousIndex + 1] = arr[previousIndex]
            previousIndex = previousIndex - 1
        end while

        // Place the current element at its correct position
        arr[previousIndex + 1] = currentValue
    end for
end procedure
```

---

## Detailed Requirements

**Project Setup (20 Points):**

- Create a new console application in your IDE.
- Name the project `GA_InsertionSort_YourName` (replace "YourName" with your actual name).

**Understanding of Insertion Sort Algorithm (15 Points):**

- Write pseudo-code explaining the Insertion Sort algorithm.
- Describe how the algorithm inserts elements in their correct position.
- Explain the importance of comparing elements during sorting.

**Implementation of Insertion Sort (15 Points):**

- Implement the Insertion Sort algorithm in C#.
- Ensure your code follows the described algorithm.
- Add clear comments explaining the code's functionality.

**Explanation of Algorithm Logic (15 Points):**

- Provide comments explaining:
    - The purpose of the main loop and the nested loop.
    - The role of comparisons and shifts.
    - How the algorithm ensures sorted order at each step.

**Implementing Efficient Sorting Technique (15 Points):**

- Implement necessary conditions to efficiently sort using Insertion Sort.
- Explain through comments how these conditions enhance sorting efficiency.
- Discuss the role of these conditions in minimizing unnecessary comparisons and shifts.

**Optimizing the Sorting Process (10 Points):**

- Optimize the sorting, such as minimizing comparisons when the correct position is found.
- Explain how this optimization improves performance.
- Discuss the importance of optimization in sorting algorithms.

**Code Testing and Output Accuracy (5 Points):**

- In the `Main` method, create test cases to demonstrate Insertion Sort.
- Test with arrays of different sizes and contents.
- Verify that the output is correctly sorted.

**Submission (5 Points):**

- Upload the complete project to GitHub.
- Make the repository public and include all necessary files.
- Provide the GitHub repository link in your Canvas submission.

**Total (100 Points):**

- Each section is required.
- Points are awarded based on meeting the detailed requirements accurately.

Follow these requirements closely to meet all the criteria outlined in the rubric for your assignment.

---

## Step By Step

### Step 1:

In this step, we start the `InsertionSortArray` method. Here's the code with comments:

```csharp
static void InsertionSortArray(int[] arr)
{
    // 1. Calculate the length of the array
    int arrayLength = arr.Length;

    // 2. Start a loop from the second element
    for (int currentIndex = 1; currentIndex < arrayLength; currentIndex++)
    {
        // 3. Internal Code
    }
}
```

1. We calculate the length of the input array using `int arrayLength = arr.Length`.

2. We start a `for` loop with `currentIndex` initialized to `1`, which represents the second element of the array. This loop iterates through the array elements, excluding the first one.

### Step 2:

In this step, we provide more details in the `InsertionSortArray` method. Here's the code with comments:

```csharp
static void InsertionSortArray(int[] arr)
{
    int arrayLength = arr.Length;
    for (int currentIndex = 1; currentIndex < arrayLength; currentIndex++)
    {
        // 1. Store the value of the current element in currentValue
        int currentValue = arr[currentIndex];

        // 2. Initialize previousIndex to one position before currentIndex
        int previousIndex = currentIndex - 1;

        // 3. Start a loop to move elements greater than currentValue
        //    one position ahead of their current position
        while (previousIndex >= 0 && arr[previousIndex] > currentValue)
        {
            // Internal Code
        }

        // 4. Place currentValue at its correct position in the sorted part of the array
        arr[previousIndex + 1] = currentValue;
    }
}
```

1. We store the value of the current element at index `currentIndex` in the variable `currentValue`.

2. We initialize `previousIndex` to be one position before `currentIndex`, which represents the index of the element immediately before the current one.

3. We start a `while` loop to move elements greater than `currentValue` one position ahead of their current position. This loop compares elements and potentially shifts them.

4. After the `while` loop, we place `currentValue` at its correct position in the sorted part of the array.

### Step 3:

In this step, we focus on the details within the `while` loop. Here's the code with comments:

```csharp
while (previousIndex >= 0 && arr[previousIndex] > currentValue)
{
    // 1. Shift the element to the right
    arr[previousIndex + 1] = arr[previousIndex];

    // 2. Decrement previousIndex to move to the previous element
    previousIndex = previousIndex - 1;
}

// 3. Place currentValue at its correct position in the sorted part of the array
arr[previousIndex + 1] = currentValue;
```

1. Inside the `while` loop, we shift the element at `previousIndex` to the right by assigning `arr[previousIndex]` to `arr[previousIndex + 1]`. This step ensures that we make room for `currentValue` in the correct position.

2. We decrement `previousIndex` by `1` to move to the previous element in the array.

3. After the `while` loop, we place `currentValue` at its correct sorted position by assigning it to `arr[previousIndex + 1]`. This step completes the insertion of `currentValue` into the sorted portion of the array.

These comments and numbered explanations should help clarify where specific actions are happening in the code.


---
### Final Test

### Code to add
```csharp
using System;

class Program
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        int size = 10; // Change the size of the array as needed
        int minValue = 1; // Change the minimum value as needed
        int maxValue = 100; // Change the maximum value as needed

        int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);

		// Display your array in it's unsorted form

		// Call your bubble sort method

		// Display your method after its been sorted
    }

    static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
    {
        if (size <= 0 || minValue > maxValue)
        {
            throw new ArgumentException("Invalid arguments");
        }

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1);
        }
        return arr;
    }

}

```


### Expected result
```Console
Unsorted: 45 12 88 73 5 19 64 34 99 1
Sorted: 1 5 12 19 34 45 64 73 88 99
```

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Proper creation of a new console application named GA_InsertionSort_YourName. | 20 |
| **Understanding of Insertion Sort Algorithm** | Clear explanation and pseudo-code of Insertion Sort. | 15 |
| **Implementation of Insertion Sort** | Correct implementation of Insertion Sort in C#. | 15 |
| **Explanation of Algorithm Logic** | Detailed comments explaining the logic of the algorithm. | 15 |
| **Implementing Efficient Sorting Technique** | Correct implementation and explanation of efficient sorting techniques. | 15 |
| **Optimizing the Sorting Process** | Implementation and explanation of optimization techniques. | 10 |
| **Code Testing and Output Accuracy** | Successful testing and demonstration of accurate sorting. | 5 |
| **Submission** | Successful upload to GitHub with the correct link provided. | 5 |
| **Total** |  | 100 |

This guided assignment provides a comprehensive look at the Insertion Sort algorithm in C#, covering its logic, implementation, optimization, and testing.