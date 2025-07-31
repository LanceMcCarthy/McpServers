using System.ComponentModel;
using ModelContextProtocol.Server;

namespace McpServers.Playground.Tools;

[McpToolType]
public static class PatternsTool
{
    [McpTool, Description("Provides the Fibonnaci sequence, up until stated limit.")]
    public static string GetFibonacci(string length)
    {
        if(!GlobalHelpers.Verify())
            return "You did not provide the correct secret knock! Please set/update the environment variable SECRET_KNOCK to access this tool.";

        if (!int.TryParse(length, out var limit) || limit < 0)
            return "You need to ask for a total limit, otherwise it will list until infinity! Please provide a non-negative integer.";

        var sequence = new List<int>();

        int a = 0, b = 1;

        while (a <= limit)
        {
            sequence.Add(a);
            var temp = a + b;
            a = b;
            b = temp;
        }

        return string.Join(", ", sequence);
    }

    [McpTool, Description("Provides the Tribonacci sequence, up until stated limit.")]
    public static string GetTribonacci(string length)
    {
        if(!GlobalHelpers.Verify())
            return "You did not provide the correct secret knock! Please set/update the environment variable SECRET_KNOCK to access this tool.";

        if (!int.TryParse(length, out var limit) || limit < 0)
            return "You need to ask for a total limit, otherwise it will list until infinity! Please provide a non-negative integer.";

        var sequence = new List<int>();

        int a = 0, b = 1, c = 1;

        while (a <= limit)
        {
            sequence.Add(a);
            var temp = a + b + c;
            a = b;
            b = c;
            c = temp;
        }

        return string.Join(", ", sequence);
    }

    [McpTool, Description("Provides the Tetranacci sequence, up until stated limit.")]
    public static string GetTetranacci(string length)
    {
        if(!GlobalHelpers.Verify())
            return "You did not provide the correct secret knock! Please set/update the environment variable SECRET_KNOCK to access this tool.";

        if (!int.TryParse(length, out var limit) || limit < 0)
            return "You need to ask for a total limit, otherwise it will list until infinity! Please provide a non-negative integer.";

        var sequence = new List<int>();

        int a = 0, b = 0, c = 0, d = 1;

        while (a <= limit)
        {
            sequence.Add(a);
            var temp = a + b + c + d;
            a = b;
            b = c;
            c = d;
            d = temp;
        }

        return string.Join(", ", sequence);
    }

    [McpTool, Description("Provides the Lucas numbers sequence, up until stated limit.")]
    public static string GetLucas(string length)
    {
        if(!GlobalHelpers.Verify())
            return "You did not provide the correct secret knock! Please set/update the environment variable SECRET_KNOCK to access this tool.";

        if (!int.TryParse(length, out var limit) || limit < 0)
            return "You need to ask for a total limit, otherwise it will list until infinity! Please provide a non-negative integer.";

        var sequence = new List<int>();

        int a = 2, b = 1;

        while (a <= limit)
        {
            sequence.Add(a);
            var temp = a + b;
            a = b;
            b = temp;
        }

        return string.Join(", ", sequence);
    }
}