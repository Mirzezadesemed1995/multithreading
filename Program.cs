internal class Program
{
    private static void Main(string[] args)
    {
      

        Print("text");

    }
 

 


    public static void Print(string text)
    {
        Thread.Sleep(3000);
        Console.WriteLine(text);
    }
}