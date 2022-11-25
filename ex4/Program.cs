// Задача 59: Задайтедвумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на
//пересечении которых расположен наименьший элемент
//массива.
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
int [,] ModArray (int [,] array,int [] exclude)
{
    int [] newarray=new int[array.GetLength(0)-1,array.GetLength(1)-1];
    int row=0,col=0;
    for (int i=0;i<array.GetLength(0);i++)
    {
        if (i==exclude[0]){continue;}
        for (int j=0;j<array.GetLength(1);j++)
        {
            if (i==exclude[0]){continue;}
            newarray[row,col]=array[i,j];
            col++;
        }
        row++;col=0;

    }
    return newarray;
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
int [,] myArray=GetArray(3,3,0,10);
int []minelement=GetArrayIndexMin(myArray);
int [,] myBestArray=ModArray(myArray,minelement);
PrintArray(myArray);
Console.WriteLine();
PrintArray(myBestArray);
