<h2 style="border:0;font-weight:bold" align="center">Create a Branch to Contribute</h2>


When creating a branch, you need to determine if the feature or change you want to contribute is for a **production** release or a **preview** release.

If you want to release something to **production**, then you create your <span style="color: #66B2FF;font-weight:bold">feature</span> branch from the <span style="color: #82B366;font-weight:bold">main</span> branch. If you want to contribute to a **preview** release, you need to create your <span style="color: #66B2FF;font-weight:bold">feature</span> branch from the <span style="color: #CC99FF;font-weight:bold">preview</span> branch.

> **Note** Both branches will be merged into the same branch they were created from, via a pull request.

Whatever method you want to use for creating your branches and pull requests is up to you and your preference.  But below is the git commands that you could use to help contribute to any of the **KinsonDigital** projects.


### **1. Sync Branch**

As time moves on, the original repository changes.  This means that you need to keep your fork up to date as changes stream into the main repository.  It is important that you keep your fork up to date before you create a new branch.  Their are different options to do this.  To use the GitHub web interface go [here](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/syncing-a-fork).  To use the GIT command line, follow the steps below.

- Syncing changes from the <span style="color: #82B366;font-weight:bold">main</span> branch.
    ```cli
    git fetch upstream
    git checkout main
    git merge upstream/main
    git push origin
    ```

- Syncing changes from the <span style="color: #CC99FF;font-weight:bold">preview</span> branch.
    ```cli
    git fetch upstream
    git checkout preview
    git merge upstream/preview
    git push origin
    ```

### **2. Create a Working Branch**

Create a <span style="color: #66B2FF;font-weight:bold">feature</span> branch using the syntax requirements in the _**[Branching Docs](https://github.com/KinsonDigital/.github/blob/preview/docs/BranchingModel.md)**_ and push it to the fork remote. 
   - Make sure the <span style="color: #82B366;font-weight:bold">main</span> or <span style="color: #CC99FF;font-weight:bold">preview</span> branch is checked out when creating a <span style="color: #66B2FF;font-weight:bold">feature</span> branch. 

      ```cli
      git checkout -b feature/123-my-branch
      git push --set-upstream origin feature/123-my-branch
      ```

<h3 style="border:0;font-weight:bold" align="center">Additional Info</h3>

- Please always sync changes from the _**upstream**_ to your fork before creating your branch.
- Please make sure that you create your <span style="color: #66B2FF;font-weight:bold">feature</span> branch from the correct branch.
- If you are creating a branch and you do not see the <span style="color: #CC99FF;font-weight:bold">preview</span> branch to create it from, look for the branch in the _**upstream**_, check out the branch and push it to your fork.
