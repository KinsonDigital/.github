#nullable enable

#load "helpers.csx"
#r "nuget: Octokit, 3.0.0"

using System.Net.Http;
using System.Text;
using System.Linq;
using Octokit;

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
            client = new GitHubClient(productHeaderValue);
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

    public async static Task CreatePullRequest(string title, string srcBranch, string targetBranch)
    {
        var prClient = client.PullRequest;

        
        var newPullRequest = new NewPullRequest(title, srcBranch, targetBranch);

        newPullRequest.Draft = true;

        var prResult = await prClient.Create(RepoOwner, RepoName, newPullRequest);
    }

    public async static Task<string> GetPRTemplate()
    {
        var contentClient = client.Repository.Content;

        var rawData = await contentClient.GetRawContent(
            RepoOwner,
            RepoName,
            ".github/PULL_REQUEST_TEMPLATE/preview-feature-pr-template.md");

        var result = Encoding.Default.GetString(rawData);

        return result;
    }
}