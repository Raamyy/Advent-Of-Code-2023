public abstract class AdventProblem(string inputPath)
{
    private readonly string _inputPath = inputPath;

    protected string GetInput(string filename = "input.txt")
    {
        string text = File.ReadAllText(filename);
        // System.Console.WriteLine(text);
        System.Console.WriteLine(filename);
        return text;
    }

    public virtual void Solve()
    {
        string input = GetInput(_inputPath);
        Solve(input);
    }

    protected abstract void Solve(string input);
    
}