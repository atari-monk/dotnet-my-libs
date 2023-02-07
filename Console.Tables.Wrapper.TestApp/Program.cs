using Console.Tables.Wrapper;
using ConsoleTables;
using Output = System.Console;

var table = new ConsoleTable("one", "two", "three");
table.AddRow(1, 2, 3)
     .AddRow("this line should be longer", "yes it is", "oh");
table.Write();
Output.WriteLine();

var rows = Enumerable.Repeat(new Sample(), 10);

ConsoleTable
    .From<Sample>(rows)
    .Configure(o => o.NumberAlignment = Alignment.Right)
    .Write(Format.Alternative);

Output.ReadKey();