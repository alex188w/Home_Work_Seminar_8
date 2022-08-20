// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16

int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];
int N = 1;
array[0, 0] = N;
FillArray(0, 1);
PrintArray(array);

void FillArray(int rows, int columns)
{
        if (array[rows, columns] == 0)
        {          
            N = N+1;
            array[rows, columns] = N;
            if (columns < (array.GetLength(1) - 1)) FillArray(rows, columns+1);
            if (rows < (array.GetLength(0) - 1)) FillArray(rows+1, columns);
            if (columns > 0) FillArray(rows, columns-1);
            if (rows > 0) FillArray(rows-1, columns);
        }        
}

void PrintArray(int[,] array)
{
    int rows =  array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}
