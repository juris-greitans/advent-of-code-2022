using AdventOfCode2022.Day05;
using Shouldly;

namespace AdventOfCode2022.Tests.Day05;

public class CraneTests {
    [Fact]
    public async Task Rearrange_RearrangesCorrectlyAsync() {
        var crane = new Crane();
        var procedure = await GetRearrangementProcedureAsync();
        crane.Rearrange(procedure);

        procedure.GetTopCrates().ShouldBe("CMZ");
    }

    private async Task<RearrangementProcedure> GetRearrangementProcedureAsync()
    {
        const string input = @"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2
";

    using var textReader = new StringReader(input);
    var reader = new RearrangementProcedureReader(textReader);
    return await reader.Read();
    }
}