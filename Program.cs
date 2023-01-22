/*
Задача HARD SORT необязательная. Считается за три обязательных
Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

Например, задан массив:
1 4 7 2
5 9 10 3

После сортировки
1 2 3 4
5 7 9 10
*/


Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[row,col];


FillArray(array);
PrintArray(array);
SortRowArray(array);
//PrintSortRowArray(array);
SortColArray(array);
PrintSortColArray(array);


void FillArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
for (int j=0;j<array.GetLength(1);j++)
array[i,j] = new Random().Next(-10,11);
}


void PrintArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
{
for (int j=0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],3} \t");
Console.WriteLine();
}Console.WriteLine();}



void SortRowArray(int[,] array)
{
for (int i = 0; i < col; i++)
{
for (int j = 0; j < row; j++)
{
for (int k = 0; k < col; k++)
{
if (array[i, j] < array[i, k])
{
int tmp = array[i,j];
array[i,j] = array[i,k];
array[i,k] = tmp;
}
                    }
                }
            }
}


/*
void PrintSortRowArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
{
for (int j=0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],3} \t");
Console.WriteLine();
}}
*/


void SortColArray(int[,] array)
{
for (int i = 0; i < col; i++)
{
for (int j = 0; j < row; j++)
{
for (int k = 0; k < row; k++)
{
if (array[i, j] < array[k, j])
{
int tmp = array[i,j];
array[i,j] = array[k,j];
array[k,j] = tmp;
}
                    }
                }
            }
}
void PrintSortColArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
{
for (int j=0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],3} \t");
Console.WriteLine();
}}