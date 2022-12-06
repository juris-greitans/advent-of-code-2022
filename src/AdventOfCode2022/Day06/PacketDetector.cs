namespace AdventOfCode2022.Day06;

public class PacketDetector {
    public int GetNumberOfCharactersBeforePacket(string buffer, int markerLength) {

        if (buffer.Length < markerLength) {
            return -1;
        }

        // mjqjpqm g
        for (var i = markerLength - 1; i < buffer.Length; i++) {
            var counts = new int['z' - 'a' + 1];

            var mostRecent = buffer.Substring(i - markerLength + 1, markerLength);

            for(var j = 0; j < mostRecent.Length; j++) {
                var index = mostRecent[j] - 'a';
                if (index >= counts.Length) {
                    throw new Exception($"'{mostRecent[j]}' does not have place in 'counts' - index is {index}.");
                }
                counts[index]++;
            }
            var foundDuplicate = false;
            for(var k = 0; k < counts.Length; k++) {
                if (counts[k] > 1) {
                    foundDuplicate = true;
                    break;
                }
            }
            if (!foundDuplicate) {
                return i + 1;
            }
        }

        return -1;
    }
}