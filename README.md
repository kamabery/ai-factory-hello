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
dotnet run --project src/Hello -- --times 3    # Hello, world! on 3 lines
dotnet run --project src/Hello -- --name Ada --shout --times 3   # HELLO, ADA! on 3 lines
```

`--name <name>` says who to greet; with no name (or a blank one) the app greets the world.

`--times <n>` prints the greeting n times, one per line (default 1). A value of 0, a negative number, a
non-number or a missing value falls back to 1; there is no upper limit. It combines with `--name` and
`--shout` in any order.
