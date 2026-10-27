public record Dog(string Name);
public record Cat(string Name);
public record Fish(string kind);

public union HomePets(Dog, Cat, Fish);

internal class Program
{
    private static void Main(string[] args)
    {
        List<HomePets> pets = new List<HomePets>();

        HomePets pet = new Dog("Buddy");
        pets.Add(pet);
        HomePets cat = new Cat("Whiskers");
        pets.Add(cat);
        HomePets fish = new Fish("Goldfish");
        pets.Add(fish);


        foreach (var p in pets)
        {
            var message = p switch
            {
                Dog d => $"Dog: {d.Name}",
                Cat c => $"Cat: {c.Name}",
                Fish f => $"Fish: {f.kind}",
            };
            Console.WriteLine(message);
        }
    }
}




