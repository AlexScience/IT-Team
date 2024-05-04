namespace IT_Team.Analysts;

public class Analyst : Employee
{
    public string Specialization { get; set; }
    
    public Analyst(string name, Level level, string specialization) : base(name, level)
    {
        Specialization = specialization;
    }
}