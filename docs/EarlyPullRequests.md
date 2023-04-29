<h2 style="border:0;font-weight:bold" align="center">Creating Early Pull Request</h2>

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
   > - Use one of the PR templates below depending on whether if you are doing a regular feature or a preview feature.

   Use the PR templates based on the branching model you are using:
    - Branching Model 1
      - [Feature PR Template - Regular Features](https://raw.githubusercontent.com/KinsonDigital/.github/master/.github/PULL_REQUEST_TEMPLATE/feature-pr-template.md)
      - [Preview Feature PR Template - Preview Features](https://raw.githubusercontent.com/KinsonDigital/.github/master/.github/PULL_REQUEST_TEMPLATE/preview-feature-pr-template.md)
    - Branching Model 1
      - [Feature To Prod PR Template - All Features](https://raw.githubusercontent.com/KinsonDigital/.github/master/.github/PULL_REQUEST_TEMPLATE/feature-to-prod-pr-template.md)
5. Make your commits in small, incremental steps with clear descriptions.
6. All unit tests must pass before a PR will be completed.
7.  Make sure that the code follows the coding standards.
    > **Note**
    > * Pay attention to the warnings in **Visual Studio** and/or **JetBrains Rider**!!
    > * Refer to the _**.editorconfig**_ files in the code base for rules.
8.  When you are finished with your changes, tag a maintainer in the PR comments and ask for a review!