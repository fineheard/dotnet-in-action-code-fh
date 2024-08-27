using HelloDotNet;

if (args.Length == 0)
{
    Console.WriteLine("Usage: HelloDotNet <text>");
    Environment.Exit(1);
}

AsciiArt.Write(args[0]);