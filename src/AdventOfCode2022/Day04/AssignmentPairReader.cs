using AdventOfCode2022.Day04.Models;

namespace AdventOfCode2022.Day04;

public class AssignmentPairReader {
    private readonly TextReader _reader;

    public AssignmentPairReader(TextReader reader)
    {
        _reader = reader;
    }

    public async Task< IEnumerable< Tuple< Assignment, Assignment>>> ReadAssignmentPairs() {
        var result = new List<Tuple<Assignment, Assignment>>();
        for (var line = await _reader.ReadLineAsync(); line != null; line = await _reader.ReadLineAsync()) {
            var pairs = line.Split(',');
            var first = pairs[0].Split('-');
            var second = pairs[1].Split('-');
            result.Add(
                new Tuple<Assignment, Assignment>(
                    new Assignment(int.Parse(first[0]), int.Parse(first[1])),
                    new Assignment(int.Parse(second[0]), int.Parse(second[1]))
                )
            );
        }
        return result;
    }
}