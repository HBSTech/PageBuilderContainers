# ShareableComponentBoilerplate
This boilerplate will get you started on creating a share-able Kentico MVC Component that you can publish to NuGet and to the marketplace.  Everything is preconfigured and thanks to the `RenameProject.bat` Setup only takes a couple minutes.

# Instructions
## Clone and modify
1. Use this Template to create your own repostiory.
1. Download your repository onto your computer (I highly recommend making a separate `Kentico Repositories` folder that is not connected to your Kentico Admin nor Kentico MVC instance)
1. Once downloaded, run the `RenameProject.bat` and enter in your project information
1. Open the Solution file, right click on your solution and Clean Solution
1. Rebuild your solution
  * note, if you get a Roslyn.exe error, clean and build the Views Web App separately, this sometimes happens

You are now ready to add your code and view files for your component.

## (optional) Add to your Kentico Instance
It is recommended that for development of shareable content, you have a testing Kentico Instance, however this is not required.  You can create a fresh installation of Kentico 12, just make sure it's hotfixed to the Service Pack (hotfix 29)  You can also [check out Kentico's repository](https://github.com/Kentico/ems-mvc-component-starter) which has it's own guide to creating a test instance.

Once you have your Kentico 12 SP instance set up:

1. Open your Kentico MVC Web App's solution
1. On the solution, right click and add Existing project, and select your Component Projects (View project is optional)
1. On your MVC Web App, right click on references and add a reference to your Component project (not the View, just the code).
1. Build your Component project, and the MVC Web Application Project

## Create NuGet Package
In the main component project, there is a `BuildPackage.bat` file.  Run this to create your nuget package.  You can then upload it to NuGet.org

*NOTE: The BuildPackage.bat is set to build only in release mode.  Make sure your solution is set to Release and rebuilt in that mode*

You may want or need to modify the following:

### Assembly
When publishing new versions, you will want to open up your Solution, right click on your Component Project, and go to the Properties page.  You can click on "Assembly info" to update version and other information.

### Nuget Info
Modify the XXXX.nuspec file to add things such as Tags, Icons, release notes (you should update your release notes with what the update contains or the bug fixes perhaps).  You may also need to add additional <file> elements to include items beyond the Compiled Views library.  Please see [Microsoft Nuspec Documentation](https://docs.microsoft.com/en-us/nuget/reference/nuspec]) for more info.
  
## Submission to Kentico Marketplace
Once you have your Repository updated and the NuGet package uploaded, you can perform a pull request to the Kentico Marketplace to include your tool on the listing.

## Targets Modification
There are 2 .Targets files, these can be modified to (on build) copy files to differnet projects.  This is needed for the Compiled Views (which is already pre-configured for you), but you can also modify it to move other files over from your library to your development MVC web app project.  Examples are given in the commented area.

Please remember, anything that needs to be exported with the nuget package needs to be handled in the nuspec file by copying the file into the Content location of the nuget package.
