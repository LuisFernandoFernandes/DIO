using DioRPG.Entities;
using DioRPG.src.Entities;

Knight knight = new Knight("Arus", 1, "Knight");
Wizard wizard = new Wizard("Jennca", 1, "Mago");
Ninja ninja = new Ninja("Afonso", 1, "Ninja");

Console.WriteLine(knight.Attack());
Console.WriteLine(wizard.Attack());
Console.WriteLine(wizard.Attack(2));
Console.WriteLine(ninja.Attack());