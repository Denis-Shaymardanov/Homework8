//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
//наименьшей суммой элементов: 1 строка
int SmallestAmountRow(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1); 
    int result = 0;
    int minSum = 0;
    for(int i=0;i<rows;i++)
    {   
        int sum = 0; 
        for(int j=0;j<cols;j++)
        {
            sum = sum + array[i,j];        
        }
        if((i==0)||(sum<minSum)) 
        {
            minSum = sum;
            result = i;
        }
    }  
    return result + 1;
}; 

int[,] array = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7}
};
Console.WriteLine($"Строка с наименьшей суммой элементов: {SmallestAmountRow(array)}");