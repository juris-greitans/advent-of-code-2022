namespace AdventOfCode2022.Day02.Enums;

public static class RoundOutcomeExtensions {
    public static RoundOutcome ToRoundOutcome(this string s) {
        switch (s)
        {
            case "X": return RoundOutcome.Loss;
            case "Y": return RoundOutcome.Draw;
            case "Z": return RoundOutcome.Win;
            default: throw new ArgumentException($"Cannot convert string to outcome: unsupported value '{s}'.");
        }
    }
}