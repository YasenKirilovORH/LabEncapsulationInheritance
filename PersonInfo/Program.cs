using PersonInfo;

using System;
using System.Collections.Generic;
using System.Linq;

int lines = int.Parse(Console.ReadLine()!);

List<Person> persons = new List<Person>();
for (int i = 0; i < lines; i++)
{
    string[] cmd = Console.ReadLine()!.Split();
    string firstName = cmd[0];
    string lastName = cmd[1];
    int age = int.Parse(cmd[2]);

    Person person = new Person(firstName, lastName, age);
    persons.Add(person);
}

persons
    .OrderBy(p => p.FirstName)
    .ThenBy(p => p.Age)
    .ToList()
    .ForEach(Console.WriteLine);
