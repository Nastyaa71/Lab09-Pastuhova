// // // int totalExercises = 8;
// // // for (int number = totalExercises; number >= 1; number--)
// // // {
// // //     Console.WriteLine($"Упражнение {number}");
// // // }
// // // Console.WriteLine("Домашние задание готово");

// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }

// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^");
// }

// int skippedTickets = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         skippedTickets++;
//         continue;
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}");
//     Console.WriteLine($"Пропущено билетов: {skippedTickets}");
//     break;
// }

// for (; ; )
// {
//     Console.WriteLine("Введите код группы (для выхода - 'выход'):");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "выход")
//     {
//         break;
//     }
//     Console.WriteLine($"Записан код группы: {groupCode}");
// }
// Console.WriteLine("Работа с журналом завершена");

int n = 20;
for (int i = 1; i <= n; i++)
{
    if (i%2 != 0)
    {
        Console.WriteLine(i);
    }
}

for (int i = 100; i >= 0; i -= 10)
{
    Console.WriteLine(i);
}

Console.WriteLine("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1,10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

for (int i = 1; i <= 100; i++)
{
    if (i%3==0 && i%5 == 0)
    {
        Console.WriteLine($"Первое число: {i}");
        break;
    }
}

for (int i = 1; i <= 30; i++)
{
    if (i%4 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}

