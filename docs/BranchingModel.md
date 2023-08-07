<h1 align="center">Branching</h1>

This document illustrates a clear purpose for adding features in **preview** and **production** releases.

As any contributor, you only have to worry about creating <span style="color: #66B2FF;font-weight:bold">feature</span> branches from the <span style="color: #82B366;font-weight:bold">main</span> or <span style="color: #CC99FF;font-weight:bold">preview</span> branch and creating pull requests to merge those branches into the same branch that the **feature** branch was created from.  The rest is taken care of by a solid CI/CD system as well as the maintainers of the project.  Only the organization owner and designated team members will manage the release process.  So, contributing is very easy!!🥳


<h2 align="center" style="border:0">Branches Used</h2>


<h3 align="left" style="color: #82B366;font-weight:bold">Main Branch</h3>

A long-living branch that represents stable production versions:
- **Branch syntax:** main
- **Branches that can be merged into this one:**
  - <span style="color: #66B2FF;font-weight:bold">feature</span> branches via pull request
  - <span style="color: #CC99FF;font-weight:bold">preview</span> branches via pull request
- **Created from:** none
- **Merges into:** none
- **Required casing:** all lowercase
- **CI/CD:** Pull requests that merge into this branch contain various status checks depending on the project and all must pass before they can be merged into this branch.


<h3 align="left" style="color: #CC99FF;font-weight:bold">Preview Branches</h3>

Holds minimal changes required for the stability of an upcoming **production** release.  This is the branch you create **feature** branches from and merge **feature** branches into to make a change to a **preview** version of the software.

**_NOTE_:** Used for refactoring, bug fixes, and changes related to making upcoming releases more stable.  This gives users the chance to utilize the software and provide feedback before a major release.  Introducing major features outside of the changes in the upcoming release is not allowed. These kinds of changes are performed on the <span style="color: #CC99FF;font-weight:bold">preview</span> branch by using <span style="color: #66B2FF;font-weight:bold">feature</span> branches.
- **Branch syntax:** preview
- **Branches that can be merged into this one:** <span style="color: #66B2FF;font-weight:bold">feature</span> branches
- **Created from:** <span style="color: #82B366;font-weight:bold">main</span> branch
- **Merged into:** <span style="color: #82B366;font-weight:bold">main</span> branch
- **Required casing:** all lowercase
- **CI/CD:** All status checks must pass before merging a pull request into this branch can be completed.


<h3 align="left" style="color: #66B2FF;font-weight:bold">Feature Branches</h3>

A short-lived branch where a developer's work will be performed and merged back into the <span style="color: #82B366;font-weight:bold">main</span> or <span style="color: #CC99FF;font-weight:bold">preview</span> branch via a pull request:
- **Branch syntax:** feature/\<issue id\>-\<description\>
  - **Example:** feature/123-my-branch
- **Branches that can be merged into this one:** None
- **Created from:** <span style="color: #82B366;font-weight:bold">main</span> or <span style="color: #CC99FF;font-weight:bold">preview</span>
- **Merges into:** <span style="color: #82B366;font-weight:bold">main</span> or <span style="color: #CC99FF;font-weight:bold">preview</span>
- **Required casing:** all lowercase
- **CI/CD:** All required status checks must pass before a pull request will be merged.

---

<h2 align="center" style="border:0">
   <div>
      <span style="font-weight:bold">Branching Diagram</span>
   </div>

![dark mode diagram](../Images/branch-diagram-dark-mode.drawio.svg#gh-dark-mode-only)
![light mode diagram](../Images/branch-diagram-light-mode.drawio.svg#gh-light-mode-only)
</h2>
