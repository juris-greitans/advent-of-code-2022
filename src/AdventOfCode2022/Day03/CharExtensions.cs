namespace AdventOfCode2022.Day03;

public static class CharExtensions {
    public static int GetPriority(this char ch) {
        if (Char.IsAsciiLetterUpper(ch)) {
            return (int)ch - 38;
        }
        return (int)ch - 96;
    }
}