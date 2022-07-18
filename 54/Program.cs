//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8
int[,] ArrangeArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<cols-1;j++)
        {for (int h=j+1;h<cols;h++)
            {
                if(array[i,j]<array[i,h])
                {
                    int x=array[i,j];
                    array[i,j]=array[i,h];
                    array[i,h]=x;
                }   
            }
        }
    }
    return array;
};

void PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1); 
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }  
}; 

int[,] array = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};
PrintArray(ArrangeArray(array));
