# McpServers

A collection of experimental MCP servers that use .NET for the backend.


## Playground

Setup use in your VS2022 .mcp.json file pointing to your publish folder:

- For VS2022, use `%UserProfile%/.mcp.json`
- For VScode, use `%appdata%/Code/User/mcp.json`

```json
{
  "inputs": [
  ],
  "servers": {
    "playground": {
      "type": "stdio",
      "command": "npx",
      "args": ["-y", "D:\\MyMcpServers\\Playground\\McpServers.Playground.exe"],
      "env": {
        "PLAYGROUND_API_KEY": "7a3697d2-SAMPLE-VALUE-6f67e742c857"
      }
    }
  }
}
```

> Important: The `PLAYGROUND_API_KEY` is just a sample value, to show how you can use an environment variable from the config to pass an API key. This is the simplest form of authentication, please see [microsoft/mcp-for-beginners/mcp-oauth2-demo](https://github.com/microsoft/mcp-for-beginners/tree/main/05-AdvancedTopics/mcp-oauth2-demo) for a more robust approach that involves OAuth.

### Tools

- `GetFibonacci` - Accept numerical value for maximum number of items in the sequence
- `GetTribonacci` - Accept numerical value for maximum number of items in the sequence
- `GetTetranacci` - Accept numerical value for maximum number of items in the sequence
- `GetLucas` - Accept numerical value for maximum number of items in the sequence

### Example

<img width="520" height="306" alt="image" src="https://github.com/user-attachments/assets/7d2dba5f-82a8-4046-9d14-18bdc3053541" />


## Future Server

...
