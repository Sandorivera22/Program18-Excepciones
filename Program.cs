namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Leccion 22-Excepciones\Exampl.txt");
                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch (FileNotFoundException ex) 
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Example.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the name of the diectory C:\Leccion 22-Excepciones exists.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                // Code to finalize
                // Setting objects to null
                // Closing database connections
                Console.WriteLine("Closing application now..."); 
            }
        }
    }
}
