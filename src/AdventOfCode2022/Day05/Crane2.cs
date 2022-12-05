namespace AdventOfCode2022.Day05;

public class Crane2: ICrane {
    public void Rearrange(RearrangementProcedure procedure) {
        while(procedure.CraneInstructions.Count > 0) {
            var instruction = procedure.CraneInstructions.Dequeue();
            var intermediateStack = new Stack<char>();
            for (var i = 0; i < instruction.Count; i++) {
                intermediateStack.Push(procedure.Stacks[instruction.From - 1].Pop());
            }
            while (intermediateStack.TryPop(out var crate)) {
                procedure.Stacks[instruction.To - 1].Push(crate);
            }
        }
    }
}