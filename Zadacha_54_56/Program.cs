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

void Zadacha58() 
// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16
// другой метод с помощью цикла
{
    int rows = 5;
    int columns = 5;
    int[,] array = new int[rows, columns];
    int row = 0; 
    int column = 0;
    int changeRow = 0;
    int changeColumn = 1;
    int steps = columns; // ограничение по строке
    int turn = 0;

    for (int i = 0; i < array.Length; i++) // array.Length = 4*4 = 16
    {
        array[row, column] = i + 1;
        steps--;
        Console.WriteLine(array[row, column] + "  ");
        if (steps == 0)
        {
            steps = rows - 1 - turn/2;
            int temp = changeRow;
            changeRow = changeColumn;
            changeColumn = -temp;
            turn++;
        }

        row += changeRow;
        column += changeColumn;
    }
    PrintArray(array);
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
//Zadacha56();
Zadacha58();