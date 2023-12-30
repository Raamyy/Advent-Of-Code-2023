using System.ComponentModel.DataAnnotations;

public class Day4() : AdventProblem("Solutuions\\Day4\\input.txt")
{

    public override void Solve(string input)
    {
        double result = 0;
        var lines = input.Split("\r\n");

        foreach (var line in lines)
        {
            var game = line[line.IndexOf(":")..];
            var winning = game.Split("|")[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var drawn = game.Split("|")[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var winDrawCount = drawn.Where(d => winning.Any(w => w == d)).Count();
            
            if(winDrawCount > 0)
                result += Math.Pow(2, winDrawCount - 1);
        }
        System.Console.WriteLine(result);
    }
}