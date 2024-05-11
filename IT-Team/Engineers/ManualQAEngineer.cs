using IT_Team.Specialization;

namespace IT_Team.Engineers;

public record ManualQaEngineer : Qa
{
    public ManualQaEngineer(string name, Level level) : base(name, level, QASpecialization.ManualTesting)
    {
    }
}