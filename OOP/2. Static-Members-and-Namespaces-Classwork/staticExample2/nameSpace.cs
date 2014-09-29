using System;
using Vacheva;
using Vacheva.Data;

class MainProgram
{
    static void Main()
    {
        // long version
        Vacheva.Data.Student s = new Vacheva.Data.Student();

        //short version: add "using Vacheva.Data;"
        Student m = new Student();



        Functions p = new Functions();
    }
}

// GOOD PRACTICES:

// each namespace has 1 directory
// each class has separate file