namespace AdventOfCode2022.Day05;

public class RearrangementProcedureReader {
    private readonly TextReader _reader;

    public RearrangementProcedureReader(TextReader reader)
    {
        _reader = reader;
    }

    public async Task<RearrangementProcedure> Read() {
        return new RearrangementProcedure(await ReadStacks(), await ReadCraneInstructions());
    }

    private async Task<IList<Stack<char>>> ReadStacks() {
        var stacks = new List<Stack<char>>();
        for (var line = await _reader.ReadLineAsync(); line != null && line.Length > 0; line = await _reader.ReadLineAsync()) {
            var stackIndex = 0;
            for (var i = 0; i < line.Length; i += 4, stackIndex++) {
                if (stackIndex >= stacks.Count) {
                    stacks.Add(new Stack<char>());
                }
                var currentStack = line.Substring(i, 3).Trim();
                if (!currentStack.StartsWith('[')) {
                    continue;
                }
                var crate = currentStack.Substring(1, 1)[0];
                stacks[stackIndex].Push(crate);
            }
        }

        var result = new List<Stack<char>>();
        foreach (var stack in stacks)
        {
            result.Add(new Stack<char>());
            while(stack.TryPop(out var crate)) {
                result[result.Count - 1].Push(crate);
            }
        }
        return result;
    }

    private async Task<Queue<CraneInstruction>> ReadCraneInstructions() {
        var result = new Queue<CraneInstruction>();
        for (var line = await _reader.ReadLineAsync(); line != null; line = await _reader.ReadLineAsync()) {
            if (!line.StartsWith("move ")) {
                continue;
            }
            var parts = line.Split();
            result.Enqueue(new CraneInstruction(int.Parse(parts[1]), int.Parse(parts[3]), int.Parse(parts[5])));
        }
        return result;
    }
}