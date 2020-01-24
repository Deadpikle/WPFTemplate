# WPF Project Template

WPFTemplate is a simple project template for new C# WPF projects that allows you to quickly get a WPF project up and running. Out of the box, it has the following features ready to use:

* Data binding using the MVVM coding style (basic implementation for `INotifyPropertyChanged`)
* A templated `RelayCommand` class for data binding for `Button` `Command`s.
* Example of pushing and popping views using MVVM

## Using WPF Template

1. Clone the project or [use this project as a template](https://github.com/Deadpikle/WPFTemplate/generate)
2. Go into the Project properties for `WPFTemplate` and change the `Assembly name` and `Default namespace` (Right click the `WPFTemplate` project in Solution Explorer and click Properties)
3. Rename the project itself (Right click the `WPFTemplate` project in Solution Explorer and choose Rename)
4. Rename the solution (Right click the `WPFTemplate` solution in Solution Explorer and choose Rename)
5. Open any `.cs` file, right click the `WPFTemplate` namespace word, and choose Rename to rename the namespace throughout your project
6. Open `AssemblyInfo.cs` (under Properties) and rename the `AssemblyTitle` and `AssemblyProduct`
7. **Close** the solution in Visual Studio
8. Open the project's file location on disk and rename `WPFTemplate`
9. Open the `.sln` file in your favorite text editor and replace `WPFTemplate` to the folder name from the previous step
10. Go through each of the views.xaml files and App.xaml and replace the `WPFTemplate` name with your new namespace
11. Change license and other materials as necessary!

You may also want to delete the `.git` folder (if you cloned the project) and run `git init` and `git add .` to avoid any trouble with the fact that you cloned an existing project.

Is it annoying to have to do all that? Yup. Does it take too long? Nope. Perhaps someday we'll be able to automate the process or provide an actual VS-compatible project template :)

## Can I help contribute?

Glad you asked! There are always things that can be done on an open-source project: fix bugs, add new features, and more! Check out the issues tab of this repository and take a look at what bugs have been reported and which features have been requested. If you'd like to request a feature or file a bug, by all means, please do so!

## License

MIT License. Thanks for using this template!
