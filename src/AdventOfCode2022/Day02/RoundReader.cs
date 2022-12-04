using AdventOfCode2022.Day02.Enums;
using AdventOfCode2022.Day02.Interfaces;

namespace AdventOfCode2022.Day02;

public class RoundReader: IRoundReader
{
    private TextReader _reader;
    private readonly StrategyGuideFormat _format;

    public RoundReader(TextReader reader, StrategyGuideFormat format)
    {
        _reader = reader;
        _format = format;
    }

    public async Task<IEnumerable<Round>> ReadRounds()
    {
        var rounds = new List<Round>();
        for(var line = await _reader.ReadLineAsync(); line != null; line = await _reader.ReadLineAsync()) {
            if (line.Trim().Length == 0) {
                continue;
            }
            var shapes = line.Split();
            var round = CreateRound(shapes);
            rounds.Add(round);
        }
        return rounds;
    }

    private Round CreateRound(string[] parts) {
        switch (_format)
            {
                case StrategyGuideFormat.Player1AndPlayer2: return new Round(parts[0].ToShape(), parts[1].ToShape());
                case StrategyGuideFormat.Player1AndOutcome: return new Round(parts[0].ToShape(), parts[1].ToRoundOutcome());
                default: throw new ArgumentException($"Cannot read rounds from strategy guide: unknown strategy guide format '{_format:G}'.");
            }
    }
}