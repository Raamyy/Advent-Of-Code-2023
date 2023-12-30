public class Day1Part2() : AdventProblem("Solutuions\\Day1\\input.txt")
{
     public override void Solve(string input)
    {
        input = input.Replace("one", "o1e");
        input = input.Replace("two", "t2o");
        input = input.Replace("three", "t3e");
        input = input.Replace("four", "f4r");
        input = input.Replace("five", "f5e");
        input = input.Replace("six", "s6x");
        input = input.Replace("seven", "s7n");
        input = input.Replace("eight", "e8t");
        input = input.Replace("nine", "n9e");
        // System.Console.WriteLine(linesV2);
        Day1 day1 = new Day1();
        day1.Solve(input);
    }
}
