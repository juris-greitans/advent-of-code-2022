namespace AdventOfCode2022.Day07;

public class LsCommand : ICommand
{

    public override string ToString()
    {
        return "ls";
    }

    public async Task<Models.Directory> Execute(Models.Directory? pwd, TextReader reader, params string[] args)
    {
        if (pwd == null) {
            throw new ArgumentNullException(nameof(pwd));
        }
        var nextChar = reader.Peek();
        while(nextChar != -1 && nextChar != '$')
        {
            var line = await reader.ReadLineAsync();
            var parts = line.Split();
            if (parts[0] == "dir") {
                pwd.AddChildDirectory(parts[1]);
            }
            else
            {
                pwd.AddFile(int.Parse(parts[0]));
            }
            nextChar = reader.Peek();
        }
        return pwd;
    }

}