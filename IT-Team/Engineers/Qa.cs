using IT_Team.Specialization;

namespace IT_Team.Engineers;

public record Qa : Engineer
{
    public QASpecialization Specialization { get; set; }

    public Qa(string name, Level level, QASpecialization specialization) : base(name, level)
    {
        Specialization = specialization;
    }
}