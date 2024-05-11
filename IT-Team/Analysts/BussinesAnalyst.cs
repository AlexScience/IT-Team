using IT_Team.Specialization;

namespace IT_Team.Analysts;

public record BussinesAnalyst : Analyst
{
    public BussinesAnalyst(string name, Level level) : base(name, level,AnalystSpecialization.BA)
    {
    }
}