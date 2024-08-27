using Figgle;

namespace HelloDotNet;

public static class AsciiArt
{
    public static void Write(string text)
    {
        Console.WriteLine(FiggleFonts.Standard.Render(text));
        Console.WriteLine("Brought to you by " + typeof(AsciiArt).FullName);
    }
}