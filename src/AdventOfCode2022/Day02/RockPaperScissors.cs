using AdventOfCode2022.Common;
using AdventOfCode2022.Day02.Enums;
using AdventOfCode2022.Day02.Interfaces;

namespace AdventOfCode2022.Day02;

public static class RockPaperScissors {
    public static async Task<int> GetTotalScoreVersion1() {
        var reader = new RoundReader(InputUtils.GetTextReader(2), StrategyGuideFormat.Player1AndPlayer2);
        var strategyGuide = new StrategyGuide(await reader.ReadRounds());
        return strategyGuide.GetTotalScore();
    }

    public static async Task<int> GetTotalScoreVersion2() {
        var reader = new RoundReader(InputUtils.GetTextReader(2), StrategyGuideFormat.Player1AndOutcome);
        var strategyGuide = new StrategyGuide(await reader.ReadRounds());
        return strategyGuide.GetTotalScore();
    }
}