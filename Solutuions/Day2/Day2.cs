public class Day2() : AdventProblem("Solutuions\\Day2\\input.txt")
{

    private Dictionary<string, int> _config = new()
    {
        {"red", 12},
        {"green", 13},
        {"blue", 14}
    };

    public override void Solve(string input)
    {
        var games = input.Split("\n");
        int result = 0;
        foreach (var game in games)
        {
            var id = GetGameId(game);

            var play = game.Substring(game.IndexOf(":")+2);
            
            var rounds = play.Split(';');
            bool isValid = true;
            foreach(var round in rounds)
            {
                var draws = round.Split(',');
                foreach(var draw in draws)
                {
                    var _params = draw.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var qty = int.Parse(_params[0].Trim());
                    var color = _params[1].Trim();
                    if(qty > _config[color])
                    {
                         isValid = false;
                         break;
                    }
                }
                if(!isValid) break;
            }

            if(isValid) result += id;
        }
        System.Console.WriteLine(result);
    }

    private int GetGameId(string game)
    {
        return int.Parse(game.Split(":")[0].Split(' ')[1]);
    }
}