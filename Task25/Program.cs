/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber (string message) {
    int userNumber;
    while (true) {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int number) && number > 0) {
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
int bNumber = GetNumber("Введите число B - ");
int answer = 1;

for (int i = 1; i <= bNumber; i++) {
    answer = answer * aNumber;
}

Console.WriteLine($"{aNumber} ^ {bNumber} = {answer}.");
