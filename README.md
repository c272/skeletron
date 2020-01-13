# AQA Skeletron
*A graphical representation of the AQA Paper 1 Skeleton Program.*

This program emulates nearly exactly the AQA Paper 1 Skeleton program from A-Level Computer Science (2018). You can use this tool to better understand how the simulation works, or to simply mess around with/make changes to it. To get started, see the below section.

## Getting Started
To begin using this graphical emulator, download and build this repository using Visual Studio 2017 or higher. It's as simple as that. If you're having trouble building because of missing assemblies, go to "`Project -> Manage NuGet Packages` and click "Restore". This should fix the issue.

However, if you wish to make changes to the program and also update the documentation by submitting a pull request, you'll also have to install DocFX as a NuGet package. This can be done with the following command:
```
>nuget install docfx
```
Once this is done, you'll want to clone the documentation branch into a sub folder named "docs". The auto documentation build script can then be executed when you've made the necessary changes.

## Documentation
Full documentation for all the methods, properties and other fields are available through the hosted page ([here](c272.github.io/skeletron)), and also in the "docs" folder. If none of these are any help, you can contact me at @c272.
