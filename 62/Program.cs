//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
void PrintArray (string[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

string[,] FillArray(int size)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    string[,] result = new string[size, size];
    
    while (temp<=size*size)
    {
        if(temp/10==0) result[i, j]="0"+temp.ToString();
        else result[i, j]=temp.ToString();
        temp++;
        if (i<=j+1 && i+j<size-1)
        j++;
        else if (i<j && i+j>=size-1)
        i++;
        else if (i>=j && i+j>size-1)
        j--;
        else
        i--;
    }
    return result;
}

PrintArray(FillArray(4));
