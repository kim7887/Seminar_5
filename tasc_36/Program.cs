//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] Arr;
int lenArr;
string str = "";


void initArr(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = Random.Shared.Next(-100, 100);
        str += Arr[i] + ", ";
    }
    Console.WriteLine($"Исходный массив: {str}");
}
int countSum(int[] Arr)
{
    int count = 0;
    for (int i = 1; i < Arr.Length; i += 2) 
    {
        count += Arr[i];
    }
    return count;
}

while (true)
{
    
    Console.WriteLine("Введите размер массива. (0 - для выхода)");
    if (!Int32.TryParse(Console.ReadLine(), out lenArr))
    {
        Console.WriteLine("Не число!");
        continue;
    }
    if (lenArr == 0) { break; }
    Arr = new int[lenArr];
    initArr(Arr);
    Console.WriteLine($"Сумма на нечетных позициях: {countSum(Arr)}");
}