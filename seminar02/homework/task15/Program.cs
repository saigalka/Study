// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void DayWeek (int day)
{
    switch (day) {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine ("НЕ-Е-ЕТ, этот день рабочий, увы.");
            break;
        case 6:
        case 7:
            Console.WriteLine ("ДА-А, это выходной, возрадуйтесь.");
            break;
        default:
            Console.WriteLine ("Введено неверное значение.");
            break;
    }
}

Console.WriteLine("Введите день недели, от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
DayWeek(num);