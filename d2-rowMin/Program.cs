// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

for(int i = 0; i < arr.GetLength(0); i++)
{
  int temp = 0;
  for(int j = 0; j < arr.GetLength(1); j++)
  {
    for(int k = j + 1; k < arr.GetLength(1); k++)
    {
      if (arr[i,j] > arr[i,k])
      {
        temp = arr[i,j];
        arr[i,j] = arr[i,k];
        arr[i,k] = temp;
      }
    }
  }
    Console.WriteLine();
}

PrintArray(arr);