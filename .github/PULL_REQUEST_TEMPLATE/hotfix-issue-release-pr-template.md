<!--suppress HtmlDeprecatedAttribute -->
<h1 style="font-weight:bold" align="center">HotFix Issue Release Pull Request</h1>
<h2 style="font-weight:bold" align="center">📋Review Checklist📋</h2>

- [ ] The **_head(source)_** branch for this pull request is a **_hotfix_** branch, with the correct naming syntax, in the following example:
  - A **_head(source)_** branch is the branch being merged into a target branch.
    <details closed><summary>Example</summary>

      ``` xml
      Syntax: hotfix/<issue-num>-<description>
      Example: hotfix/123-my-fix
      ```
    </details>

- [ ] The **_base(target)_** branch for this pull request is a **_production_** branch with the name of **_master_**.
  - A **_base(target)_** branch is the branch that the **_head(source)_** branch is merging into.

- [ ] The **_head(source)_** branch for this pull request is created from a **_production_** branch with the name **_master_**.

💡For more information on branching, refer to the project's [branching documentation](https://github.com/KinsonDigital/.github/blob/master/docs/BranchingFullGitFlow.md).

- [ ] Associated issue exists and is linked to this pull request.
  - One issue per pull request.

- [ ] Pull request title matches the title of the associated issue.

- [ ] A `🔥Hot Fix Release🚀` label has been added to the pull request.

- [ ] The labels attached to this PR match the labels attached to the associated issue.

- [ ] Project assigned matches the project of the associated issue.

- [ ] Milestone assigned matches the milestone of the associated issue.

- [ ] My code follows the coding style of this project.
  - The style is enforced by the **_.editorconfig_** files in the project and displayed as warnings.  If there is an edge case, reach out, and let's discuss it.

- [ ] I have manually tested my code changes to the best of my ability.

- [ ] All tests passed locally.
  - This is required because unit tests might pass locally but not in the CI environment during the status check process or vice-versa.
  - Tests might pass on the developer's machine but not necessarily on the code reviewer's machine.
  - Status checks run for this pull request when merging into the **_preview/v\*.\*.\*-preview.\*_** branch.  These status checks run every time a change is pushed to the pull request.  These checks validate version syntax, tagging, builds, unit tests, and more.
