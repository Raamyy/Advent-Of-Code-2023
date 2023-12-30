public class Day1() : AdventProblem("Solutuions\\Day1\\input.txt")
{
    public override void Solve(string input)
    {
        int result = 0;
        var lines = input.Split("\n");
        foreach (var line in lines)
        {
            if(string.IsNullOrEmpty(line)) continue;
            string num = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsDigit(line[i]))
                {
                    num += line[i];
                    break;
                }
            }

            for (int i = line.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(line[i]))
                {
                    num += line[i];
                    break;
                }
            }
            
            result += int.Parse(num);
        }
        Console.WriteLine(result);
    }
}