<h1 style="border:0;font-weight:bold" align="center">Contribution Guide</h1>

Welcome, and thank you for considering contributing to our projects! We appreciate any help you can provide and are constantly looking for ways to make the contribution process as simple as possible. Our top priority is maintaining high software quality, and we rely on the input of talented outside contributors like you to achieve that goal.

If you have any ideas or comments on how we can improve the process, please don't hesitate to reach out to one of our project maintainers. We value your input and would love to hear from you.

There are several ways you can contribute to our projects, including creating GitHub issues for any problems you encounter, submitting code contributions, and more. To ensure your contributions are properly directed, please only use the issues marked with the description _**(Outside contributors only)**_. Our project maintainers will handle the rest.

Thank you again for your interest in contributing to our projects, and we look forward to working with you!

**Considerations:**

Only the **KinsonDigital** team will merge changes that improve the library significantly. We will not merge changes that have narrowly-defined benefits or contain breaking changes in any way. All contributions must also follow all other guidelines outlined in this document.

<h2 style="border:0;font-weight:bold" align="center">DO's and DON'Ts</h2>

**Please:**

- **DO** follow the [code of conduct](https://github.com/KinsonDigital/.github/blob/master/docs/code_of_conduct.md) on GitHub.
- **DO** follow the `📃rules` on [Discord](https://discord.gg/qewu6fNgv7).
- **DO** talk to us on our [Discord](https://discord.gg/qewu6fNgv7) server.
- **DO** keep issue discussions around contributions focused.
- **DO** use the comment sections in the issues and pull requests (PRs) that are relevant to said issues and PRs.  This not only keeps conversations contained in the issues and PRs, but it also sends notifications to the project maintainers and shows the conversation to the community/public.
- **DO** leave a comment on the issue that you are interested in to let the project maintainers know that you would like to work on the issue.
- **DON'T** start working on a PR until you get confirmation from a project maintainer and the issue is assigned to you.  We do not want to waste your time on an issue that you are not allowed to work on.
- **DON'T** make PRs that don't directly affect the end user, such as style changes. These are best done as part of a PR related to the area in question. Documentation is fine (and encouraged!), as is useful to the end user.
- **DO** follow branch naming requirements and practices based on the branching model used for a project.
- **DO** create PRs with the title that matches **EXACTLY** the associated issue's title.  PRs with mismatching titles will not pass status checks and cannot be merged.
- **DO** use [pull request templates](https://github.com/KinsonDigital/.github/tree/master/.github/PULL_REQUEST_TEMPLATE) when creating PRs.  Pull requests without a PR template will not be merged.
- **DO** use early pull requests. (More info below)
- **DON'T** commit code you didn't write without following its license and without following our guidelines in the Contributor License Agreement. If you are unable to license the code, don't commit it.
- **DON'T** surprise us with big PRs or big API changes without talking to us first!
- **DON'T** make PRs for legal or administrative documents, such as the license, file headers, or code of conduct. If something is off, let us know and we will look into changing it.

<h2 style="border:0;font-weight:bold" align="center">Breaking Changes</h2>

Contributions must maintain API signature and behavioral compatibility. Contributions that include breaking changes MUST be discussed with project maintainers first. Breaking changes are subject to the team's approval. At the risk of sounding like a broken record, talk to us about your idea first!

<h2 style="border:0;font-weight:bold" align="center">Setting Things Up</h2>

For first-time contributors, you need to fork the repository so you can contribute.  There are a few steps that you will need to go through to start contributing.  Go [here](https://github.com/KinsonDigital/.github/blob/master/docs/HowToFork.md) to follow the steps on forking the repository.  There are lots of resources on the web on what forking is and how to do this.

<h2 style="border:0;font-weight:bold" align="center">Branching</h2>

The projects in the KinsonDigital organization have different branching models.  Refer to the different branching models used below to get pointed to the correct branching model documentation for that branching model.  Go [here](https://github.com/KinsonDigital/.github/blob/master/docs/ProjectBranchingModelList.md) for a list of the branching models used for the KinsonDigital organization projects.

1. [Branching Model 1](https://github.com/KinsonDigital/.github/blob/master/docs/BranchingModel1.md)
   > **Note** This is the most complicated branching model used with some of the projects.  This gives projects maximum control over changes and CICD to make sure that breaking changes do not end up in production.  This branch is similar to GitFlow but with the added ability to deal with preview releases.
2. [Branching Model 2](https://github.com/KinsonDigital/.github/blob/master/docs/BranchingModel2.md)
   > **Note** This is the simplest branching model.  This makes it easier to to contribute to with a sacrifice in maximum control.  This is used more for projects are are more UI oriented with no public facing API to worry about.

---

We take pride in maintaining a clear and consistent branch naming policy that helps us efficiently manage our codebase. By doing so, it makes it easy for our CI/CD system to validate issues and pull requests, ensuring a seamless workflow.

We kindly ask that you take a moment to review your branch names before submitting a PR. To ensure proper integration with our GitHub repository, branch names should be in all lowercase and contain a valid issue number. Don't worry if you make a mistake; we're all human! Simply tag a maintainer in your PR, and we'll help you correct any errors.

<h2 style="border:0;font-weight:bold" align="center">Creating Contribution Branches</h2>

* Go [here](https://github.com/KinsonDigital/.github/blob/master/docs/CreatingModel1Branches.md) to follow instructions on how to create a contribution branch for projects that follow [Branching Model 1](https://github.com/KinsonDigital/.github/blob/master/docs/BranchingModel1.md)
* Go [here](https://github.com/KinsonDigital/.github/blob/master/docs/CreatingModel2Branches.md) to follow instructions on how to create a contribution branch for projects that follow [Branching Model 2](https://github.com/KinsonDigital/.github/blob/master/docs/BranchingModel2.md)

<h2 style="border:0;font-weight:bold" align="center">Creating Early Pull Requests</h2>

Refer to the **DO's and DON'Ts** section for details about PRs.

We encourage and use [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're finished with your work before creating a PR!  
Go [here](https://github.com/KinsonDigital/.github/blob/master/docs/EarlyPullRequests.md) to learn how to create an early pull request.


<h2 style="border:0;font-weight:bold" align="center">"Help wanted" & "Good first issue"</h2>

If the core team is unable to champion an issue, they will mark it with a "help wanted" label. This indicates that any external contributor may pick it up and implement it as part of a contribution. However, some **"help wanted"** issues may require intermediate knowledge of the codebase, area, and/or ecosystem; or may have uncertainty surrounding implementation details.  If this is the case, talk to us in [Discord](https://discord.gg/qewu6fNgv7) or the issue's discussion. We also mark some issues with the label **"good first issue"** which indicates that an issue is straightforward and is a good place to start if you're interested in contributing but are new to the codebase.


<h3 style="border:0;font-weight:bold" align="left">Resources</h3>

- [Forking a Repository](https://docs.github.com/en/get-started/quickstart/fork-a-repo)
- [Working With Forks](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/about-forks)
- [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6)
- [Draft Pull Requests](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/about-pull-requests#draft-pull-requests)
- [GIT](https://git-scm.com/)
- [Discord Server](https://discord.gg/qewu6fNgv7)
