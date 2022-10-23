/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19].
получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();
*/

Console.Write("Введите 8 значений массива через запятую - ");

string[] stringArr = Console.ReadLine().Split(',');

int[] intArr = new int [stringArr.Length];

for (int i = 0; i < stringArr.Length; i++) {
    intArr[i] = int.Parse(stringArr[i]);
    if (i == 0) Console.Write($"[{intArr[i]},");
    else if (i == stringArr.Length - 1) Console.Write($"{intArr[i]}]");
    else Console.Write($"{intArr[i]},");
}