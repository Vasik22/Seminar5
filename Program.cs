// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] numbers = new int[10];

// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 150);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }

//  FillArrayRandomNumbers(numbers);

// int QuantityPositive(int[] array){
//     int quantity = 0;
//     for (int i = 0; i<array.Length; i++ ){
//     if (array[i] % 2 == 1)
//     {
//       quantity++;
//     }
//   }
//   return quantity;
// }
// int quantity = QuantityPositive(numbers);
// Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
// конец


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] numbers = new int[12];

// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }

// FillArrayRandomNumbers(numbers);

// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 1)
//         sum += numbers[i];
// }
// Console.WriteLine($"Сумма нечетных чисел = {sum}");

// конец
  


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] numbers = new int[6];

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.WriteLine(String.Join(" ", array));
}

FillArrayRandomNumbers(numbers);


Array.Reverse(numbers);
int []arrayreverse;
arrayreverse = numbers;
Console.WriteLine(string.Join(" ", arrayreverse));


 
     int[] mass3 = new int[3];
     int j;
      mass3[j] = numbers[j] * arrayreverse[j];
            for (int j = 0; j < 3; j++)
            {
                mass3[j] = numbers[j] * arrayreverse[j];
                Console.Write(mass3[j] + " ");
            }
            

    

//Console.WriteLine(string.Join(" ", thirdArray));
   

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int size = 10;
// int[] number = new int[size];
// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 99);
//     }
//     Console.WriteLine(String.Join(" ", array));
// }
// FillArrayRandomNumbers(number);
// int max = number[0];
// int min = number[0];

// for (int i = 0; i < number.Length; i++)
// {
//     if (number[i] > max)
//     {
//         max = number[i];
//     }
//     else if (number[i] < min)
//     {
//         min = number[i];
//     }
// }
// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Минимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max - min}");

// конец
