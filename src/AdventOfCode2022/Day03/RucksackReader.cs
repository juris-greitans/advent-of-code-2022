using AdventOfCode2022.Day03.Models;

namespace AdventOfCode2022.Day03;

public class RucksackReader {
    private readonly TextReader _reader;

    public RucksackReader(TextReader reader)
    {
        _reader = reader;
    }

    public async Task<IEnumerable<Rucksack>> ReadRucksacks()
    {
        var result = new List<Rucksack>();
        for(var line = await _reader.ReadLineAsync(); line != null; line = await _reader.ReadLineAsync()) {
            result.Add(new Rucksack(line));
        }
        return result;
    }
}