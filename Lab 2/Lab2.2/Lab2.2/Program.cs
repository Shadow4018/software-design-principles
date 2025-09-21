using System.CodeDom.Compiler;

const int SIZE = 5;
int[,] generateArr()
{
    Random rnd = new Random();
    int [,]array = new int[SIZE, SIZE];
    for(int i = 0; i < SIZE; i++)
    {
        for(int j = 0; j < SIZE; j++)
        {
            array[i, j] = rnd.Next(-50, 49);
        }
    }
    return array;
}

void displayArray(int[,] array) {
    for (int i = 0; i < SIZE; i++)
    {
        for (int j = 0; j < SIZE; j++)
        {
            Console.Write(array[i, j]);
            Console.Write("\t");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

int MinOutOfRow(int[,] array, int index) {
    int min = 100;
    for (int i = 0; i < SIZE; i++)
    {
        if(array[index, i] < min)
        {
            min = array[index, i];
        }
    }
    Console.Write("Min: ");
    Console.WriteLine(min);
    return min;
}

void solution(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayX = new int[SIZE, SIZE];
    for (int i = 0;i < SIZE; i++)
    {
        int min = MinOutOfRow(arrayB, i);
        for (int j = 0; j < SIZE; j++)
        {
            arrayX[i, j] = arrayA[i, j] * min;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Solution: ");
    displayArray(arrayX);
}

void main()
{
    int[,] arrayA = generateArr();
    int[,] arrayB = generateArr();
    displayArray(arrayA);
    displayArray(arrayB);
    solution(arrayA, arrayB);
}

main();