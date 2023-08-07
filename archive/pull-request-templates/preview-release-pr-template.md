<!--
    !! NOTE !! - ONLY PROJECT OWNERS AND MAINTAINERS CAN CREATE PRODUCTION AND PREVIEW RELEASE PULL REQUESTS
    Please use the "preview-release-pr" pull request template if you have contributions to make.
-->
<!--suppress HtmlDeprecatedAttribute -->
<h1 style="font-weight:bold" align="center">Preview Release Pull Request</h1>
<h2 style="font-weight:bold" align="center">📋Review Checklist📋</h2>

- [ ] The **_head(source)_** branch for this pull request is a **_preview_** branch, with the correct naming syntax, in the following example:
  - A **_head(source)_** branch is the branch being merged into a target branch.
    <details closed><summary>Example</summary>

      ``` xml
      Syntax: preview/v<major>.<minor>.<patch>-preview.<prev-num>
      Example: preview/v1.2.3-preview.4
      ```
    </details>

- [ ] The **_base(target)_** branch for this pull request is a **_release_** branch, with the correct naming syntax, in the following example:
  - A **_base(target)_** branch is the branch that the **_head(source)_** branch is merging into.
    <details closed><summary>Example</summary>

      ``` xml
      Syntax: release/v<major>.<minor>.<patch>
      Example: release/v1.2.3
      ```
    </details>

- [ ] The **_head(source)_** branch for this pull request is created from a **_release_** branch with the correct naming syntax in the following example.
  <details closed><summary>Example</summary>

    ``` xml
    Syntax: release/v<major>.<minor>.<patch>
    Example: release/v1.2.3
    ```
  </details>

💡For more information on branching, refer to the project's [branching documentation](https://github.com/KinsonDigital/.github/blob/main/docs/BranchingModel.md).

- [ ] Associated issue exists and is linked to this pull request.
  - One issue per pull request.

- [ ] Pull request title is set to _**🚀Preview Release**_.

- [ ] A `🚀Preview Release` label has been added to this pull request. 

- [ ] Project assigned matches the project of the associated issue.

- [ ] Milestone assigned matches the milestone of the associated issue.

- [ ] A QA issue has been created and manual QA testing has been performed for the changes being released _(if applicable)_.
