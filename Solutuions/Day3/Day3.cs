using System.ComponentModel.DataAnnotations;

public class Day3() : AdventProblem("Solutuions\\Day3\\input.txt")
{

    public override void Solve(string input)
    {
        List<List<char>> map = new();

        var lines = input.Split("\r\n");

        // construct 2d matrix
        foreach (var line in lines)
        {
            List<char> chars = new();

            foreach (var c in line)
            {
                chars.Add(c);
            }
            map.Add(chars);
        }

        var result = 0;

        for (int i = 0; i < map.Count; i++)
        {
            for (int j = 0; j < map[i].Count; j++)
            {
                // special char
                if (map[i][j] != '.' && !char.IsDigit(map[i][j]))
                {
                    System.Console.WriteLine("Checking "+i+" "+j);
                    result += GetNumber(map, i, j - 1);
                    result += GetNumber(map, i, j + 1);

                    result += GetNumber(map, i - 1, j);
                    result += GetNumber(map, i + 1, j);

                    result += GetNumber(map, i - 1, j - 1);
                    result += GetNumber(map, i + 1, j + 1);

                    result += GetNumber(map, i - 1, j + 1);
                    result += GetNumber(map, i + 1, j - 1);
                }
            }
        }

        System.Console.WriteLine(result);
    }

    private int GetNumber(List<List<char>> map, int i, int j)
    {
        if (i < 0 || i >= map.Count) return 0;
        if (j < 0 || j >= map[i].Count) return 0;

        if (!char.IsDigit(map[i][j])) return 0;
        int start = j, end = j;

        // set start
        for (int k = j - 1; k >= 0; k--)
        {
            if (char.IsDigit(map[i][k]))
            {
                start = k;
            }
            else
            {
                break;
            }
        }

        // set end
        for (int k = j + 1; k < map[i].Count; k++)
        {
            if (char.IsDigit(map[i][k]))
            {
                end = k;
            }
            else
            {
                break;
            }
        }

        var number = new string(map[i][start..(end + 1)].ToArray());
        for (int k = start; k <= end; k++)
        {
            map[i][k] = 'x'; // mark as visited
        }
        return int.Parse(number);
    }
}