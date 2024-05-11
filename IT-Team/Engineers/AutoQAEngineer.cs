using IT_Team.Specialization;

namespace IT_Team.Engineers;

public record AutoQaEngineer : Qa
{
    public AutoQaEngineer(string name, Level level) : base(name, level,QASpecialization.AutoTesting)
    {
    }
}