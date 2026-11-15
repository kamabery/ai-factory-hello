# ai-factory-hello

The smallest target for the [AI factory](https://github.com/kamabery/ai-factory): a .NET 10 console app that prints a
greeting, and its xUnit tests. A first job on a new factory install builds a feature here.

```
dotnet build Hello.slnx
dotnet test Hello.slnx
dotnet run --project src/Hello
```

## Usage

```
dotnet run --project src/Hello                 # Hello, world!
dotnet run --project src/Hello -- --name Ada   # Hello, Ada!
```

`--name <name>` says who to greet; with no name (or a blank one) the app greets the world.
