using AdventOfCode2022.Day02;
using AdventOfCode2022.Day02.Enums;
using Shouldly;

namespace AdventOfCode2022.Tests.Day02;

public class RoundTests {
    [Theory]
    [
        InlineData(Shape.Paper, Shape.Paper, RoundOutcome.Draw, 5),
        InlineData(Shape.Paper, Shape.Rock, RoundOutcome.Loss, 1),
        InlineData(Shape.Paper, Shape.Scissors, RoundOutcome.Win, 9),
        InlineData(Shape.Rock, Shape.Paper, RoundOutcome.Win, 8),
        InlineData(Shape.Rock, Shape.Rock, RoundOutcome.Draw, 4),
        InlineData(Shape.Rock, Shape.Scissors, RoundOutcome.Loss, 3),
        InlineData(Shape.Scissors, Shape.Paper, RoundOutcome.Loss, 2),
        InlineData(Shape.Scissors, Shape.Rock, RoundOutcome.Win, 7),
        InlineData(Shape.Scissors, Shape.Scissors, RoundOutcome.Draw, 6)
    ]
    public void Player1Player2_ReturnsExpectedOutcomeAndScore(Shape player1, Shape player2, RoundOutcome expectedOutcome, int expectedScore) {
        var round = new Round(player1, player2);
        round.Outcome.ShouldBe(expectedOutcome);
        round.Score.ShouldBe(expectedScore);
    }

    [Theory]
    [
        InlineData(Shape.Paper, RoundOutcome.Draw, Shape.Paper, 5),
        InlineData(Shape.Paper, RoundOutcome.Loss, Shape.Rock, 1),
        InlineData(Shape.Paper, RoundOutcome.Win, Shape.Scissors, 9),
        InlineData(Shape.Rock, RoundOutcome.Win, Shape.Paper, 8),
        InlineData(Shape.Rock, RoundOutcome.Draw, Shape.Rock, 4),
        InlineData(Shape.Rock, RoundOutcome.Loss, Shape.Scissors, 3),
        InlineData(Shape.Scissors, RoundOutcome.Loss, Shape.Paper, 2),
        InlineData(Shape.Scissors, RoundOutcome.Win, Shape.Rock, 7),
        InlineData(Shape.Scissors, RoundOutcome.Draw, Shape.Scissors, 6)
    ]
    public void Player1Outcome_ReturnsExpectedScore(Shape player1, RoundOutcome outcome, Shape expectedPlayer2, int expectedScore) {
        var round = new Round(player1, outcome);
        round.Player2.ShouldBe(expectedPlayer2);
        round.Score.ShouldBe(expectedScore);
    }
}