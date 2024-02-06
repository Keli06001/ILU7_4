using System;
namespace ILU7_4;
class Program
{
    static void Main(string[] args)
    {
        string[] strings = { "hej", "nej", "ja" };

        char characterToFind1 = 'j';
        Console.WriteLine($"Finns '{characterToFind1}' i alla strängar? {FinnsTecknetIAllaSträngar(strings, characterToFind1)}");

        char characterToFind2 = 'e';
        Console.WriteLine($"Finns '{characterToFind2}' i alla strängar? {FinnsTecknetIAllaSträngar(strings, characterToFind2)}");
    }

    static bool FinnsTecknetIAllaSträngar(string[] strings, char character)
    {
        foreach (string str in strings)
        {
            if (!str.Contains(character))
            {
                return false;
            }
        }
        return true;
    }
}