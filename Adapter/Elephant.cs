using System;
public class Elephant
{
    private string _name;
    private int _age;
    private string _color;
    private string _soundType;
    private string _habitat;

    public Elephant(string name, int age, string color, string soundType, string habitat)
    {
        _name = name;
        _age = age;
        _color = color;
        _soundType = soundType;
        _habitat = habitat;
    }

    public void Trumpet()
    {
        Console.WriteLine($"{_name} the Elephant trumpets: {_soundType}!");
    }
}
