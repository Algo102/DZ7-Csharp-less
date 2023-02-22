// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

int[,] CreateArr(int[,] array)
{
  Random rnd = new Random();
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = rnd.Next(1,5);
    }
  }
  return array;
}

void PrintArray(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + "  ");
    }
    Console.WriteLine();
  }
}

int IntNumber(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int m = IntNumber("Введите количество строк в массиве ");
int n = IntNumber("Введите количество столбцов в массиве ");

int[,] arr = new int[m,n];
CreateArr(arr);
PrintArray(arr);

int[] sum = new int[n];

for(int i = 0; i < arr.GetLength(1); i++)
{
  int summ = 0;
  for(int j = 0; j < arr.GetLength(0); j++)
  {
    summ = summ + arr[j,i];
  }
  
  sum[i] = summ;
  //Console.Write(summ + " ");    
}

Console.WriteLine();

for(int i = 0; i < sum.Length; i++)
{
  Console.Write(sum[i] + " ");    
}
