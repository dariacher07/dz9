public class Team
{
    public string Country { get; set; }
    public int MembersCount { get; set; } = 15; 
    public Team(string country)
    {
        Country = country;
    }
    public override string ToString()
    {
        return Country;
    }
}
