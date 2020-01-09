using System;
using System.IO;

namespace textFil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exempelkommentaren
            Console.WriteLine("***** Exempel med StreamWriter *****");
            try
            {
                // Skapar en StreamWriter-objekt och skriver strängar.
                using (StreamWriter writer = new StreamWriter("citat.txt"))
                {
                    writer.WriteLine("Fantasi är viktigare än kunskap.");
                    writer.WriteLine("Tärningen är kastad.");
                    writer.WriteLine("Fånga dagen.");
                    // Lägger till två nya rader.
                    writer.Write(writer.NewLine);
                    writer.WriteLine();
                }
                Console.WriteLine("Skapade en fil med några citat...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ett oväntat fel inträffade.\n{0}",
                ex.Message);
            }

        }
    }
}
