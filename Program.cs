using RPG_POO.src.Entities;

Knight knight = new Knight("Arus", 12, "Knight");
Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

Console.WriteLine(knight.Attack());
Console.WriteLine(wizard.Attack(10));