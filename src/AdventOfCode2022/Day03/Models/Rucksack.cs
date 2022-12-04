using System.Text;

namespace AdventOfCode2022.Day03.Models;

public class Rucksack {
    public string Contents {get;}
    private readonly string[] _compartments;
    public Rucksack(string contents) {
        Contents = contents;
        _compartments = new string[2]
        {
            contents.Substring(0, contents.Length / 2),
            contents.Substring(contents.Length / 2)
        };
    }

    public char FindFirstDuplicateItem() {
        foreach (var item in _compartments[0])
        {
            if (_compartments[1].Contains(item)) {
                return item;
            }
        }
        return '\0';
    }

    public int GetPriorityOfFirstDuplicateItem() {
        var ch = FindFirstDuplicateItem();
        return ch.GetPriority();
    }

    public string FindMatchingItems(string otherContents) {
        var result = new StringBuilder();
        foreach (var item in otherContents)
        {
            if (Contents.Contains(item)) {
                result.Append(item);
            }
        }
        return result.ToString();
    }
}