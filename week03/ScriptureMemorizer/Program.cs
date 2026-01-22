using System;
using System.Collections.Generic;

class Program
{
    private static Random rndScripture = new Random();

    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("D&C", 25, 12), 
            "For my soul delighteth in the song of the heart; yea, the song of the righteous is a prayer unto me, and it shall be answered with a blessing upon their heads." 
            ));

        scriptures.Add(new Scripture(
            new Reference("1 Nephi", 3, 7),
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
            ));

        scriptures.Add(new Scripture(
            new Reference("Matthew", 5, 15, 14),
            "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."
            ));

        scriptures.Add(new Scripture(
            new Reference("Psalm", 24, 3, 4),
            "Who shall ascend into the hill of the Lord? or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully."
            ));

        int index = rndScripture.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            int visible = scripture.CountVisibleWords();
            int numberToHide = Math.Min(3, visible);

            scripture.HideRandomWords(numberToHide);
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}