using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Facultate UEO = new Facultate("UEO");
            UEO.Students = new Student[] { new Student("Petrila", "Damaris", new DateTime(2001, 08, 03), "123456789" ),
                                           new Student("Daniel", "Andrei", new DateTime(2002, 01, 02), "987654321"),
                                           new Student("Samuel", "Bodogan", new DateTime(2002, 08, 09), "91837465")};

            Console.WriteLine(UEO.Index("123456789"));





        }
    }
}
