namespace AdventOfCode2022.Day07.Models;

public class DirectoryTree
{
    public Directory? Root {get; set;}

    public int GetTotalSizeOfDirectoriesSmallerThan(int limit)
    {
        return GetTotalSizeOfDirectoriesSmallerThan(limit, Root);
    }

    private int GetTotalSizeOfDirectoriesSmallerThan(int limit, Directory current)
    {
        var result = current.Size < limit ? current.Size : 0;
        foreach (var child in current.ChildDirectories)
        {
            result += GetTotalSizeOfDirectoriesSmallerThan(limit, child);
        }
        return result;
    }

    public int FreeUpSpace(int diskSizeInBytes, int requiredFreeSpaceInBytes)
    {
        var currentFreeSpaceInBytes = diskSizeInBytes - Root.Size;
        var neededSpaceInBytes = requiredFreeSpaceInBytes - currentFreeSpaceInBytes;
        return FindChildDirectoryWithSizeAtLeast(Root, neededSpaceInBytes);
    }

    private int FindChildDirectoryWithSizeAtLeast(Directory dir, int size)
    {
        if (dir.Size < size)
        {
            return 0;
        }
        var result = dir.Size;
        foreach (var child in dir.ChildDirectories)
        {
            var closestChildSize = FindChildDirectoryWithSizeAtLeast(child, size);
            if (closestChildSize > 0 && closestChildSize < result)
            {
                result = closestChildSize;
            }
        }
        return result;
    }

}