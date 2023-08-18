<h1 style="border:0;font-weight:bold" align="center">Contribution Guide</h1>

Welcome, and thank you for your interest in contributing to our projects! Our top priority is maintaining high software quality and having a smooth contribution process.  We appreciate any help you can provide, so if you have any ideas or comments on how we can improve, please reach out to one of our project maintainers. We value your input and would love to hear from you.

There are several ways you can contribute to our projects, including creating GitHub issues for any problems you encounter, submitting code contributions, and more. To ensure your contributions are properly directed, please only create an issue that is marked with the description _**(Outside contributors only)**_. Our project maintainers will handle the rest.

Thank you again for your interest in contributing to our projects, and we look forward to collaborating with you!

<h2 style="border:0;font-weight:bold" align="center">Considerations</h2>

Only the **KinsonDigital** team will merge changes that improve the library significantly. We will not merge changes that have narrowly-defined benefits or contain breaking changes in any way without approval. All contributions must also follow all other guidelines outlined in this document.

**Finding Existing Issues**

Before filing a new issue, please search the project's issues to check if it already exists.  If you do find an existing issue, please include your feedback in the discussion. Instead of posting "me too", upvote the issue with 👍, as this better helps us prioritize popular issues and avoids spamming people subscribing to the issue.

**Writing a Good Bug Report**

Good bug reports make it easier for maintainers to verify the root cause of the underlying problem. The better a bug report, the faster the problem will be resolved. Ideally, a bug report should contain the following information:
- A high-level description of the problem.
- A minimal reproduction, i.e. the smallest size of code/configuration required to reproduce the wrong behavior.
- A description of the expected behavior, contrasted with the actual behavior observed.
- Information on the environment: NuGet version, .NET version, Operating System with version, browser, etc.
- Additional information, e.g. is it a regression from previous versions? Are there any known workarounds?
- When ready to submit a bug report, please use the projects **🐛Bug** issue template.

**Why are Minimal Reproductions Important?**

A reproduction lets maintainers verify the presence of a bug, and diagnose the issue using a debugger. A minimal reproduction is the smallest possible console application demonstrating that bug. Minimal reproductions are generally preferable since they:
- Focus debugging efforts on a simple code snippet.
- Ensure that the problem is not caused by unrelated dependencies/configurations.
- Avoid the need to share production codebases.

**How to Create a Minimal Reproduction**
- The best way to create a minimal reproduction is gradually removing code and dependencies from a reproducing app until the problem no longer occurs. 
 
**A Good Minimal Reproduction:**
- Excludes all unnecessary types, methods, code blocks, source files, dependencies and project configurations.
- Contains documentation or code comments illustrating expected vs actual behavior.
- Stack Overflow has a great article about [how to create a minimal, reproducible example](https://stackoverflow.com/help/minimal-reproducible-example).

<h2 style="border:0;font-weight:bold" align="center">DO's and DON'Ts</h2>

**Please:**

- **DO** follow the [code of conduct](https://github.com/KinsonDigital/.github/blob/main/docs/code_of_conduct.md) on GitHub.
- **DO** follow the `📃rules` on [Discord](https://discord.gg/qewu6fNgv7).
- **DO** talk to us on our [Discord](https://discord.gg/qewu6fNgv7) server.
- **DO** keep issue discussions around contributions focused.
- **DO** use the comment sections in the issues and pull requests (PRs) that are relevant to said issues and PRs.  This not only keeps conversations contained in the issues and PRs, but it also sends notifications to the project maintainers and shows the conversation to the community/public.
- **DO** leave a comment on the issue that you are interested in to let the project maintainers know that you would like to work on the issue.
- **DO NOT** start working on a PR until you get confirmation from a project maintainer and the issue is assigned to you.  We do not want to waste your time on an issue that you are not allowed to work on.
- **DO NOT** make PRs that do not directly affect the end user, such as style changes. These are best done as part of a PR related to the area in question. Documentation is fine (and encouraged!) and is useful to the end user.
- **DO** follow branch naming requirements and practices based on the branching model used for a project. (More info below)
- **DO** use early pull requests. (More info below)
- **DO NOT** commit code you did not write without following its license and without following our guidelines in the Contributor License Agreement. If you are unable to license the code, do not commit it.
- **DO NOT** surprise us with big PRs or big API changes without talking to us first!
- **DO NOT** make PRs for legal or administrative documents, such as the license, file headers, or code of conduct. If something is off, let us know and we will look into changing it.

<h2 style="border:0;font-weight:bold" align="center">Breaking Changes</h2>

Contributions must maintain API signature and behavioral compatibility. Contributions that include breaking changes MUST be discussed with project maintainers first. Breaking changes are subject to the team's approval. At the risk of sounding like a broken record, talk to us about your idea first!

<h2 style="border:0;font-weight:bold" align="center">Setting Things Up</h2>

For first-time contributors, you need to fork the repository to start contributing.  There are a few steps that you will need to go through to start contributing.  Go [here](https://github.com/KinsonDigital/.github/blob/main/docs/HowToFork.md) to follow the steps on forking the repository.  There are lots of additional resources on the web on what forking is and how to do this.

<h2 style="border:0;font-weight:bold" align="center">Branching</h2>

Contributing requires that you create a git branch to hold all of your changes. Go [here](https://github.com/KinsonDigital/.github/blob/main/docs/CreatingBranches.md) to follow the instructions on how to create a contribution branch.

> **Note** We take pride in maintaining a clear and consistent branch naming policy that helps us efficiently manage our codebase. By doing so, it makes it easy for our CI/CD system to validate issues and pull requests, ensuring a seamless workflow.
> 
> We kindly ask that you take a moment to review your branch names before submitting a PR. To ensure proper integration with our GitHub repository, branch names should be in all lowercase and contain a valid issue number. Do not worry if you make a mistake; we are all human! Simply tag a maintainer in your PR, and we will help you correct any errors.

<h2 style="border:0;font-weight:bold" align="center">Creating Early Pull Requests</h2>

Refer to the **DO's and DON'Ts** section for details about PRs.

We encourage and use [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please do not wait until you are finished with your work before creating a PR!  
Go [here](https://github.com/KinsonDigital/.github/blob/main/docs/EarlyPullRequests.md) to learn how to create an early pull request.


<h2 style="border:0;font-weight:bold" align="center">"Help wanted" & "Good first issue"</h2>

If the core team is unable to champion an issue, they will mark it with a "help wanted" label. This indicates that any external contributor can pick it up and implement it as part of a contribution. However, some **"help wanted"** issues may require intermediate knowledge of the codebase, area, and/or ecosystem; or may have uncertainty surrounding the implementation details.  If this is the case, talk to us in [Discord](https://discord.gg/qewu6fNgv7) or the issue's discussion. We also mark some issues with the label **"good first issue"** which indicates that an issue is straightforward and is a good place to start if you are interested in contributing but are new to the codebase.


<h3 style="border:0;font-weight:bold" align="left">Resources</h3>

- [Forking a Repository](https://docs.github.com/en/get-started/quickstart/fork-a-repo)
- [Working With Forks](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/about-forks)
- [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6)
- [Draft Pull Requests](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/about-pull-requests#draft-pull-requests)
- [GIT](https://git-scm.com/)
- [Discord Server](https://discord.gg/qewu6fNgv7)
