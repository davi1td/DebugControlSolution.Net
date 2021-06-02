Per this link for debugging a custom Winforms Control for .net Framework 4.8:
[Walkthrough: Debug Custom Windows Forms Controls at Design Time](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/walkthrough-debugging-custom-windows-forms-controls-at-design-time?view=netframeworkdesktop-4.8).

It does not work for .net core 3.x through .net 5. No Modules are loaded and therefore can't debug on any line, no source loaded.

Working Example 4.8 Framework: 
In the below image, if you were to load Form1 the break line would indeed be hit, notice how before that happens though, all modules are loaded as expected execpt for the DebugControl, which isn't loaded yet.
![](/misc/DebuggerControl.Net.4.8.Working.jpg)

Non working Example .net core -> 5:
Here everything is the same:same IDE, Symbols set to "Load all modules, unless excluded" just as before, except its targeted for .net 5.

![](/misc/DebuggerControl.Net.5.Not.Working.jpg)

As you may know, debugging a Standard Library is quite different than for a Winform UserControl. Per the above article from Microsoft you debug a UserControl at Design time by setting debug properties to launch an executable 
and give the path to Devenv.exe.

I'm unable to accomplish this in either vs2019 16.10.0 or vs2019 16.11.0.preview 1.0.

