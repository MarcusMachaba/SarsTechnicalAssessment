using System.Linq;

public class RiskEngine
{
    public string Parse(string input)
    {
        string[] parts = input.Split(' ');
        return string.Join(",", parts.Reverse());
    }
}
