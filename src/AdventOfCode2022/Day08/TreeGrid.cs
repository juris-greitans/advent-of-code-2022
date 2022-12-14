namespace AdventOfCode2022.Day08;

public class TreeGrid
{
    private readonly IList<List<int>> _rows = new List<List<int>>();

    public async Task ReadGrid(TextReader reader)
    {
        var line = await reader.ReadLineAsync();
        while (line != null)
        {
            var row = new List<int>();
            foreach (var tree in line)
            {
                if (!char.IsAsciiDigit(tree)) {
                    throw new ArgumentException($"Cannot read the tree grid: found non-numeric value '{tree}' in row '{line}'");
                }
                row.Add(tree - '0');
            }
            _rows.Add(row);
            line = await reader.ReadLineAsync();
        }
    }

    public int GetNumberOfVisibleTrees()
    {
        // trees around the edge of the grid are always visible.
        var result = 0;
        for(var i = 0; i < _rows.Count; i++)
        {
            var row = _rows[i];
            for (var j = 0; j < row.Count; j++)
            {
                if (i == 0 || j == 0) {
                    result++;
                    continue;
                }
                var tree = row[j];
                var isTallest = true;
                // from left side
                for (var k = j - 1; k >= 0; k--)
                {
                    if (row[k] >= tree)
                    {
                        isTallest = false;
                        break;
                    }
                }
                if (isTallest) {
                    result++;
                    continue;
                }
                // from right side
                isTallest = true;
                for (var k = j + 1; k < row.Count; k++)
                {
                    if (row[k] >= tree)
                    {
                        isTallest = false;
                        break;
                    }
                }
                if (isTallest) {
                    result++;
                    continue;
                }
                // from top
                isTallest = true;
                for (var k = i - 1; k >= 0; k--)
                {
                    if (_rows[k][j] >= tree)
                    {
                        isTallest = false;
                        break;
                    }
                }
                if (isTallest) {
                    result++;
                    continue;
                }
                // from bottom
                isTallest = true;
                for (var k = i + 1; k < _rows.Count; k++)
                {
                    if (_rows[k][j] >= tree)
                    {
                        isTallest = false;
                        break;
                    }
                }
                if (isTallest) {
                    result++;
                    continue;
                }
            }
        }

        return result;
    }

    public int GetBestScenicScore()
    {
        var result = 0;
        for (var i = 0; i < _rows.Count; i++)
        {
            var row = _rows[i];
            for (var j = 0; j < row.Count; j++)
            {
                if (i == 0 || j == 0)
                {
                    continue;
                }
                var tree = row[j];
                var viewingDistances = new int[4];
                // to left
                for (var k = j - 1; k >= 0; k--)
                {
                    var currentTree = row[k];
                    if (currentTree < tree)
                    {
                        viewingDistances[0]++;
                    }
                    else if (currentTree == tree)
                    {
                        viewingDistances[0]++;
                        break;
                    }
                }
                // to right
                for (var k = j + 1; k < row.Count; k++)
                {
                    var currentTree = row[k];
                    if (tree > currentTree)
                    {
                        viewingDistances[1]++;
                    }
                    else if (tree == currentTree)
                    {
                        viewingDistances[1]++;
                        break;
                    }
                }
                // to top
                for (var k = i - 1; k >= 0; k--)
                {
                    var currentTree = _rows[k][j];
                    if (tree > currentTree)
                    {
                        viewingDistances[2]++;
                    }
                    else if (tree == currentTree)
                    {
                        viewingDistances[2]++;
                        break;
                    }
                }
                // to bottom
                for (var k = i + 1; k < _rows.Count; k++)
                {
                    var currentTree = _rows[k][j];
                    if (tree > currentTree)
                    {
                        viewingDistances[3]++;
                    }
                    else if (tree == currentTree)
                    {
                        viewingDistances[3]++;
                        break;
                    }
                }

                var score = viewingDistances.Aggregate(1, (runningValue, currentValue) => runningValue * currentValue);
                if (score > result) {
                    result = score;
                }
            }
        }

        return result;
    }
}