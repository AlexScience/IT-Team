using IT_Team;
using IT_Team.Analysts;
using IT_Team.Developers;
using IT_Team.Liders;
using IT_Team.Engineers;

var printer = new Printer();

var teamLead = new TeamLead("John Doe");

var backendDeveloper = new BackendDeveloper("Alice Smith", Level.Senior);
var webDeveloper = new WebDeveloper("Bob Johnson", Level.Middle);
var iOSDeveloper = new IosDeveloper("Eve Brown", Level.Junior);
var androidDeveloper = new AndroidDeveloper("Ikarin Afanaseva", Level.Middle);
var manualQaEngineer = new ManualQaEngineer("Chris Lee", Level.Middle);
var autoQaEngineer = new AutoQaEngineer("Diana White", Level.Senior);
var systemAnalyst = new SystemAnalyst("Grace Davis", Level.Senior);
var businessAnalyst = new BussinesAnalyst("Henry Miller", Level.Middle);

// Вывод информации о каждом члене команды

Console.WriteLine("Team Lead:");
printer.PrintEmployeeInfo(teamLead);
Console.WriteLine();


printer.PrintDeveloperInfo(backendDeveloper);

printer.PrintDeveloperInfo(androidDeveloper);

printer.PrintDeveloperInfo(webDeveloper);

printer.PrintDeveloperInfo(iOSDeveloper);

printer.PrintQAEngineerInfo(manualQaEngineer);

printer.PrintQAEngineerInfo(autoQaEngineer);

printer.PrintAnalystInfo(systemAnalyst);

printer.PrintAnalystInfo(businessAnalyst);


