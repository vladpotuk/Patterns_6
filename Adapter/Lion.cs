using System;

public class Lion
{
    private string _name;
    private int _age;
    private string _color;
    private string _soundType;
    private string _habitat;

    public Lion(string name, int age, string color, string soundType, string habitat)
    {
        _name = name;
        _age = age;
        _color = color;
        _soundType = soundType;
        _habitat = habitat;
    }

    public void Roar()
    {
        Console.WriteLine($"{_name} the Lion roars: {_soundType}!");
    }
}
