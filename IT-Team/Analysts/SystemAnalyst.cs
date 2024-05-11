using IT_Team.Specialization;

namespace IT_Team.Analysts;

public record SystemAnalyst : Analyst
{
    public SystemAnalyst(string name, Level level) : base(name, level,AnalystSpecialization.SA)
    {
    }
}