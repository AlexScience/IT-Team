using IT_Team.Analysts;
using IT_Team.Developers;
using IT_Team.Engineers;

namespace IT_Team;

public class Printer : Employee
{
    // Метод для вывода общей информации о сотруднике
    public void PrintEmployeeInfo(Employee employee)
    {
        Console.WriteLine($"Name: {employee.Name}");
        Console.WriteLine($"Level: {employee.Level}");
        
    }

    // Метод для вывода информации о разработчике
    public void PrintDeveloperInfo(Developer developer)
    {
        Console.WriteLine("Developer: ");
        PrintEmployeeInfo(developer);
        Console.WriteLine($"Specialty: {developer.Specialty}");
        Console.WriteLine();
    }

    // Метод для вывода информации об инженере QA
    public void PrintQAEngineerInfo(QaEngineer qaEngineer)
    {
        Console.WriteLine("Engineer:");
        PrintEmployeeInfo(qaEngineer);
        Console.WriteLine($"Specialization: {qaEngineer.Specialization}");
        Console.WriteLine();
    }

    // Метод для вывода информации об аналитике
    public void PrintAnalystInfo(Analyst analyst)
    {
        Console.WriteLine("Analyst:");
        PrintEmployeeInfo(analyst);
        Console.WriteLine($"Specialization: {analyst.Specialization}");
        Console.WriteLine();
    }
}