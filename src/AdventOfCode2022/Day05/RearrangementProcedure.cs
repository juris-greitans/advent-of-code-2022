using System.Text;

namespace AdventOfCode2022.Day05;

public class RearrangementProcedure {
    public IList<Stack<char>> Stacks {get;}
    public Queue<CraneInstruction> CraneInstructions {get;}

    public RearrangementProcedure(IList<Stack<char>> stacks, Queue<CraneInstruction> craneInstructions)
    {
        Stacks = stacks;
        CraneInstructions = craneInstructions;
    }

    public string GetTopCrates()
    {
        var result = new StringBuilder();
        foreach (var stack in Stacks)
        {
            if (stack.TryPeek(out var topCrate)) {
                result.Append(topCrate);
            }
        }
        return result.ToString();
    }

    public override string ToString() {
        var height = 0;;
        foreach (var stack in Stacks)
        {
            if (stack.Count > height) {
                height = stack.Count;
            }
        }
        
        var result = new StringBuilder();
        for (var i = 0; i < height; i++) {
            foreach (var stack in Stacks)
            {
                if (!stack.TryPeek(out var crate)) {
                    result.Append("    ");
                }
                else
                {
                    result.Append($"[{crate}] ");
                }
            }
            result.AppendLine();
        }

        return result.ToString();
    }
}