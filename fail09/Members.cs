public class Members
{
    public List<Team> Countries { get; set; } = new List<Team>();
    public List<IGame> Games { get; set; } = new List<IGame>();

    public Members()
    {
        Countries.Add(new Team("Россия"));
        Countries.Add(new Team("Франция"));
        Countries.Add(new Team("Китай"));
        Countries.Add(new Team("Казахстан"));
        Games.Add(new Beach());
        Games.Add(new Mousetrap());
        Games.Add(new Sea());
        Games.Add(new Fishing());
        Games.Add(new Postmens());
        Games.Add(new Slide());
        Games.Add(new Quiz());
    }
    public void BigRaces()
    {
        List<IGame> listGames = new List<IGame>(Games);
        List<IGame> uniqueGames = new List<IGame>();
        Random random = new Random();
        for (int i = 0; i < 6; i++)
        {
            int index = random.Next(listGames.Count);
            IGame gameName = listGames[index];
            uniqueGames.Add(gameName); //добавляем игру
            listGames.RemoveAt(index); // удаляем из списка, чтобы не было повторений
        }
        foreach (IGame game in uniqueGames)
        {
            foreach (Team team in Countries)
            {
                game.Play(team);
            }
        }

    }
}
