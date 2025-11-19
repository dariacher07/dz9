class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 1");
        ACipher aCipher = new ACipher();
        BCipher bCipher = new BCipher();
        string line = "Технологии программирования";
        Console.WriteLine($"строка без изменений: {line}");
        string line1 = aCipher.Encode(line);
        string line2 = aCipher.Decode(line1);
        Console.WriteLine($"Зашифровано: {line1}");
        Console.WriteLine($"Расшифровано: {line2}");
        string line3 = bCipher.Encode(line);
        string line4 = bCipher.Decode(line3);
        Console.WriteLine($"Зашифровано: {line3}");
        Console.WriteLine($"Расшифровано: {line4}");
        Console.WriteLine("Домашнее задание 1");
        Point point = new Point(5, 10);
        point.Color = "Зеленый";
        point.State = true;
        Circle circle = new Circle(5, 10, 15);
        circle.Color = "Синий";
        circle.State = true;
        Rectangle rectangle = new Rectangle(5, 10, 15, 20); 
        rectangle.Color = "Голубой";
        rectangle.State = true;
        point.Horizontal(5);
        circle.Vertical(5);
        rectangle.Horizontal(5);
        rectangle.Vertical(5);
        point.Display();
        circle.Display();
        rectangle.Display();
    }
}