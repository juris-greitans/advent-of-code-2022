using AdventOfCode2022.Day02.Enums;

namespace AdventOfCode2022.Day02;

public class Round {
    public Shape Player1 {get;}
    public Shape Player2 {get;}

    public RoundOutcome Outcome {
        get {
            switch (Player1)
            {
                case Shape.Paper:
                    switch(Player2) {
                        case Shape.Paper: return RoundOutcome.Draw;
                        case Shape.Rock: return RoundOutcome.Loss;
                        case Shape.Scissors: return RoundOutcome.Win;
                    }
                    break;
                case Shape.Rock:
                    switch(Player2) {
                        case Shape.Paper: return RoundOutcome.Win;
                        case Shape.Rock: return RoundOutcome.Draw;
                        case Shape.Scissors: return RoundOutcome.Loss;
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
        }}

        public int Score {get;}

    public Round(Shape player1, Shape player2) {
        Player1 = player1;
        Player2 = player2;
        Score = (int)Player2 + (int)Outcome;
    }


}