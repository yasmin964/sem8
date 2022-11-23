//Задача 58: Задайте две матрицы. Напишите программу, которая будет
//находить произведение двух матриц.
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void GetArray(int [,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void PrintArray(int [,] inArray)
{
    for (int i=0;i<inArray.GetLength(0);i++)
    {
        for (int j=0;j<inArray.GetLength(0);j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");

Console.Write("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine()!);
Console.Write("Введите диапазон случайных чисел: от 1 до ");
int range = int.Parse(Console.ReadLine()!);

int[,] firstMartrix = new int[m, n];
GetArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
GetArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);