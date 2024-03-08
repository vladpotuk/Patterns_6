using System;

public class ElephantAdapter : IAnimal
{
    private readonly Elephant _elephant;

    public ElephantAdapter(Elephant elephant)
    {
        _elephant = elephant;
    }

    public void MakeSound()
    {
        _elephant.Trumpet();
    }
}
