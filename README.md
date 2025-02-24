Unity Save System Package by Aaron Höhn


--- Overview ---

This Unity package provides an easy-to-use save system that allows multiple save slots. 
It includes a SaveGameManager for managing save data, SaveSystem for file operations, SaveData for handling 
saved game state, ExtensionMethods for common utilities, and a Hierarchy Icon Script to visually enhance the Unity Editor.


--- Features ---

Multiple Save Slots: Supports multiple game saves with custom names.

Inspector Integration: Save and load directly from the Unity Inspector.

Save Icons in Hierarchy: Displays an icon next to the SaveGameManager in the hierarchy.

Extension Methods: Includes useful methods for GameObject management, remapping values, and Rigidbody operations.

SaveData Class: Stores player information such as level, health, and position. 


--- Installation ---

Install via Git URL

Open Unity and go to Window > Package Manager.

Click the + button and select Add package from git URL.

Enter the following Git repository URL and click Add:

https://github.com/AaronHoehn/SaveSystem.git#upm

Install Newtonsoft JSON Package

This package requires Newtonsoft.Json for serialization.

Open Package Manager and install Newtonsoft.Json from the Unity Registry.

Ensure Required Directories Exist

The package will be placed inside the Packages/ directory.

If using the hierarchy icon feature, ensure the save icon is located at:

Packages/ah-dev.savesystem/Editor/EditorResources/SaveIcon.png

You do not need to move the package to Assets/. It will work directly from Packages/.


--- Setup ---

1. Add SaveGameManager to a GameObject

Create an empty GameObject and add the SaveGameManager component.

Assign a Player GameObject to the SaveGameManager in the Inspector.

2. Modify SaveData script
 
The SaveData script can be modified to save the desired data. The values of the data must be 

retrieved from the SaveSystemManager.

3. Using Save & Load

The Save & Load buttons are available in the Inspector when selecting a GameObject with SaveGameManager.

Enter a save name before saving to create multiple save slots.

Select a save slot from the dropdown to load a specific game state.

4. Save File Location

Saves are stored in:

C:\Users\<user>\AppData\LocalLow\ah-dev\<game_name>\

Each save file is named <save_name>.data.



--- Additional Features ---

Hierarchy Icon

Automatically displays an icon next to the SaveGameManager in the Unity hierarchy.

Ensure the icon image is placed in /SaveSystemPackage/Editor/EditorResources/SaveIcon.png.

Extension Methods

GetOrAddComponent<T>(): Adds a component if it does not exist.

HasComponent<T>(): Checks if a GameObject has a specific component.

Remap(): Remaps a float from one range to another.

ApplyForceFrom(): Copies Rigidbody velocity from another object.

ResizeList<T>(): Adjusts a list to a fixed length.


--- License ---

This package is provided for educational and personal use. Feel free to modify and extend it as needed.


--- Credits ---

This package was made as an assignment for the Depths of Unity elective by Christoph Holtmann.

Developed by Aaron Höhn.

For any issues or improvements, feel free to contribute!

23.02.2025

For any issues or improvements, feel free to contribute!
