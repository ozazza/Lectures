using System;


// creating enum: save from non-valid data 
public enum DayOfWeek
{
	Mon, Tue, Wed, Thu, Fri, Sat, Sun
}

class EnumExample
{
	static void Main()
	{
		DayOfWeek day = DayOfWeek.Wed; // this is an instance of enum DayOfWeek
		Console.WriteLine(day); // Wed
		
		Console.WriteLine((int)day); // 2

		day = DayOfWeek.Sat;
        Console.WriteLine(++day); // Sun
        Console.WriteLine(++day); // 7  we can go outside from enum(deffect of enums)

        // parsing: if user input "Mon" and we want to take the value
		day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Mon"); 
		Console.WriteLine(day); // Mon
	}
}
