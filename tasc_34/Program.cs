//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] Arr;
int lenArr;

// Функция заполнение массива рандомными числами
void initArr(int[] Arr){
	for (int i = 0; i < Arr.Length; i++){
		Arr[i] = Random.Shared.Next(100, 999);
	}
}

// Функция подсчета кол-ва положительных чисел
int countEven (int[] Arr) {
	int count = 0;
	for (int i = 0; i < Arr.Length; i++) {
		if ((Arr[i] & 0x01) == 0) { count++; }
	}
	return count;
}

// Основная программа
while (true)
{
	// Ввод данных
	Console.WriteLine("Введите размер массива. (0 - для выхода)");
	if (!Int32.TryParse(Console.ReadLine(), out lenArr)) {
        Console.WriteLine("Не число!");
		continue; 
	}

	// Условие выхода
	if (lenArr == 0) { break; }
	
	// Выполнение условия задания
	Arr = new int[lenArr];
	initArr(Arr);

	// Вывод на экран
    Console.WriteLine($"Четных чисел в массиве: {countEven(Arr)}");
}