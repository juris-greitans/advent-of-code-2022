using AdventOfCode2022.Day02.Enums;

namespace AdventOfCode2022.Day02;

public class Round {
    public Shape Player1 {get;}
    public Shape Player2 {get;}

    private readonly  RoundOutcome _outcome;
    public RoundOutcome Outcome => _outcome;

        public int Score {get;}

    public Round(Shape player1, Shape player2) {
        Player1 = player1;
        Player2 = player2;
        _outcome = CalculateOutcome();
        Score = (int)Player2 + (int)Outcome;
    }

    public Round(Shape player1, RoundOutcome outcome) {
        Player1 = player1;
        _outcome = outcome;
        Player2 = CalculatePlayer2();
        Score = (int)Player2 + (int)Outcome;
    }

    private RoundOutcome CalculateOutcome() {
        switch (Player1)
            {
                case Shape.Rock:
                    switch(Player2) {
                        case Shape.Paper: return RoundOutcome.Win;
                        case Shape.Rock: return RoundOutcome.Draw;
                        case Shape.Scissors: return RoundOutcome.Loss;
                    }
                    break;
                case Shape.Paper:
                    switch(Player2) {
                        case Shape.Paper: return RoundOutcome.Draw;
                        case Shape.Rock: return RoundOutcome.Loss;
                        case Shape.Scissors: return RoundOutcome.Win;
                    }
                    break;
                case Shape.Scissors:
                    switch(Player2) {
                        case Shape.Paper: return RoundOutcome.Loss;
                        case Shape.Rock: return RoundOutcome.Win;
                        case Shape.Scissors: return RoundOutcome.Draw;
                    }
                    break;
                default: throw new NotImplementedException($"Unrecognized shape for player 1: {Player1:G}");
            }
            throw new NotImplementedException($"Unrecognized shape for player 2: {Player2:G}");
    }

    private Shape CalculatePlayer2() {
        switch (Player1)
        {
            case Shape.Rock:
                switch(Outcome) {
                    case RoundOutcome.Loss: return Shape.Scissors;
                    case RoundOutcome.Draw: return Shape.Rock;
                    case RoundOutcome.Win: return Shape.Paper;
                }
                break;
            case Shape.Paper:
                switch(Outcome) {
                    case RoundOutcome.Loss: return Shape.Rock;
                    case RoundOutcome.Draw: return Shape.Paper;
                    case RoundOutcome.Win: return Shape.Scissors;
                }
                break;
            case Shape.Scissors:
                switch(Outcome) {
                    case RoundOutcome.Loss: return Shape.Paper;
                    case RoundOutcome.Draw: return Shape.Scissors;
                    case RoundOutcome.Win: return Shape.Rock;
                }
                break;
            default: throw new NotImplementedException($"Unrecognized shape for player 1: {Player1:G}");
        }
        throw new NotImplementedException($"Unrecognized round outcome: {Outcome:G}");
    }
}