public class Beach: IGame
{
    public string GameName
    {
        get { return "Пляж"; }
    }
    public void Play(Team team)
    {
        Console.WriteLine($"Страна - {team} играет в {GameName}");
    }
}
public class Mousetrap : IGame
{
    public string GameName
    {
        get { return "Мышеловка"; }
    }
    public void Play(Team team)
    {
        Console.WriteLine($"Страна - {team} играет в {GameName}");
    }
}
public class Sea : IGame
{
    public string GameName
    {
        get { return "Море"; }
    }
    public void Play(Team team)
    {
        Console.WriteLine($"Страна - {team} играет в {GameName}");
    }
}
public class Fishing : IGame
{
    public string GameName
    {
        get { return "Рыбалка"; }
    }
    public void Play(Team team)
    {
        Console.WriteLine($"Страна - {team} играет в {GameName}");
    }
}
public class Postmens : IGame
{
    public string GameName
    {
        get { return "Почтальоны"; }
    }
    public void Play(Team team)
    {
        Console.WriteLine($"Страна - {team} играет в {GameName}");
    }
}
public class Slide : IGame
{
    public string GameName
    {
        get { return "Горка"; }
    }
    public void Play(Team team)
    {
        Console.WriteLine($"Страна - {team} играет в {GameName}");
    }
}
public class Quiz : IGame
{
    public string GameName
    {
        get { return "Квиз"; }
    }
    public void Play(Team team)
    {
        Console.WriteLine($"Страна - {team} играет в {GameName}");
    }
}