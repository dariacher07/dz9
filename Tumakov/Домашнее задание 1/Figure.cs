public abstract class Figure
{
    public string Color { get; set; }
    public bool State { get; set; }
    public Figure()
    {
        Color = "Black";
        State = true;
    }
    public void Colors(string color)
    {
        Color = color;
    }
    public void States(bool state)
    {
        State = state;
    }
    public abstract double Square();
    public abstract void Horizontal(double x);
    public abstract void Vertical(double y);
    public abstract void Display();
}
