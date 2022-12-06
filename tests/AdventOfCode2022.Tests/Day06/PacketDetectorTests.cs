using AdventOfCode2022.Day06;
using Shouldly;

namespace AdventOfCode2022.Tests.Day06;

public class PacketDetectorTests {
    [Theory]
    [
        InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 4, 7),
        InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 4, 5),
        InlineData("nppdvjthqldpwncqszvftbrmjlhg", 4, 6),
        InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 4, 10),
        InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 4, 11),

        InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 14, 19),
        InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 14, 23),
        InlineData("nppdvjthqldpwncqszvftbrmjlhg", 14, 23),
        InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 14, 29),
        InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 14, 26)
    ]
    public void GetNumberOfCharactersBeforePacket_ReturnsCorrectNumber(string buffer, int markerLength, int expected) {
        var detector = new PacketDetector();
        detector.GetNumberOfCharactersBeforePacket(buffer, markerLength).ShouldBe(expected);
    }
}