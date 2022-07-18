//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы 
//каждого элемента.
//массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
int[,,] FillArray(int m1, int m2, int m3)
{
    int size = m1*m2*m3; //количество элементов массива
    int[] numbers = new int [size]; //массив случайных неповторяющимихся чисел
    var rnd = new Random();

    for(int i=0;i<size;i++)
    {
        numbers[i]=rnd.Next(10,100);
        if(i==0) continue;
        for(int j=0;j<i;j++)
        {
            while (numbers[i] == numbers[j])
            {
                numbers[i] = new Random().Next(10, 100);
                j = 0;
            }
        }
    }

    int[,,] result = new int[m1,m2,m3];
    int count = 0;
    for(int i=0; i<m1; i++)
    {  
        for(int j=0; j<m2; j++)
        {  
            for(int k=0; k<m3; k++)
            {  
                result[i,j,k]=numbers[count];
                count++;
            } 
        }    
    }
    return result;
}

void PrintArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array[i,j,k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
  }
}

Console.WriteLine("Введите размерность массива X x Y x Z");
Console.WriteLine("Введите X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z");
int z = Convert.ToInt32(Console.ReadLine());
if(x*y*z>90) 
{
    Console.WriteLine("Вы ввели слишком большую размерность");
    return;
}
PrintArray(FillArray(x,y,z));