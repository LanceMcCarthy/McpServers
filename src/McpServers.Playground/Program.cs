using McpServers.Playground.Tools;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Creating host builder...");

var builder = Host.CreateEmptyApplicationBuilder(settings: null);

Console.WriteLine("Adding MCP tools...");

builder.Services 
    .AddMcpServer()  
    .WithStdioServerTransport()   
    .WithTools<DynamicTools>()
    .WithTools<NumericPatternTools>();

await builder.Build().RunAsync();

Console.WriteLine("Running!");