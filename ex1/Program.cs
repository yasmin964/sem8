// Задача 53: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку
//массива.
void Reverse(int [,] array)
{
    int index=array.GetLength(0)-1;//номер последней строки
    for(int i=0;i <array.GetLength(1);i++)
    {
        int temp=array[0,i];
        array[0,i]=array[index,i];
        array[index,i]=temp;


    }


}
int[,] GetArray(int m,int n,int minValue,int maxValue)
{
    int [,] result=new int[m,n];
    for (int i=0;i<m;i++)
    {
       for (int j=0;j<n;j++) 
       {
        result[i,j]=new Random().Next(minValue, maxValue +1);
       }
    }
    return result;
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
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во стобцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 100);
PrintArray(array);
Reverse(array);
PrintArray(array);
