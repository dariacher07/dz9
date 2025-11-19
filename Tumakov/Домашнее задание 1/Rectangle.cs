public class Rectangle : Point
{
    protected double length { get; set; }
    protected double height { get; set; }

    public Rectangle(double x, double y, double w, double h)
        : base(x, y)
    {
        if (w > 0)
        {
            length = w;
        }
        else
        {
            length = 1;
        }
        if (h > 0)
        {
            height = h;
        }
        else
        {
            height = 1;
        }
    }
    public override double Square()
    {
        return length * height;
    }
    public override void Display()
    {
        string visibility;
        if (State)
        {
            visibility = "видимая";
        }
        else
        {
            visibility = "невидимая";
        }
        Console.WriteLine("Цвет " + Color);
        Console.WriteLine("Видимость " + visibility);
        Console.WriteLine("Площадь " + Square());
    }
}
