<h2 style="border:0;font-weight:bold" align="center">How to Fork the Repository</h2>

### **1. Fork the repository**

> **Note**
> For more information on how to fork a repository, go [here](https://docs.github.com/en/get-started/quickstart/fork-a-repo?platform=windows&tool=cli).

### **2. Clone the forked repository**

When setting up the cloned fork of the repository on your machine, adding a new remote of the original project is important.  It is common practice to name the new remote as `upstream`.  This remote represents the original repository that your repository was forked from.

This will enable you to fetch new changes from the original repository as well as create pull requests.  Once everything is set up, you should have 2 remotes.  One with the name `origin` which is the link to the repository fork in **YOUR** account.  The other remote should be named `upstream` which is the link to the original repository your trying to contribute to.

> **Note** When cloning the repo to your machine, make sure to replace `myproject` with the name of the project to clone.

```cli
git clone https://github.com/johndoe/myproject.git
cd myproject
git remote add upstream https://github.com/KinsonDigital/myproject.git
```

### **3. Let GIT know who you are**
To better track changes and know who did what, it is good practice to give GIT some information about yourself.

> **Note** Be sure to replace `johndoe` with your username, and `john.doe@example.com` with your email.

```cli
git config --global user.name "John Doe"
git config --global user.email "john.doe@example.com"
```
