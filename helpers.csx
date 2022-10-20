#nullable enable

#load "Script.csx"
#r "nuget: LibGit2Sharp, 0.26.2"

using System.ComponentModel.DataAnnotations;
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

    public static void Push(string userName, string pass, string branch)
    {
        if (string.IsNullOrEmpty(userName))
        {
            throw new ArgumentNullException(nameof(userName), "Must not be null or empty.");
        }

        if (string.IsNullOrEmpty(pass))
        {
            throw new ArgumentNullException(nameof(pass), "Must not be null or empty.");
        }
        
        branch = $"refs/heads/{branch}";

        using var repo = new Repository(repoDirPath);

        if (repo.Network.Remotes.Any(r => r.Name == "origin") is false)
        {
            WriteError("No remote with the name origin exits.  Could not push to remote.");
            return;
        }

        var remote = repo.Network.Remotes["origin"];

        var options = new PushOptions();
        options.CredentialsProvider = (url, userNameFromUrl, types) =>
            new UsernamePasswordCredentials()
            {
                Username = userName,
                Password = pass,
            };
        
        repo.Network.Push(remote, branch, options);
    }

    public static string GetPassword()
    {
        var pass = string.Empty;
        ConsoleKey key;

        do
        {
            var keyInfo = ReadKey(intercept: true);
            key = keyInfo.Key;

            if (key == ConsoleKey.Backspace && pass.Length > 0)
            {
                Write("\b \b");
                pass = pass[0..^1];
            }
            else if (!char.IsControl(keyInfo.KeyChar))
            {
                Write("*");
                pass += keyInfo.KeyChar;
            }
        } while (key != ConsoleKey.Enter);

        return pass;
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