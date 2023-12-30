using System.ComponentModel.DataAnnotations;

public class Day4Part2() : AdventProblem("Solutuions\\Day4\\input.txt")
{

    public override void Solve(string input)
    {
        var lines = input.Split("\r\n");

        Dictionary<int, int> dict = new();

        int cardId = 1;
        foreach (var line in lines)
        {
            var game = line[line.IndexOf(":")..];
            var winning = game.Split("|")[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var drawn = game.Split("|")[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var winDrawCount = drawn.Where(d => winning.Any(w => w == d)).Count();

            dict[cardId] = dict.GetValueOrDefault(cardId) + 1;

            if (winDrawCount > 0)
            {
                for (int i = 0; i < dict.GetValueOrDefault(cardId); i++)
                {
                    for (int k = 1; k <= winDrawCount; k++)
                    {
                        dict[cardId + k] = dict.GetValueOrDefault(cardId + k) + 1;
                    }
                }
            }
            cardId++;
        }
        System.Console.WriteLine(dict.Sum(e => e.Value));
    }
}