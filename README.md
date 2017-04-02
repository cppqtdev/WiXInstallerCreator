# WiX Installer Creator

## Description
WiX Installer Creator can be used to create WiX based setup files. Just show the tool your project bin directory (up to Debug/Release) and the tool automatically generates a setup file for that project with minimal effort.

## Using WiX Installer Creator
Here is the first look at WiX Installer Creator. This is a Windows Form Application.
 
### Project Bin Directory
Location of your project. Keep in mind you can create an installer of any directory. But for your Windows Form Applications you need to give it a path up to the configuration directory (Debug/Release).
This path should not contain space(s).

### Upgrade Code
The upgrade code has a major role to play here. Lets say you are creating an installer for the next version of a previously created project and you want the new installer to uninstall any previous version of that tool and install a new copy. You need to save your upgrade code for a particular project somewhere so that for the same tool or projects upgrade code matches.

### Tool Description
This is a mandatory field. So you have to put a description for your project here.

### Create Desktop Shortcut
By default this option is checked. If you do not want your setup file to create a desktop shortcut upon installation just uncheck this.

### Advance Options
To see the advance options click on Advance button. This will show you some other options.
 
### User Agreement
You can check mark this option if you want to have an user agreement option on your setup file.

### Create Installer
After you fill out all the fields click on Create Installer button.
 
This will prompt you to select an exe file to be the main application executable if found on the given directory which will automatically get the tool name and version number from the selected executable.
 
Or you can set those manually in case there is no exe file in the directory or you prefer otherwise.
 
If everything goes well you will see that your installer is being created.
 
## Versions
1.1.0 - Release date: 04/01/2017
This is the initial release. 
