<h2 style="border:0;font-weight:bold" align="center">Create a Branch to Contribute</h2>

### **1. Sync Branch**

Depending on whether you are implementing a <span style="color: #66B2FF;font-weight:bold">feature</span> or a <span style="color: #9E269E;font-weight:bold">preview feature</span> branch, synchronize the _**upstream**_ branch with your fork branch.
   - If implementing a <span style="color: #66B2FF;font-weight:bold">feature</span>

     ```cli
     git fetch upstream
     git checkout develop
     git merge upstream/develop
     git push
     git checkout preview/v1.2.3-preview.4
     ```

   - If implementing a <span style="color: #9E269E;font-weight:bold">preview feature</span>  
     - If implementing a <span style="color: #9E269E;font-weight:bold">preview feature</span> when the <span style="color: #CC99FF;font-weight:bold">preview</span> branch already exists locally and in your fork.

         ```cli
         git fetch upstream
         git checkout preview/v1.2.3-preview.4
         git merge upstream/preview/v1.2.3-preview.4
         git push
         git checkout preview/v1.2.3-preview.4
         ```

     - If the <span style="color: #CC99FF;font-weight:bold">preview</span> branch has never been checked out from the _**upstream**_ repository, it means that it doesn't exist in your fork.  Use the commands below to update your fork with the new branch from the _**upstream**_ repository.

       ```cli
       git fetch upstream
       git checkout -b preview/v1.2.3-preview.4 upstream/preview/v1.2.3-preview.4
       git push -u origin preview/v1.2.3-preview.4
       ```

### **2. Create a Working Branch**

Create a <span style="color: #66B2FF;font-weight:bold">feature</span> or  branch using the syntax requirements in the _**[Branching Docs](https://github.com/KinsonDigital/.github/blob/master/docs/Branching.md)**_ and push it to the fork remote. 
   - Make sure the <span style="color: #FFB366;font-weight:bold">develop</span> branch is checked out when creating a <span style="color: #66B2FF;font-weight:bold">feature</span> branch. 

      ```cli
      git checkout -b feature/123-my-branch
      git push --set-upstream origin feature/123-my-branch
      ```

   - Make sure the <span style="color: #CC99FF;font-weight:bold">preview</span> branch is checked out when creating a branch.

      ```cli
      git checkout -b preview/feature/123-my-branch
      git push --set-upstream origin preview/feature/123-my-branch
      ```

<h3 style="border:0;font-weight:bold" align="center">Additional Info</h3>

- Please always sync changes from the _**upstream**_ to your fork before creating your branch.
- Please make sure that you create your <span style="color: #66B2FF;font-weight:bold">feature</span> or  branch from the correct branch.
- If you are creating a branch and you do not see the <span style="color: #CC99FF;font-weight:bold">preview</span> branch to create it from, look for the branch in the _**upstream**_ ,check out the branch and push it to your fork.

