/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
System.Console.Write("введите размер массива: ");
int size = Convert.ToInt32(System.Console.ReadLine());
int[] getBinaryarray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.Write("введите массив из 8-ми элементов: ");
        result[i] = Convert.ToInt32(System.Console.ReadLine());
    }
    return result;
}
int [] testArray = getBinaryarray(size);
System.Console.Write($"Результат: [ {String.Join("; ", testArray)}]"  );


