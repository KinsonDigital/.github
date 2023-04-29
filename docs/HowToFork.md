<h2 style="border:0;font-weight:bold" align="center">How to Fork the Repository</h2>

### **1. Fork the repository**

> **Note**
> For more information on how to fork a repository, go [here](https://docs.github.com/en/get-started/quickstart/fork-a-repo).

### **2. Clone the forked repository**

> **Note** When cloning the repo to your machine, be sure to swap `johndoe` with your username and `myproject` with the name of the project to clone.
   ```cli
   git clone https://github.com/johndoe/myproject.git
   cd myproject
   git remote add upstream https://github.com/KinsonDigital/myproject.git
   ```

### **3. Let GIT know who you are**
To better track changes and know who did what, it's good practice to give GIT some information about yourself.
   ```cli
   git config --global user.name "John Doe"
   git config --global user.email "john.doe@example.com"
   ```