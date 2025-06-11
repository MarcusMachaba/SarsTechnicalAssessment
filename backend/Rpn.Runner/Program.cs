using SARS.RPN.Parser;

Console.WriteLine("SARS Customs Risk Engine Reverse-Polish-Notation Calculator");
Console.WriteLine("Type an RPN expression (space-delimited) and press <Enter>:");
Console.WriteLine("Type EXIT (or just press <Enter>) to quit.\n");


while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("> ");
    Console.ResetColor();

    var input = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(input) || input.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Good-bye!");
        break;
    }

    try
    {
        var infix = InfixConverter.ToInfix(input);
        var result = Evaluator.Evaluate(input);          

        Console.WriteLine($"Infix  : {infix}");
        Console.WriteLine($"Result : {result}\n");
    }
    catch (RpnParseException ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Parse error: {ex.Message}\n");
        Console.ResetColor();
    }
}


    