namespace AdventOfCode2022.Day02.Enums;

public static class ShapeExtensions {
    public static Shape ToShape(this string s) {
        switch(s) {
            case "A":
            case "X":
                return Shape.Rock;
            case "B":
            case "Y":
                return Shape.Paper;
            case "C":
            case "Z":
                return Shape.Scissors;
            default:
                throw new ArgumentException($"Cannot convert string '{s}' to Shape: unsupported value '{s}'.");
        }
    }
}