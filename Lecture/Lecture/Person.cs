﻿namespace Lecture;


public class Person
{
    public Person(string firstName, string lastName) : 
        this($"{firstName} {lastName}") {}

    public Person(string name) 
    {
        Initialize(name);
    }

    // Initializer... for explanation only.
    private void Initialize(string name)
    {
        Name = name;
    }

    public string ToText()
    {
        return $"{nameof(Name)}: {Name}";
    }

    public int Age { get; set; }


    public string? MiddelName { get; set; }


    private string? _Name;
    public System.String Name
    {
        get => _Name!;

        set { 
            if(value is null) { throw new ArgumentNullException(nameof(value)); }
            if(string.IsNullOrWhiteSpace(value)) { throw new ArgumentException(
                $"{nameof(Name)} cannot be an empty or whitespace.", nameof(value)); }
            _Name = value; 
        }
    }

    (string, string)[] Passwords = new[] { 
        ("Inigo Montoya", "YouKilledMyF@ther!")
    }; 

    public bool Login(string userName, string password)
    {
        return password == "YouKilledMyF@ther!";
    }
}
