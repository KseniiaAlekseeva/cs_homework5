// Enter an array with random positive 3-digit numbers. Return the number of even numbers in array

int[] createRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minVal, maxVal + 1);
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

int calcEvenNum(int[] array)
{
    int evenNum = 0;
    foreach (int el in array)
        if (el % 2 == 0) evenNum++;
    return evenNum;
}


int size = 12;
int minVal = 100;
int maxVal = 1000;
int evNum = 0;

int[] arr = createRandomArray(size, minVal, maxVal);
printArray(arr);

evNum = calcEvenNum(arr);

Console.WriteLine($"Number of even numbers in array is {evNum}.");