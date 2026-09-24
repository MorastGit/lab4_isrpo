Console.Write("Введите свое имя: ");
string name1 = Console.ReadLine();
Console.WriteLine($"Привет, {name1}");
string name_author = "Козубенко Елена";
string group = "ИСП-241";
string date_time = "на момент создания сегодня\n24 сент 9:26";

string menu = "--------------------\n" +
              "1 — Показать ФИО\n2 — Показать группу\n" +
              "3 — Показать дату\n4 — Выход";

bool active = true;
Console.WriteLine(menu);
while (active)
{
    Console.Write("--------------------\n" +
                  "Ввести цифру: ");
    int input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1: Console.WriteLine(name_author); break;
        case 2: Console.WriteLine(group); break;
        case 3: Console.WriteLine(date_time); break;
        case 4: active = false;
            Console.WriteLine("Пока!"); break;
        default: Console.WriteLine("Такой команды нет"); 
            Console.WriteLine(menu); break;
    } 
}

