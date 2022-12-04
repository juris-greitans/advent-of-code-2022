namespace AdventOfCode2022.Day04.Models;

public class Assignment {

    private readonly int _firstSection;
    private readonly int _lastSection;

    public Assignment(int firstSection, int lastSection) {
        _firstSection = firstSection;
        _lastSection = lastSection;
    }

    public bool Contains(Assignment other) {
        return _firstSection <= other._firstSection &&
            _lastSection >= other._lastSection;
    }

    public bool Overlaps(Assignment other) {
        return (_firstSection >= other._firstSection && _firstSection <= other._lastSection) ||
            (_lastSection >= other._firstSection && _lastSection <= other._lastSection) ||
            (_firstSection <= other._firstSection && _lastSection >= other._lastSection);
    }
}