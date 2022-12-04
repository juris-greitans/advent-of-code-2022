using System.Reflection;

namespace AdventOfCode2022.Common;

internal static class InputUtils {
    public static TextReader GetTextReader(int whichDay, string fileName = "input.txt") {
        var name = $"Day{whichDay:00}.{fileName}".ToLowerInvariant();
        var allResourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
        var fullName = allResourceNames.First(item => item.ToLowerInvariant().EndsWith(name));
        return new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(fullName) ?? throw new FileNotFoundException($"Resource not found: '{fullName}'.", fullName));
    }
}