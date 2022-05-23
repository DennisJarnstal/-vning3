using Övning3;

PersonHandler personHandler = new PersonHandler();
Person mikael = new Person();
Person david = new Person();
Person anna = new Person();

try {
    
mikael = personHandler.CreatePerson(45, "Mikeal", "Mikaelsson", 1.75, 65.3);

david = personHandler.CreatePerson(35, "David", "Davidsson", 1.85, 70.2);

anna = personHandler.CreatePerson(65, "Anna", "Klonk", 1.65, 80.4);
}
catch
{
    Console.WriteLine("Något gick fel, vänligen försök igen");
}

try { 
personHandler.SetAge(mikael, 46);
personHandler.SetFirstName(mikael, "Mikael");
personHandler.SetLastName(mikael, "Larsson");
personHandler.SetHeight(david, 1.84);
personHandler.SetWeight(anna, 75.6);
}
catch
{
    Console.WriteLine("Något gick fel, vänligen försök igen");
}

UserError listTextInputError = new TextInputError();
UserError listNumericInputError = new NumericInputError();

List<UserError> errors = new List<UserError>();

errors.Add(listTextInputError);
errors.Add(listNumericInputError);

foreach (UserError error in errors)
{
    Console.WriteLine(error + $"\n");
}

Horse Brownlightning = new Horse("Brownlightning", 190.45, 12, true, "fields", "brown", 65.7);
Horse Brownlightning2 = new Horse("Brownlightning2", 190.45, 12, true, "fields", "brown", 65.7);
Wolf Wolfmanboy = new Wolfman("Wolfman", 190.45, 12, true, "fields", "brown", true);
Dog Voofy = new Dog("Voofy", 190.45, 12, true, "fields", "brown", "German sheperd");

List<Animal> Animals = new List<Animal>();
Animals.Add(Brownlightning);
Animals.Add(Brownlightning2);
Animals.Add(Wolfmanboy);

foreach (Animal animal in Animals)
{
    if (animal is IPerson)
    {
        Console.WriteLine(animal.Stats());
        IPerson person = (IPerson) animal;
        Console.WriteLine(person.Talk() + $"\n");
    }
    else
    {
        Console.WriteLine(animal.Stats() + $"\n");
    }
}

List<Dog> Dogs = new List<Dog>();
Dogs.Add(Voofy);

foreach (Dog dog in Dogs)
{
    Console.WriteLine(dog.Stats() + $"\n");
    dog.Run();
}

