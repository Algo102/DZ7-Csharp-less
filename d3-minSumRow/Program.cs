// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int[] sum = new int[m];

//Подсчет суммы строк и запись результата в одномерный массив
for(int i = 0; i < arr.GetLength(0); i++)
{
  int summ = 0;
  for(int j = 0; j < arr.GetLength(1); j++)
  {
    summ = summ + arr[i,j];
  }
  sum[i] = summ;
}

Console.WriteLine();

Console.WriteLine("Сумма строк");
for(int i = 0; i < sum.Length; i++)
{
  Console.Write(sum[i] + " ");    
}

Console.WriteLine();

//Вариант, когда результат в одномерном массиве сортируется и выводится 0 элемент
// int temp = 0;
// for(int i = 0; i < sum.Length; i++)
// {
//   for(int j = i + 1; j < sum.Length; j++)
//   {
//     if (sum[i] > sum[j])
//     {
//       temp = sum[i];
//       sum[i] = sum[j];
//       sum[j] = temp;
//     }
//   }
// }
// Console.WriteLine();

// for(int i = 0; i < sum.Length; i++)
// {
//   Console.Write(sum[i] + " ");    
// }

// Console.WriteLine();

// Console.WriteLine(sum[0]);


//Второй вариант, по проще без сортировки
int min = sum[0];
for(int i = 0; i < sum.Length; i++)
{
  if (min > sum[i])
  {
    min = sum[i];
  }
}

Console.WriteLine();

Console.WriteLine("Минимальнная сумма элементов в строке " + min);