using AdventOfCode2022.Common;
using AdventOfCode2022.Day02.Interfaces;

namespace AdventOfCode2022.Day02;

public static class RockPaperScissors {
    public static async Task<int> GetTotalScore() {
        var reader = new RoundReader(InputUtils.GetTextReader(2));
        var strategyGuide = new StrategyGuide(await reader.ReadRounds());
        return strategyGuide.GetTotalScore();
    }
}