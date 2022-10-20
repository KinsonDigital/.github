Clear-Host;

$srcBranch = "preview/feature/19-testing";
$targetBranch = "preview/v1.0.0-preview.1";

if ($srcBranch -eq $null -or $srcBranch -eq "")
{
    throw "The source branch cannot be null or empty.";
}

if ($targetBranch -eq $null -or $targetBranch -eq "")
{
    throw "The target branch cannot be null or empty.";
}

# ✅Check if src branch is null or empty
# ✅Check if target branch is null or empty
# Check if the src branch issue number exists
# Check if target branch exists in remote
# check

# Get the preview feature PR template for creating the pull request
$uri = "https://raw.githubusercontent.com/KinsonDigital/.github/master/.github/PULL_REQUEST_TEMPLATE/preview-feature-pr-template.md";
[Microsoft.PowerShell.Commands.BasicHtmlWebResponseObject]$data = Invoke-WebRequest -Uri $uri;


# [System.Management.Automation.PSCustomObject]
$issueOutput = (gh issue view 19 --json title | ConvertFrom-Json);
Write-Host $issueOutput.title;

# Get all of the remote branch to make sure it exists
[string]$remoteBranchesOutput = git branch -r;
$remoteBranchesOutput = $remoteBranchesOutput.Replace("origin/", "");

[string[]]$remoteBranches = $remoteBranchesOutput.Split("   ");

[bool]$containsBranch = $remoteBranches.Contains($targetBranch);

if ($containsBranch -eq $true)
{
    Write-Host "Target Branch Exists";
}





# gh pr create `
#     --title "🚧My Preview Feature" `
#     --body $data.Content `
#     --label "invalid" `
#     --head "my-branch-1" `
#     --base "master" `
#     --milestone "my-milestone" `
#     --draft;
