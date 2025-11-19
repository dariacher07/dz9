public class Circle : Point
{
    private double r { get; set; }
    public Circle(double x, double y, double r) : base(x, y)
    {
        if (r > 0)
        {
            this.r = r;
        }
        else
        {
            this.r = 1; 
        }
    }
    public override double Square()
    {
        return Math.PI * r * r;
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
