<h2 style="border:0;font-weight:bold" align="center">Creating a Branch to Contribute to GitHub Actions</h2>

### **1. Syncing changes from upstream**

Sync the _**upstream**_ branch with your fork branch.
```cli
git fetch upstream
git checkout master
git merge upstream/master
git push
```

### **2. Create a working branch**

Create a <span style="color: #66B2FF;font-weight:bold">feature</span> branch in your fork using the syntax requirements in the _**[Branching Docs](https://github.com/KinsonDigital/.github/blob/master/docs/BranchingFeatureToMaster.md)**_ and push it to the fork remote. 
   - Use the commands below to create a <span style="color: #66B2FF;font-weight:bold">feature</span> branch. Make sure the <span style="color: #FFB366;font-weight:bold">master</span> branch is checked out.
        ```cli
        git checkout -b feature/123-my-branch
        git push --set-upstream origin feature/123-my-branch
        ```

- Please always sync changes from the _**upstream**_ to your fork before creating your branch.
- Please make sure that you create your <span style="color: #66B2FF;font-weight:bold">feature</span> branch from the <span style="color: #FFB366;font-weight:bold">master</span> branch.

### **3. After work is complete**

Once your work is complete, create a pull request that will merge your fork <span style="color: #66B2FF;font-weight:bold">feature</span> branch into the original upstream <span style="color: #FFB366;font-weight:bold">master</span> branch.
> **Note** Make sure to take your PR out of draft and @mention a maintainer that the PR is ready for review.
