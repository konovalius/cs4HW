/*Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
Console.Write("Введите минимальное значение:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение:");
int max = Convert.ToInt32(Console.ReadLine());
int size = 8;
int[] Array (int size, int min,int max)
{
    int []res = new int [8];
    for (int i=0 ; i< size; i++)
    {
        res[i]=new Random().Next(min,max+1);
    }
    return res;
}
int [] arr= Array(size,min,max);
void PrintArray (int [] arr)
{
    for (int i = 0; i<arr.Length;i++)
    {
        Console.Write(arr[i]);
        if(i<arr.Length-1)
        {
            Console.Write(",");
        }
    }
Console.WriteLine();
}
PrintArray(arr);