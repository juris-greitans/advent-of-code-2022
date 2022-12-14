namespace AdventOfCode2022.Day07.Models;

public class Directory {
    public string Name {get;}
    public Directory? Parent {get; set;}
    public IList<Directory> ChildDirectories {get;} = new List<Directory>();
    public int Size {get; private set;}
    public bool IsRoot => Name == "/" && Parent == null;

    public Directory(string name, Directory? parent) {
        Name = name;
        Parent = parent;
    }

    public void AddFile(int size) {
        Size += size;
        if (Parent != null) {
            Parent.AddFile(size);
        }
    }

    public Directory AddChildDirectory(string name) {
        var child = ChildDirectories.FirstOrDefault(item => item.Name == name);
        if (child == default) {
            child = new Directory(name, this);
            ChildDirectories.Add(child);
            Size += child.Size;
        }
        return child;
    }

    public Directory GetChildDirectory(string name) {
        return ChildDirectories.First(child => child.Name == name);
    }
}