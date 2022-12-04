namespace AdventOfCode2022.Day02.Interfaces;

public interface IRoundReader {
    Task<IEnumerable<Round>> ReadRounds();
}