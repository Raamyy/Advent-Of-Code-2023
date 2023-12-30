public class Day2Part2() : AdventProblem("Solutuions\\Day2\\input.txt")
{
    public override void Solve(string input)
    {
        var games = input.Split("\n");
        int result = 0;
        foreach (var game in games)
        {
            var id = GetGameId(game);

            var play = game.Substring(game.IndexOf(":")+2);
            Dictionary<string, int> max = new();

            var rounds = play.Split(';');
            foreach(var round in rounds)
            {
                var draws = round.Split(',');
                foreach(var draw in draws)
                {
                    var _params = draw.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var qty = int.Parse(_params[0].Trim());
                    var color = _params[1].Trim();
                    max[color] = Math.Max(max.TryGetValue(color, out int value) ? value : 0, qty);
                }
            }

            var power = 1;
            foreach (var color in max.Keys)
            {
                power *= max[color];
            }
            result += power;
           
        }
        System.Console.WriteLine(result);
    }

    private int GetGameId(string game)
    {
        return int.Parse(game.Split(":")[0].Split(' ')[1]);
    }
}