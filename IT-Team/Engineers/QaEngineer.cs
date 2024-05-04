namespace IT_Team.Engineers;

public class QaEngineer : Employee
{
    public string Specialization { get; set; }
    
    public QaEngineer(string name, Level level, string specialization) : base(name, level)
    {
        Specialization = specialization;
    }
}