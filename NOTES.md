Organizing More Code Files
If we want to organize more code files (UI and business logic), this is a good way to go:

All business logic files go in the Models/ directory.
Create a new subdirectory within the ProjectName directory called UserInterfaceModels (or something similar) and add all additional user interface files within that subdirectory.
It's convention for Program.cs, the entry point to our application, to remain in the root of the production directory ProjectName.