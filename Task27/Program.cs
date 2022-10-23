/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber (string message) {
    int userNumber;
    while (true) {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int number)) {
            userNumber = number;
            break;
        }    
        else {
            Console.WriteLine($"{number} не является числом, повторите ввод.");
        }
    } 
    return userNumber;
}

int aNumber = GetNumber("Введите число A - ");
int tmp = aNumber;
int answer = 0;

while (tmp != 0) {
    answer = answer + tmp % 10;
    tmp = tmp / 10;
}

Console.WriteLine($"Сумма цмфр в числе {aNumber} = {answer}.");
