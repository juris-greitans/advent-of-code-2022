namespace AdventOfCode2022.Day05;

public class CraneInstruction {
    public int Count {get;}
    public int From {get;}
    public int To {get;}

    public CraneInstruction(int count, int from, int to) {
        Count = count;
        From = from;
        To = to;
    }
}