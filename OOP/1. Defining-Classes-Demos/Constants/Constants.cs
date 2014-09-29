using System;

public class Constants
{
    // Two types: const or readonly

    // const: During the compilation are replaced by their value:
	public const double PI = 3.1415926535897932385;
	
    // readonly: Can be assigned once only, at object creation:
    public readonly double Size;

    // Constructor
	public Constants(int size)
	{
		this.Size = size; // Cannot be further modified!
	}

	static void Main()
	{
		Console.WriteLine(Constants.PI);
		Constants c = new Constants(5);
		Console.WriteLine(c.Size);
		
		//c.Size = 10; // Compilation error: readonly field
		//Console.WriteLine(Constants.Size); // compile error
	}
}
