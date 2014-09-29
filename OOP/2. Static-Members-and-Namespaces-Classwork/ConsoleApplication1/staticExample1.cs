using System;

class Person
{
    private static int instanceCounter = 0; // cant access it because its private; go line 8
    private static DateTime startDate; // make it static to go in Person; go to line 21
    public string Name { get; set; }
    public static int InstanceCounter // have no set because must not be changeable for outside
    {
        get
        {
            return Person.instanceCounter;
        }    
    }

    // constructor
    public Person(string name = null) // null for optional
    {
        this.Name = name;
        Person.instanceCounter++; // but can use it
        Person.startDate = DateTime.Now; // this will keep first start
    }

    // instead of upper constructor
    // you can call 
    // auto-constructor,
    // it will be runned once only
    // when using the class (Person)
    // and before calling the class.
    // If the class(Person) is not in use 
    // the auto constructor will not be called(not used)
    static Person()
    {
        Console.WriteLine("Im a static constructor"); // go to line 6 and made a DateTime startDate
    }

    // The static constructor is usable when 
    // a big calculation should be made and 
    // we must have it ready for use (this will be just once).
    
    // This is Precomputation: part of calculations to be ready for use!

    // This is a pattern for speeding up (Leazy Load Pattern)
    // when making a lot of big calculations. Ex: Sqrt(3000000)
    
    // see static members example - slide 8 and 9 or the Demo

    // usable when reading cards from a file


}

class Test
{
    static void Main()
    {
        Person p = new Person("Pesho");
        Console.WriteLine(p.Name);

        Person empty = new Person();
        Console.WriteLine(empty.Name);

        // to use this  must do a prop; create line 8
        Console.WriteLine("Count: " + Person.InstanceCounter);
    }
}