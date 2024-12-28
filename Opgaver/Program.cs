namespace Opgaver
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til H1");
            
            Dag1 dag1 = new Dag1();
            dag1.Start();
            
            Dag2 dag2 = new Dag2();
            dag2.Start();
            
            Dag3 dag3 = new Dag3();
            dag3.Start();
            
            Dag4og5 dag4og5 = new Dag4og5();
            dag4og5.Start();
            
        }
    }
}
