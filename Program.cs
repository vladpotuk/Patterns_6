using System;

class Program
{
    static void Main(string[] args)
    {
        
        Lion lion = new Lion("Simba", 5, "golden", "Roar", "savannah");
        Elephant elephant = new Elephant("Dumbo", 10, "gray", "Trumpet", "jungle");

        
        IAnimal lionAdapter = new LionAdapter(lion);
        IAnimal elephantAdapter = new ElephantAdapter(elephant);

      
        lionAdapter.MakeSound();
        elephantAdapter.MakeSound();

        Console.ReadKey();
    }
}
