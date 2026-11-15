# ai-factory-hello

A .NET 10 console app (`src/Hello`) and its xUnit tests (`tests/Hello.Tests`), in `Hello.slnx`.

- Keep the behaviour in `src/Hello` testable: logic in plain classes, `Program.cs` only wires it to the console.
- Tests first: a failing test in `tests/Hello.Tests`, then the code.
- `dotnet build Hello.slnx` and `dotnet test Hello.slnx` must pass before a change is done.
