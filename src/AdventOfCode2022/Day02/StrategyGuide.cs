using AdventOfCode2022.Day02.Interfaces;

namespace AdventOfCode2022.Day02;

public class StrategyGuide : IStrategyGuide
{
    private readonly IEnumerable<Round> _rounds;

    public StrategyGuide(IEnumerable<Round> rounds)
    {
        _rounds = rounds;
    }

    public int GetTotalScore()
    {
        return _rounds.Select(item => item.Score).Sum();
    }
}