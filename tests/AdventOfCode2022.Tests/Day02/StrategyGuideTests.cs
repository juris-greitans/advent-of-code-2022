using AdventOfCode2022.Day02;
using AdventOfCode2022.Day02.Enums;
using Shouldly;

namespace AdventOfCode2022.Tests.Day02;

public class StrategyGuideTests {
    [Fact]
    public void GetTotalScore_NoRounds_ReturnsZero() {
        var rounds = new List<Round>();
        
        var guide = new StrategyGuide(rounds);
        guide.GetTotalScore().ShouldBe(0);
    }

    [Fact]
    public void GetTotalScore_OneRound_ReturnsCorrectScore() {
        var rounds = new Round[]{ new Round(Shape.Paper, Shape.Scissors)};
        
        var guide = new StrategyGuide(rounds);
        guide.GetTotalScore().ShouldBe(9);
    }

    [Fact]
    public void GetTotalScore_SeveralRounds_ReturnsCorrectScore() {
        var rounds = new Round[]
        {
            new Round(Shape.Paper, Shape.Scissors),
            new Round(Shape.Scissors, Shape.Rock)
        };
        
        var guide = new StrategyGuide(rounds);
        guide.GetTotalScore().ShouldBe(16);
    }

    [Fact]
    public void GetTotalScore_SpecificRounds_ReturnsCorrectScore() {
        var rounds = new Round[]
        {
            new Round("A".ToShape(), "Y".ToShape()),
            new Round("B".ToShape(), "X".ToShape()),
            new Round("C".ToShape(), "Z".ToShape())
        };
        
        var guide = new StrategyGuide(rounds);
        guide.GetTotalScore().ShouldBe(15);
    }
}