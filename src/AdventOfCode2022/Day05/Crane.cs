namespace AdventOfCode2022.Day05;

public class Crane {
    public void Rearrange(RearrangementProcedure procedure) {
        while(procedure.CraneInstructions.Count > 0) {
            var instruction = procedure.CraneInstructions.Dequeue();
            for (var i = 0; i < instruction.Count; i++) {
                var crate = procedure.Stacks[instruction.From - 1].Pop();
                procedure.Stacks[instruction.To - 1].Push(crate);
            }
        }
    }
}