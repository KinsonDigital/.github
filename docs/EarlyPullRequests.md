<h2 style="border:0;font-weight:bold" align="center">Creating Early Pull Request</h2>

1. If you have not already done so, complete the [Setting Things Up](https://github.com/KinsonDigital/.github/blob/main/docs/CONTRIBUTING.md) instructions.
2. If you have not already done so, complete the **Create a Branch to Contribute** section above.
3. Create an empty commit.  This allows you to create a PR without any changes.
   ```cli
   git commit --allow-empty -m "Start work for issue #123"
   git push
   ```
4. Create a [**draft pull request**](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/about-pull-requests#draft-pull-requests). Do this **BEFORE** you start working.
5. Make your commits in small, incremental steps with clear descriptions.
6. All status checks must pass before a PR will be completed.
7. Make sure that the code follows the coding standards.
    > **Note** Pay attention to the warnings in your IDE. Refer to the _**.editorconfig**_ files in the code base for rules.
8.  When you are finished with your changes, tag a maintainer in the PR comments and ask for a review!
