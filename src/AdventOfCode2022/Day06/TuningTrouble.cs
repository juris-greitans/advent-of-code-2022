using AdventOfCode2022.Common;

namespace AdventOfCode2022.Day06;

public static class TuningTrouble {
    public static async Task<int> GetNumberOfCharactersBeforePacket(int markerLength) {
        using var textReader = InputUtils.GetTextReader(6);
        var detector = new PacketDetector();
        return detector.GetNumberOfCharactersBeforePacket(await textReader.ReadToEndAsync(), markerLength);
    }
}