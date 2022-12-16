<h1 style="border:0;font-weight:bold" align="center">Contribution Guide</h1>

Hello!!  Thanks for your interest in contributing to our project!!  Any help you can provide is greatly appreciated.  We are always looking for ways to make the contribution process as simple and as straightforward as possible. In addition, we want to make sure that the required workflow and development processes are followed in order to maintain high software quality. If you have any ideas and/or comments on how to simplify the process for outside contributors, please don't hesitate to contact one of the project maintainers.

You can contribute to our projects with issues and PRs. Creating GitHub issues for problems you encounter and code contribution are other ways to help out and are greatly appreciated!

When contributing with an issue, please only use the issues with the description that says _**(Outside contributors only)**_.  The rest of the issues are used by project maintainers.  

**Considerations:**

Only the **KinsonDigital** team will merge changes that improve the library significantly. We will not merge changes that have narrowly-defined benefits or are breaking in any way. All contributions must also follow all other guidelines outlined in this document.

<h2 style="border:0;font-weight:bold" align="center">DO's and DON'Ts</h2>

**Please:**

- **DO** follow the [code of conduct](https://github.com/KinsonDigital/.github/docs/code_of_conduct.md) on GitHub.
- **DO** follow the `📃rules` on [Discord](https://discord.gg/qewu6fNgv7).
- **DO** talk to us on our [Discord](https://discord.gg/qewu6fNgv7) server.
- **DO** keep issue discussions around contributions focused.
- **DO** use the comment sections in the issues and pull requests (PRs) that are relevant to said issues and PRs.  This not only keeps conversations contained in the issues and PRs, it sends notifications to the project maintainers, and shows the conversation to the community/public.
- **DO** leave a comment in the issue that you are interested in to let the project maintainers know that you would like to work on the issue.
- **DON'T** start working on a PR until you get confirmation from a project maintainer and the issue is assigned to you.  We do not want to waste your time on an issue that you are not allowed to work on.
- **DON'T** make PRs that don't directly affect the end user, such as style changes. These are best done as part of a PR related to the area in question. Documentation is fine (and encouraged!), as is useful to the end user.
- **DO** follow [branch naming requirements and practices](https://github.com/KinsonDigital/.github/docs/Branching.md).
- **DO** create PRs with the title and matching **EXACTLY** to the associated issue's title.  PRs with mismatching titles will not pass status checks and cannot be merged.
- **DO** use [pull request templates](https://github.com/KinsonDigital/.github/tree/master/.github/PULL_REQUEST_TEMPLATE) when creating PRs.  Pull requests without a PR template will not be merged.
- **DO** use [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6).
- **DON'T** commit code you didn't write without following its own license and without following our guidelines in the Contributor License Agreement. If you are unable to license code, don't commit it.
- **DON'T** surprise us with big PRs or big API changes without talking to us first!
- **DON'T** make PRs for legal or administrative documents, such as the license, file headers, or code of conduct. If something is off, let us know and we will look into changing it.

<h2 style="border:0;font-weight:bold" align="center">Breaking Changes</h2>

Contributions must maintain API signature and behavioral compatibility. Contributions that include breaking changes MUST be discussed with project maintainers first. Breaking changes are subject to the team's approval. At risk of sounding like a broken record, talk to us about your idea first!

<h2 style="border:0;font-weight:bold" align="center">Branching</h2>

Go [here](./Documentation/Branching.md) for more information on <span style="color: #66B2FF;font-weight:bold">feature</span> and <span style="color: #9E269E;font-weight:bold">preview feature</span> branches.

The branching model for the project is more complicated than most OS projects but as an outside contributor, you only have to worry about 2 types of branches!

Our projects follow a strict naming policy. The purpose is for clarity and consistency, and it helps bind the information between GIT and GitHub. It also allows our CI/CD system to perform its job by validating issues and PRs using status checks.

Before creating a <span style="color: #66B2FF;font-weight:bold">feature</span> or <span style="color: #9E269E;font-weight:bold">preview feature</span> branch, you need to figure out whether or not the project is currently in preview.  If it is in preview, you create a <span style="color: #9E269E;font-weight:bold">preview feature</span> branch from the latest <span style="color: #CC99FF;font-weight:bold">preview</span> branches.  If it's not in preview, you create a <span style="color: #66B2FF;font-weight:bold">feature</span> branch from the <span style="color: #FFB366;font-weight:bold">develop</span> branch.

How do you know if the project is in preview? Check out the options below:
1. Check for the most recent branch in GIT and see if it is a <span style="color: #CC99FF;font-weight:bold">preview</span> branch.
2. Check if the latest milestone contains a preview release or production release as its title.
   - Production release example: v1.2.3
   - Preview release example: v1.2.3-preview.4
3. Reach out to a maintainer and ask.

Please make sure that you take the time and verify that the branch name is correct.  Branch names must be all lower case and the issue number in the branch name must be a valid GitHub issue number.  If the branch naming syntax, casing, or issue number is incorrect, the status checks for the CI/CD system will detect this and prevent the PR from being merged.

Of course, we are all human and people make mistakes!!  This is ok and no harm is done.  If you do accidentally create a PR with a head(source) branch name that is incorrect, tag a maintainer in the PR about the mistake and recreate the PR.  If for some reason you used the incorrect base(target) branch, the PR does not have to be recreated.  You should be able to edit the title and the base(target) branch because you are the author of the PR.

<h2 style="border:0;font-weight:bold" align="center">Setting Things Up</h2>

For first-time contributors, there are a few steps that you will need to go through to start contributing.

### **1. Fork the repository**
First, fork the repository.

> **Note**
> For more information on how to fork a repository, go [here](https://docs.github.com/en/get-started/quickstart/fork-a-repo).

### **2. Clone the forked repository**
Clone the forked repository to your machine so you can add your changes.  Swap `johndoe` with your username.
   ```cli
   git clone https://github.com/johndoe/myproject.git
   cd myproject
   git remote add upstream https://github.com/KinsonDigital/myproject.git
   ```

### **3. Let GIT know who you are**
To better track changes and who does what, it's a good practice to give GIT some information about yourself.
   ```cli
   git config --global user.name "John Doe"
   git config --global user.email "john.doe@example.com"
   ```

<h2 style="border:0;font-weight:bold" align="center">Create a Branch to Contribute</h2>

### **1. Sync Branch**

Sync the _**upstream**_ branch with your fork branch depending on if you are implementing a <span style="color: #66B2FF;font-weight:bold">feature</span> or <span style="color: #9E269E;font-weight:bold">preview feature</span>.
   - If implementing a <span style="color: #66B2FF;font-weight:bold">feature</span>

     ```cli
     git fetch upstream
     git checkout develop
     git merge upstream/develop
     git push
     git checkout preview/v1.2.3-preview.4
     ```

   - If implementing a <span style="color: #9E269E;font-weight:bold">preview feature</span>  
     - If the <span style="color: #CC99FF;font-weight:bold">preview</span> branch already exists locally and in your fork.

         ```cli
         git fetch upstream
         git checkout preview/v1.2.3-preview.4
         git merge upstream/preview/v1.2.3-preview.4
         git push
         git checkout preview/v1.2.3-preview.4
         ```

     - If the <span style="color: #CC99FF;font-weight:bold">preview</span> branch has never been checked out from the _**upstream**_ repository before, this means it does not exist in your fork.  Use the commands below to update your fork with the new branch from the _**upstream**_ repository.

       ```cli
       git fetch upstream
       git checkout -b preview/v1.2.3-preview.4 upstream/preview/v1.2.3-preview.4
       git push -u origin preview/v1.2.3-preview.4
       ```

### **2. Create a Working Branch**

Create a <span style="color: #66B2FF;font-weight:bold">feature</span> or  branch using the syntax requirements in the _**[Branching Docs](https://github.com/KinsonDigital/.github/docs/Branching.md)**_ and push it to the fork remote. 
   - Creating a <span style="color: #66B2FF;font-weight:bold">feature</span> branch. Make sure the <span style="color: #FFB366;font-weight:bold">develop</span> branch is checked out.

      ```cli
      git checkout -b feature/123-my-branch
      git push --set-upstream origin feature/123-my-branch
      ```

   - Creating a  branch. Make sure the <span style="color: #CC99FF;font-weight:bold">preview</span> branch is checked out.

      ```cli
      git checkout -b preview/feature/123-my-branch
      git push --set-upstream origin preview/feature/123-my-branch
      ```

<h3 style="border:0;font-weight:bold" align="center">Additional Info</h3>

- Please always sync changes from the _**upstream**_ to your fork before creating your branch.
- Please make sure that you create your <span style="color: #66B2FF;font-weight:bold">feature</span> or  branch from the correct branch.
- If you are creating a  branch and you do not see the <span style="color: #CC99FF;font-weight:bold">preview</span> branch to create it from, look for the branch in the _**upstream**_ and check out the branch and push it to your fork so your fork has a copy.

<h2 style="border:0;font-weight:bold" align="center">Creating Early Pull Request (PR)</h2>

Refer to the **DO's and DON'Ts** section for details about PRs.

We encourage and use [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're finished with your work before creating a PR!

1. If you have not already done so, complete the **Setting Things Up** section above.
2. If you have not already done so, complete the **Create a Branch to Contribute** section above.
3. Create an empty commit.  This allows you to create a PR without any changes.
   ```cli
   git commit --allow-empty -m "Start work for issue #123"
   git push
   ```
4. Create a [**draft pull request**](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/about-pull-requests#draft-pull-requests). Do this **BEFORE** you start working.
   > **Note**
   Please make sure that the title of the PR _**EXACTLY**_ matches the title of the associated issue.
   > - Use one of the PR templates below depending on if you are doing a regular feature or a preview feature.
     >   - [Feature PR Template](https://raw.githubusercontent.com/KinsonDigital/.github/master/.github/PULL_REQUEST_TEMPLATE/feature-pr-template.md)
     >    - [Preview Feature PR Template](https://raw.githubusercontent.com/KinsonDigital/.github/master/.github/PULL_REQUEST_TEMPLATE/preview-feature-pr-template.md)
5. Make your commits in small, incremental steps with clear descriptions.
6. All unit tests must pass before a PR will be completed.
7.  Make sure that the code follows the coding standards.
    > **Note**
    > * Pay attention to the warnings in **Visual Studio** and/or **JetBrains Rider**!!
    > * Refer to the _**.editorconfig**_ files in the code base for rules.
8.  When you are finished with your changes, tag a maintainer in the PR comments and ask for a review!

<h2 style="border:0;font-weight:bold" align="center">"Help wanted" & "Good first issue"</h2>

If the core team is unable to champion an issue, they will mark it with a "help wanted" label. This indicates that any external contributor may pick it up and implement it as part of a contribution. However, some **"help wanted"** issues may require intermediate knowledge of the codebase, area, and/or ecosystem; or may have uncertainty surrounding implementation details.  If this is the case, talk to us in [Discord](https://discord.gg/qewu6fNgv7) or in the issue's discussion. We also mark some issues with the label **"good first issue"** which indicates that an issue is straightforward and is a good place to start if you're interested in contributing but are new to the codebase.


<h3 style="border:0;font-weight:bold" align="left">Resources</h3>

- [Forking a Repository](https://docs.github.com/en/get-started/quickstart/fork-a-repo)
- [Working With Forks](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/about-forks)
- [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6)
- [Discord Server](https://discord.gg/qewu6fNgv7)
- [Main Branching Docs](./Documentation/Branching.md)
- [Draft Pull Requests](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/about-pull-requests#draft-pull-requests)
- [GIT](https://git-scm.com/)
