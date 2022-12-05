using AdventOfCode2022.Common;

namespace AdventOfCode2022.Day05;

public static class SupplyStacks {
    public static async Task<string> Rearrange() {
        using var textReader = InputUtils.GetTextReader(5);
        var reader = new RearrangementProcedureReader(textReader);
        var procedure = await reader.Read();
        var crane = new Crane();
        crane.Rearrange(procedure);
        return procedure.GetTopCrates();
    }
}