using ModelContextProtocol.Server;
using System.ComponentModel;

namespace McpServers.Playground.Tools;

internal class NumericPatternTools
{
    [McpServerTool]
    [Description("Provides the Fibonnaci sequence, up until stated limit.")]
    public string GetFibonacci([Description("Length of sequence to generate.")] string length = "20")
    {
        if (!int.TryParse(length, out var limit) || limit < 0)
            limit = 20;

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

    [McpServerTool]
    [Description("Provides the Lucas numbers sequence, up until stated limit.")]
    public string GetLucas([Description("Length of sequence to generate.")] string length = "20")
    {
        if (!int.TryParse(length, out var limit) || limit < 0)
            limit = 20;

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