#nullable enable

#load "Script.csx"
#load "GitHub.csx"
#load "helpers.csx"
#r "nuget: LibGit2Sharp, 0.26.2"
#r "System.dll"

using System.Reflection.Emit;
using System.Linq;
using System;
using System.IO;
using Octokit;

Script.Bootstrap(Args);

Write("Please enter the issue number for this preview feature pull request: ");

var issueNumberInput = "19";// ReadLine();

var parseResult = int.TryParse(issueNumberInput, out var issueNumber);

if (parseResult is false)
{
    Helpers.WriteError($"The issue number '{issueNumberInput}' must be a whole numeric value only.");
    return;
}

// Check if the issue number exists
var (exists, errorMsg) = await GitHub.IssueExists(issueNumber);

if (exists is false)
{
    Helpers.WriteError(errorMsg);
    return;
}

var currentBranch = Helpers.CurrentBranch();

if (Helpers.IsPreviewBranch(currentBranch) is false)
{
    Helpers.WriteError("Preview feature branches can only be created from preview branches.");
    return;
}

Write("Please enter a simple branch description: ");

var branchDescription = "my-testing-branch";// ReadLine()?.ToLower() ?? string.Empty;

if (string.IsNullOrEmpty(branchDescription))
{
    Helpers.WriteError("The branch must have a description.");
    return;
}

branchDescription = Helpers.SanitizeBranch(branchDescription);

if (branchDescription.Contains('-') is false)
{
    Helpers.WriteWarning("There are no hyphens (-) in the branch description.");
    Helpers.WriteWarning("You might get a branch name change request from one of the project maintainers.");

    WriteLine();
    Helpers.WriteWarning("Branch Naming Syntax:");
    Helpers.WriteWarning("\t- Branch descriptions should be all lower case and each word separated by a hyphen.");
    Helpers.WriteWarning("\t- You can also write a description with spaces between words.");
    Helpers.WriteWarning("\t- Branch descriptions will automatically be lowercased for you.");
}

var newBranch = $"preview/feature/{issueNumber}-{branchDescription}";

Helpers.CreateBranch(newBranch);
Helpers.Checkout(newBranch);

WriteLine("Please enter your user name: ");
var userName = ReadLine();
userName = string.IsNullOrEmpty(userName) ? string.Empty : userName;

Write("Please enter your password: ");

var password = Helpers.GetPassword();

password = string.IsNullOrEmpty(password) ? string.Empty : password;
WriteLine();

// Helpers.Push(userName, password, newBranch);



// if (Args.Count <= 0)
// {
//     WriteLine("The");
// }
