using System;
class ASCII
{
    public static void Main(string[] args)
    {
        string s;
        Console.WriteLine(" inserisci la frase da convertire: ");
        s = Console.ReadLine();
        foreach (char c in s)
        {
            Console.WriteLine((int)c);
        }
        Console.ReadLine();
    }
}