using System;
using IT_Team;
using IT_Team.Analysts;
using IT_Team.Developers;
using IT_Team.Liders;
using IT_Team.Engineers;


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

List<Employee> employees = new List<Employee>
{
    backendDeveloper,
    webDeveloper,
    iOSDeveloper,
    androidDeveloper,
    manualQaEngineer,
    autoQaEngineer,
    systemAnalyst,
    businessAnalyst,
    teamLead
};

foreach (var employee in employees)
{
    Console.WriteLine(employee);
}