# Unity + GitHub
A sample project of Unity + GitHub.

## How to
Some notes on how to do stuff

### How to create the file structure
1. Create a Unity project and place the root **folder** of the project inside the repository.
2. Create a gitignore with [gitignore.io](https://www.toptal.com/developers/gitignore?templates=unity,jetbrains,jetbrains+all,rider,code,csharp) and place it in the root directory of the Unity project.
  1. Add `.idea/` if you use a JetBrains editor and don't want to push any files from it.

### How to add testing
1. Right click in the `Assets` folder and create Tests folder `Create -> Testing -> Tests Assembly Folder`.
2. Move the `.asmdef` file to the root folder in the `Assets` folder. (Note: Probably not the best practice).
3. Create a test file in the created test folder via Unity `Create -> Testing -> C# Test Script`.
