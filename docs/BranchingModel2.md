<h1 align="center">Branching</h1>

This project uses a simple branching model.  It illustrates a clear purpose for adding features and releases.

As a standard contributor, all you have to worry about is creating <span style="color: #66B2FF;font-weight:bold">feature</span> branches and creating pull requests to merge those branches into the <span style="color: #82B366;font-weight:bold">master</span> branch.  The rest is taken care of by a solid CI/CD system as well as the maintainers of the project.  Only the organization owner and designated team members will manage the release process.  So, contributing is very easy!!🥳

---

<h2 align="center">Branches Used</h2>

<h3 align="left" style="color: #82B366;font-weight:bold">Master Branch</h3>

A long-living branch that represents stable production versions:
- **Branch Syntax:** master
- **Branches That Can Merge Into Master:**
  - <span style="color: #66B2FF;font-weight:bold">Feature</span> branches via pull request
- **Created From:** none
- **Merges Into:** none
- **Environment:** Production
- **Required Casing:** all lowercase
- **CI/CD:**
  - Upon pull request completion, the <span style="color: #66B2FF;font-weight:bold">feature</span> branches are merged into the <span style="color: #82B366;font-weight:bold">master</span> branch and are automatically built, tested, and released to production.

<h3 align="left" style="color: #66B2FF;font-weight:bold">Feature Branches</h3>

A short-living branch where a developer's work will be performed and merged back into the <span style="color: #82B366;font-weight:bold">master</span> branch via a pull request:
- **Branch Syntax:** feature/\<issue id\>-\<description\>
  - Example: feature/123-my-branch
- **Branches That Can Merge Into Feature Branches:** None
- **Created From:** <span style="color: #82B366;font-weight:bold">master</span>
- **Merges Into:** <span style="color: #82B366;font-weight:bold">master</span>
- **Environment:** none
- **Required Casing:** all lowercase
- **CI/CD:**
  - Build and unit test status checks are automatically run for each change to the pull request.
  - All status checks must pass before a pull request will be completed.

---

<h2 align="center">
    <div>
        <span style="font-weight:bold">Branching Diagram</span>
    </div>

![BranchingDiagram](https://raw.githubusercontent.com/KinsonDigital/.github/master/Images/FeatureToMasterBranchingDiagram-DarkMode.png#gh-dark-mode-only)
![BranchingDiagram](https://raw.githubusercontent.com/KinsonDigital/.github/master/Images/FeatureToMasterBranchingDiagram-LightMode.png#gh-light-mode-only)
</h2>
