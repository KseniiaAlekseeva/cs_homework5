// Find the difference between the minium and maximum numbers in real numbers array. 

double[] createRandomArray(int size, double minVal, double maxVal)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = minVal + new Random().NextDouble() * (maxVal - minVal);
    return array;
}

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
    Console.WriteLine();
}

double findMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}

double findMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}

double difMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double dif = 0.0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    dif = max - min;
    Console.WriteLine("Minimum is " + min);
    Console.WriteLine("Maximum is " + max);
    return dif;
}

int size = 12;
double minVal = -10.0;
double maxVal = 10.0;

double[] arr = createRandomArray(size, minVal, maxVal);
printArray(arr);

// Console.WriteLine("Minimum number is " + findMin(arr));
// Console.WriteLine("Maximum number is " + findMax(arr));
// Console.WriteLine("Difference between maximum and minimum is " + findMax(arr) - findMin(arr));

Console.WriteLine("Difference between maximum and minimum is " + difMinMax(arr));