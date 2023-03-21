namespace CharacterSwap;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a word : ");
        string word = Console.ReadLine();

        char firstLetter = word[0];
        char lastLetter = word[word.Length-1];

        word = word.Remove(0,1);
        word = word.Remove(word.Length-1,1);

        Console.WriteLine("");
        Console.WriteLine("Result after swap : " + lastLetter + word + firstLetter);

    }
}
