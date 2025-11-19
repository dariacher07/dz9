public class Point : Figure
{
    private double x { get; set; }
    private double y { get; set; }
    public Point(double x = 0, double y = 0)
    {
        this.x = x;
        this.y = y;
    }
    public override void Horizontal(double x)
    {
        this.x += x;
    }
    public override void Vertical(double y)
    {
        this.y += y;
    }

    public override double Square()
    {
        return 0;
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
