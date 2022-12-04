using AdventOfCode2022.Common;
using AdventOfCode2022.Day02.Enums;

namespace AdventOfCode2022.Day02;

public static class RockPaperScissors {
    public static async Task<int> GetTotalScore(StrategyGuideFormat format) {
        var reader = new RoundReader(InputUtils.GetTextReader(2), format);
        var strategyGuide = new StrategyGuide(await reader.ReadRounds());
        return strategyGuide.GetTotalScore();
    }
}