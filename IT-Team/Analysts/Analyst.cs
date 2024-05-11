using IT_Team.Engineers;
using IT_Team.Specialization;

namespace IT_Team.Analysts;

public record Analyst : Engineer
{
    public AnalystSpecialization Specialization { get; set; }
    
    public Analyst(string name, Level level, AnalystSpecialization specialization) : base(name,level)
    {
        Specialization = specialization;
    }
}