// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] CountInputMoreZero()
{
    string[] inputNum = { string.Empty, "0" };
    int counter = 0;
    while (inputNum[1] != string.Empty)
    {
        Console.Write("Введите число для продолжения, иначе нажмите Enter: ");
        inputNum[1] = Console.ReadLine();
        if (inputNum[1].Length > 0)
        {
            if (Convert.ToInt32(inputNum[1]) > 0)
                counter++;
            inputNum[0] += $" {inputNum[1]} ";
        }
    }
    inputNum[1] = counter.ToString();
    return inputNum;
}

string[] inputNumber = CountInputMoreZero();
System.Console.WriteLine($"Введённые числа - [ {inputNumber[0]}] из них {inputNumber[1]} больше нуля");



