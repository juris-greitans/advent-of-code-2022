using AdventOfCode2022.Day02.Enums;

namespace AdventOfCode2022.Day02;

public class RoundReader
{
    private TextReader _reader;

    public RoundReader(TextReader reader)
    {
        _reader = reader;
    }

    public async Task<IEnumerable<Round>> ReadRounds()
    {
        var rounds = new List<Round>();
        for(var line = await _reader.ReadLineAsync(); line != null; line = await _reader.ReadLineAsync()) {
            if (line.Trim().Length == 0) {
                continue;
            }
            var shapes = line.Split();
            rounds.Add(new Round(shapes[0].ToShape(), shapes[1].ToShape()));
        }
        return rounds;
    }
}