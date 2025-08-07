# McpServers

A collection of experimental MCP servers and tools that use .NET for the backend. It shows you both how to write an mcp server using .NET, but also how to publish as an npm package or a docker image.

To add an mcp server to GitHub Copilot chat, open the appropriate file:

- For VS2022, use `%UserProfile%/.mcp.json`
- For VSCode, use `%appdata%/Code/User/mcp.json`

Once open, update it with one of the config options. If you want to speed testing up, you can use one option for VS2022 and the other for VSCode!

## Playground

| Workflow | Status |
|---|---|
| npm | [![Publish package to npm](https://github.com/LanceMcCarthy/McpServers/actions/workflows/publish-npm.yml/badge.svg)](https://github.com/LanceMcCarthy/McpServers/actions/workflows/publish-npm.yml) |
| Docker Hub | [![Publish image to DockerHub](https://github.com/LanceMcCarthy/McpServers/actions/workflows/publish-docker.yml/badge.svg)](https://github.com/LanceMcCarthy/McpServers/actions/workflows/publish-docker.yml) |

### Option 1 - Docker Image

If you have docker installed, you can use my published docker image.

```json
{
  "inputs": [
  ],
  "servers": {
    //... ADD THIS
    "playground": {
      "type": "stdio",
      "command": "docker",
      "args": ["run", "-i", "--rm", "docker.io/lancemccarthy/mcp-playground:latest"]
    }
  }
}
```

### Option 2 - NPM Package

You can also use node to run the mcp server, this config uses my published npm package.

```json
{
  "inputs": [
  ],
  "servers": {
    //... ADD THIS
    "playground": {
      "type": "stdio",
      "command": "npx",
      "args": ["-y", "@lancemccarthy/mcp-playground@latest"]
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

