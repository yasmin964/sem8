//Задача 57: Составить частотный словарь элементов
//двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент
//входных данных.
int [,] Convert1d (int [,] array)
{
    int [] newarray=new int [array.GetLength(0)*array.GetLength(1)];
 int index=0;   
for(int i=0;i <array.GetLength(0);i++)

{

    for(int j=0;j <array.GetLength(1);j++)
    {
        newarray[index++]=array[i,j];


    }
}return newarrray;

}
void BoobleShort(int [] array)

{
    int temp;
    for(int i=0;i <array.Length;i++)

{

    for(int j=0;j <array.Length;j++)
    {if (GetArray[i]<GetArray[j])
    
    {
         temp=array[i];
        array[i]=array[j];
        array[j]=temp;


    }
    }
}



}


void Slovar(int [] array);
{
    int currentitem=GetArray[0];
    int count=1;
    for(int i=0;i <array.Length;i++)
    {
        if (array[i]==currentitem)
        {
            count++;
        }
        else{
            Console.WriteLine($"{currentitem}->{count}");
            count=1;
            currentitem=array[i];
        }

    }
    Console.WriteLine($"{currentitem}->{count}");
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
int [] newarray=Convert1d(array);
Slovar(newarray);


