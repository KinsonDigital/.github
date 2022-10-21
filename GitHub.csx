#nullable enable

#load "helpers.csx"
#load "enums.csx"
#r "nuget: Octokit, 3.0.0"

using System.Net.Http;
using System.Text;
using System.Linq;
using Octokit;
using Octokit.Internal;

public static class GitHub
{
    private const string RepoOwner = "KinsonDigital";
    private const string RepoName = ".github";
    private static GitHubClient client;
    private static Issue? issue;

    static GitHub()
    {
        if (client is null)
        {
            var productHeaderValue = new ProductHeaderValue("myscript");
            var credStore =
                new InMemoryCredentialStore(new Credentials(""));
            client = new GitHubClient(productHeaderValue, credStore);
        }
    }

    public async static Task<(bool exists, string errorMsg)> IssueExists(int issueNumber)
    {
        if (issue is not null)
        {
            return (true, string.Empty);
        }

        try
        {
            issue = await client.Issue.Get(RepoOwner, RepoName, issueNumber);

            if (issue.State == ItemState.Closed)
            {
                return (false, $"The issue '{issueNumber}' exists but it has already been closed.");
            }

            return (true, string.Empty);
        }
        catch (NotFoundException)
        {
            return (false, $"The issue number '{issueNumber}' does not exist.");
        }
        catch (Exception e)
        {
            return (false, e.Message);
        }
    }

    public async static Task<bool> BranchExists(string branch)
    {
        var branchClient = client.Repository.Branch;

        var branches = (await branchClient.GetAll(RepoOwner, RepoName))
            .Select(b => b.Name)
            .ToArray();

        return branches.Any(b => b == branch);
    }

    public async static Task<bool> CreatePullRequest(string title, string srcBranch, string targetBranch)
    {
        var prClient = client.PullRequest;

        var newPullRequest = new NewPullRequest(title, srcBranch, targetBranch)
        {
            Draft = true,
            Body = await GetPRTemplate(PRType.PreviewFeature),
        };

        try
        {
            WriteLine("Creating Pull Request:");
            WriteLine($"\tSrc Branch: {srcBranch}");
            WriteLine($"\tTarget Branch: {targetBranch}");
            WriteLine();

            var prResult = await prClient.Create(RepoOwner, RepoName, newPullRequest);

            var labelClient = client.Issue.Labels;

            _ = await labelClient.AddToIssue(RepoOwner, RepoName, prResult.Number, new[] { "preview" });

            WriteLine("Pull Request Created!!");
            return true;
        }
        catch (Exception e)
        {
            Helpers.WriteError(e.Message);
            return false;
        }
    }

    private async static Task<string> GetPRTemplate(PRType prType)
    {
        var templateName = prType switch
        {
            PRType.Feature => "feature-pr-template",
            PRType.PreviewFeature => "preview-feature-pr-template",
            _ => throw new ArgumentOutOfRangeException(nameof(prType), "Enum out of range."),
        };

        var contentClient = client.Repository.Content;

        var rawData = await contentClient.GetRawContent(
            RepoOwner,
            RepoName,
            $".github/PULL_REQUEST_TEMPLATE/{templateName}.md");

        var result = Encoding.Default.GetString(rawData);

        return result;
    }
}