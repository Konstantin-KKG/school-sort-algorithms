using project.src;

int[] randomNumbers = Helpers.CreateRandomNumberArray(10);

Console.WriteLine("Random: \t\t {0}", string.Join(", ", randomNumbers));
Console.WriteLine();

// selection sort
int[] selectionSort = (int[])randomNumbers.Clone();
Sort.SelectionSort(selectionSort);
Console.WriteLine("Selection Sort: \t {0}", string.Join(", ", selectionSort));

// quick sort
int[] quickSort = (int[])randomNumbers.Clone();
Sort.QuickSort(quickSort, 0, quickSort.Length - 1);
Console.WriteLine("Quick Sort: \t\t {0}", string.Join(", ", quickSort));

// bubble sort
int[] bubbleSort = (int[])randomNumbers.Clone();
Sort.BubbleSort(bubbleSort);
Console.WriteLine("Bubble Sort: \t\t {0}", string.Join(", ", bubbleSort));

// insertion sort
int[] insertionSort = (int[])randomNumbers.Clone();
Sort.BubbleSort(insertionSort);
Console.WriteLine("Insertion Sort: \t {0}", string.Join(", ", insertionSort));