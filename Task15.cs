// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите цифру дня недели от 1 до 7:");
int n = Convert.ToInt32(Console.ReadLine());
switch (n) {
    case 1:
        Console.WriteLine("Это понедельник, он не является выходным днем");
        break;
    case 2:
        Console.WriteLine("Это вторник, он не является выходным днем");
        break;
    case 3:
        Console.WriteLine("Это среда, она не является выходным днем");
        break;
    case 4:
        Console.WriteLine("Это четверг, он не является выходным днем");
        break;
    case 5:
        Console.WriteLine("Это пятница, она не является выходным днем");
        break;
    case 6:
        Console.WriteLine("Суббота - выходной день!!!");
        break;
    case 7:
        Console.WriteLine("Воскресенье - выходной день!!! Завтра понедельник :(");
        break;
    default:
        Console.WriteLine("Такого дня недели нет");
        break;
}
