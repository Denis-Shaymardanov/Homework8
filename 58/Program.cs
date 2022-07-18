//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.
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

void Multiplication(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    if (cols1!=rows2) 
        Console.WriteLine("Данные матрицы перемножить нельзя");

    int[,] result=new int[rows1,cols2];

    for (int i=0; i<rows1; i++)
    {
        for (int j=0; j<cols2; j++)
        {
            for (int h=0; h<rows1; h++)
            {
                result[i,j]+=matrix1[i,h] * matrix2[h,j];
            }
        }
    }
    PrintArray(result);
}

int[,] matrix1 = new int[,]
{
    {0,9,1},
    {1,3,7},
    {2,7,0},
};
int[,] matrix2 = new int[,]
{
    {0,9,8},
    {0,9,9},
    {1,9,6},
};
Multiplication(matrix1,matrix2);
