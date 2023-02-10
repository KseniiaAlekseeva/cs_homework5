// Calculate the sum of elements in array which stands on odd positions.

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

int oddPosCalcSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}


int size = 12;
int minVal = -10;
int maxVal = 10;
int oddSum = 0;

int[] arr = createRandomArray(size, minVal, maxVal);
printArray(arr);

oddSum = oddPosCalcSum(arr);

Console.WriteLine($"The sum of elements in array which stands on odd positions is {oddSum}.");