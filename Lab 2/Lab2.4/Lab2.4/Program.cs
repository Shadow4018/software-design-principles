
using System.Drawing;

int[][] generateArr()
{
    Console.Write("Input the size of the array: ");
    int SIZE = int.Parse(Console.ReadLine());
    int[][] array = new int[SIZE][];
    Random rnd = new Random();

    for (int i = 0; i < SIZE; i++)
    {
        int length = rnd.Next(1, 6);
        array[i] = new int[length];
        for (int j = 0; j < length; j++)
            array[i][j] = rnd.Next(-10, 10);
    }

    return array;
}

void displayArray(int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            Console.Write("\t");
            Console.Write(array[i] [j]);
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

void findTheSum(int[][] array)
{
    int maxColumns = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] != null && array[i].Length > maxColumns)
            maxColumns = array[i].Length;

    if (maxColumns == 0)
    {
        Console.WriteLine("No columns to process (all rows empty).");
        return;
    }

    int[] sums = new int[maxColumns];

    for (int col = 0; col < maxColumns; col++)
    {
        int sum = 0;
        for (int row = 0; row < array.Length; row++)
        {
            if (array[row] != null && col < array[row].Length)
            {
                int val = array[row][col];
                if (val > 0 &&  (val % 2) == 0)
                {
                    sum += val;
                }
            }
        }
        sums[col] = sum;
    }

    Console.WriteLine("Суми парних додатних елементів по стовпцях:");
    for (int i = 0; i < sums.Length; i++)
        Console.WriteLine($"Стовпець {i}: {sums[i]}");
}

void main()
{
    int[][] arrayA = generateArr();
    displayArray(arrayA);
    findTheSum(arrayA);
}

main();