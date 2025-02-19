# Flattener

Flattens a nested list of objects acting like strings into a flat list of strings.

Given the input

     object[] nested1 =
    [
    new object[] { "one", "Two", new object[] { "Three" }, },
    "Four"
    ];

`Flattener.Flatten(nested1)` should return

    { "one", "Two", "Three", "Four" }

## Usage

```csharp
 object[] nested1 =
[
    new object[] { "one", "Two", new object[] { "Three", new object[] { "Four", "Five" } }, },
    "Six"
];

var result = Flattener.Flatten(nested1);
```

### Output

    { "one", "Two", "Three", "Four", "Five", "Six" }

# Build and Run

> Requires .Net 8.0 SDK

To build:

```bash
dotnet build
```
To Run using the example array:

```bash
dotnet run --project Flattening
```


# Tests

Xunit tests are included in the project. To run the tests, use the following command:

```bash
dotnet test

Restore complete (0.8s)
  Flattening succeeded (1.8s) → Flattening\bin\Debug\net8.0\Flattening.dll
  Flattening_tests succeeded (0.3s) → Flattening_tests\bin\Debug\net8.0\Flattening_tests.dll
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.5+1caef2f33e (64-bit .NET 8.0.1)
[xUnit.net 00:00:00.21]   Discovering: Flattening_tests
[xUnit.net 00:00:00.22]   Discovered:  Flattening_tests
[xUnit.net 00:00:00.22]   Starting:    Flattening_tests
[xUnit.net 00:00:00.24]   Finished:    Flattening_tests
  Flattening_tests test succeeded (0.7s)

Test summary: total: 4, failed: 0, succeeded: 4, skipped: 0, duration: 0.7s
Build succeeded in 3.8s

```

# Environment concerns

This was implemented using Jetbrain Rider.

Rider may use a different version of the .NET SDK than the one you have installed. If you encounter any issues, please ensure you have the correct version of the .NET SDK installed on your machine.