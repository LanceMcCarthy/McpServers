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
      "args": ["-y", "D:\\MyMcpServers\\Playground\\McpServers.Playground.exe"]
    }
  }
}
```

### Tools

- `GetFibonacci` - Accept numerical value for maximum number of items in the sequence
- `GetTribonacci` - Accept numerical value for maximum number of items in the sequence
- `GetTetranacci` - Accept numerical value for maximum number of items in the sequence
- `GetLucas` - Accept numerical value for maximum number of items in the sequence

### Example

<img width="520" height="306" alt="image" src="https://github.com/user-attachments/assets/7d2dba5f-82a8-4046-9d14-18bdc3053541" />


## Future Server

...
