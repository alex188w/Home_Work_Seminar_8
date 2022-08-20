void Zadacha54()
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 99);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < columns; k++)
            {
                if(array[i, k] > array[i, maxPosition]) maxPosition = k;
            }

            int temporary = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Полученный массив ");
    PrintArray(array);
}

void Zadacha56()
// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов
{
    Random random = new Random();
    int rows = random.Next(4, 5);
    int columns = rows;
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 9);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);

    int minPosition = 0;    
    int sum = 1000; // не знаю, как задать +бесконечность, по аналогии с нулем
    
    for (int i = 0; i < rows; i++) 
    {       
        int sum_i = 0;
        for (int j = 0; j < columns; j++)
        {            
            sum_i = sum_i + array[i, j];       
        }
        if (sum_i < sum) 
        {
            minPosition = i;
            sum = sum_i;
        }
        Console.WriteLine($"Сумма элементов строки {i} равна {sum_i}");
    }
    Console.WriteLine("Строка с наименьшей суммой элементов имеет номер " + minPosition);
}

void FillArray(int[,] array, int startNumber, int finishNumder)
{
    Random random = new Random();
    finishNumder++;
    int rows =  array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(startNumber, finishNumder);   
        }
    }
}

void PrintArray(int[,] array)
{
    int rows =  array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
              Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

//Zadacha54();
Zadacha56();
