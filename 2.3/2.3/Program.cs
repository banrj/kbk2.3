// Богомолов Даниил вариант 13


Console.WriteLine("Введите вариант чисел от 1 до 3:");
int variant = int.Parse(Console.ReadLine());

switch (variant)
{

    case 1:
        double x = 3.2;
        double y = -7;
        double z = 0.5;
        double average = (x + y + z) / 3;
        Console.WriteLine("Среднее арефмитическое равно: " + average);
        if (Math.Abs(x) > average)
            Console.WriteLine(x + " Больше среднего аревметического");
        if (Math.Abs(y) > average)
            Console.WriteLine(y + " Больше среднего аревметического");
        if (Math.Abs(z) > average)
            Console.WriteLine(z + " Больше среднего аревметического");
        break;

    case 2:
        double x2 = 2.3, y2 = 3, z2 = 2.5;
        double average2 = (x2 + y2 + z2) / 3;
        Console.WriteLine("Среднее арефмитическое равно: " + average2);
        if (Math.Abs(x2) > average2)
            Console.WriteLine(x2 + " Больше среднего аревметического");
        if (Math.Abs(y2) > average2)
            Console.WriteLine(y2 + " Больше среднего аревметического");
        if (Math.Abs(z2) > average2)
            Console.WriteLine(z2 + " Больше среднего аревметического");
        break;
    case 3:
        double x3 = 23, y3 = -34, z3 = 89.5;
        double average3 = (x3 + y3 + z3) / 3;
        Console.WriteLine("Среднее арефмитическое равно: " + average3);
        if (Math.Abs(x3) > average3)
            Console.WriteLine(x3 + " Больше среднего аревметического");
        if (Math.Abs(y3) > average3)
            Console.WriteLine(y3 + " Больше среднего аревметического");
        if (Math.Abs(z3) > average3)
            Console.WriteLine(z3 + " Больше среднего аревметического");
        break;

    default:
        Console.WriteLine("Вы велли неверное значение");
        break;

}



