class Program
{
	static void Main()
	{
		Pet pet = new Pet("Rufus", "hund");
		Person person = new Person("Kim", pet);

		person.Present();
	}
}

class Person
{
	public string Name { get; private set; }
	public Pet Pet { get; private set; }

	public Person(string name, Pet pet) => (Name, Pet) = (name, pet);

	public void Present() => Console.WriteLine($"Hej jag heter {Name} och mitt husdjur heter {Pet.Name} och är en {Pet.Species}");
}

class Pet
{
	public string Name { get; private set; }
	public string Species { get; private set; }

	public Pet(string name, string species) => (Name, Species) = (name, species);
}