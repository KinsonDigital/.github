#nullable enable

#load "Script.csx"
#r "nuget: LibGit2Sharp, 0.26.2"

using System.Runtime.CompilerServices;
using LibGit2Sharp;

public static class Helpers
{
    private static readonly string repoDirPath;

    static Helpers()
    {
        var currentDirs = Directory.GetDirectories(Script.ScriptFolder);

        if (currentDirs.Any(d => d.Contains(".git")))
        {
            repoDirPath = Script.ScriptFolder;
            return;
        }

        DirectoryInfo? dirInfo = Directory.GetParent(Script.ScriptFolder);

        while (dirInfo is not null)
        {
            var siblingDirs = dirInfo.GetDirectories();

            var gitRootFound = siblingDirs.Any(d => d.Name.ToLower() == ".git");

            if (gitRootFound)
            {
                break;
            }

            dirInfo = Directory.GetParent(dirInfo.FullName);
        }

        repoDirPath = dirInfo?.FullName ?? string.Empty;
    }

    public static void WriteWarning(string msg)
    {
            var clr = ForegroundColor;

        ForegroundColor = ConsoleColor.Yellow;
        WriteLine(msg);
        ForegroundColor = clr;
    }

    public static void WriteError(string msg)
    {
        var clr = ForegroundColor;

        ForegroundColor = ConsoleColor.Red;
        WriteLine(msg);
        ForegroundColor = clr;
    }

    public static void CreateBranch(string branch)
    {
        using var repo = new Repository(repoDirPath);

        repo.CreateBranch(branch);
    }

    public static void Checkout(string branchName)
    {
        using var repo = new Repository(repoDirPath);

        var branch = repo.Branches[branchName];

        if (branch is null)
        {
            throw new Exception($"Problem checking out branch '{branch}'.");
        }

        Commands.Checkout(repo, branch);
    }

    public static string CurrentBranch()
    {
        using var repo = new Repository(repoDirPath);
        
        return repo.Head.FriendlyName;
    }

    public static string SanitizeBranch(string branch)
    {
        if (string.IsNullOrEmpty(branch))
        {
            return string.Empty;
        }

        branch = branch.Trim();

        for (var i = 10; i >= 1; i--)
        {
            var spaces = CreateSpaces(i);
            branch = branch.Replace(spaces, " ");
        }

        return branch.Replace(' ', '-');
    }

    public static bool IsPreviewBranch(string branch)
    {
        if (string.IsNullOrEmpty(branch))
        {
            return false;
        }

        static bool IsNumChar(char character) => character >= 48 && character <= 57;

        var startsWithCorrectValue = branch.StartsWith("preview/v");
        var containsAllPeriods = branch.Count(c => c == '.') == 3;
        var containsPreviewSection = branch.Contains("-preview");
        var noConsecutivePeriods = branch.Contains("..") is false;

        var allTrue = startsWithCorrectValue &&
            containsAllPeriods &&
            containsPreviewSection &&
            noConsecutivePeriods;

        if (allTrue)
        {
            branch = branch.Replace("preview/v", string.Empty)
                .Replace("-preview", string.Empty);

            var numbers = branch.Split('.');

            return numbers.All(num => num.All(n => IsNumChar(n)));
        }

        return false;
    }

    public static void Push(string branch)
    {
        using var repo = new Repository(repoDirPath);

        var options = new LibGit2Sharp.PushOptions();
        repo.Network.Push(repo.Branches[branch], options);
    }

    private static string CreateSpaces(int total)
    {
        var result = string.Empty;

        for (int i = 0; i < total; i++)
        {
            result += ' ';
        }

        return result;
    }
}