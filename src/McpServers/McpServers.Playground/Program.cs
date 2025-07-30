// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Hosting;
using ModelContextProtocol;

Console.WriteLine("Creating host builder...");

var builder = Host.CreateEmptyApplicationBuilder(settings: null);

Console.WriteLine("Adding MCP tools...");

builder.Services 
    .AddMcpServer()  
    .WithStdioServerTransport()   
    .WithTools();

await builder.Build().RunAsync();