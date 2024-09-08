# TODOWinApp

## Description
This Windows Forms application provides a simple and intuitive interface for managing a TODO list. It features a modern Material Design interface, task management capabilities, file operations, and an auto-update mechanism.

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Contributing](#contributing)
- [License](#license)

## Installation
1. Clone the repository:
   ```
   git clone https://github.com/yourusername/todo-list-app.git
   ```
2. Open the solution file (`TODOWinApp.sln`) in Visual Studio.
3. Restore NuGet packages if necessary.
4. Build and run the application.

### Prerequisites
- Windows operating system
- .NET Framework 4.7.2 or later
- Visual Studio 2019 or later

## Usage
1. **Adding a Task**: Type the task in the text box at the top of the window and click "Add Task" or press Enter.
2. **Marking Tasks**: Select task(s) from the list, click "Mark as", and choose "Done" or "Undone".
3. **Deleting Tasks**: Select task(s) from the list and click "Delete Task".
4. **Saving and Loading**: Use the File menu to create a new list, open an existing one, or save the current list.
5. **Updating**: The application checks for updates on startup and prompts if a new version is available.

## Features
- Modern Material Design UI
- Task management (add, mark as done/undone, delete)
- File operations (new, open, save)
- Auto-save functionality
- Auto-update mechanism

## Contributing
Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Contact
Project Link: [https://github.com/Nit8/TODOWinApp.git](https://github.com/Nit8/TODOWinApp.git)

## Acknowledgements
- [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin)
- [OpenFileDialog](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog)
- [SaveFileDialog](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.savefiledialog)

---

# For Developers

## Project Structure
- `Form1.cs`: Main form and application logic
- `Form1.Designer.cs`: UI component definitions
- `Program.cs`: Application entry point

## Key Components
1. **Form1**: Main form inheriting from `MaterialForm`.
2. **MaterialSkinManager**: Manages Material Design theme.
3. **ListBox**: Displays tasks.
4. **MaterialTextBox**: Input for new tasks.
5. **MaterialButtons**: For various actions.

## Key Methods
- `buttonAdd_Click`: Adds new tasks.
- `MarkTasks`: Marks tasks as done/undone.
- `buttonDelete_Click`: Deletes tasks.
- `LoadTodoList`: Loads tasks from file.
- `SaveTodoList`: Saves tasks to file.
- `CheckForUpdates`: Checks for updates.

## File Handling
- Auto-save to `%UserProfile%\Documents\TodoList.txt`.
- Manual save/load to custom locations.

## Update Mechanism
- Fetches version from Google Drive link.
- Compares with current version.
- Prompts for download if newer version available.

## Error Handling
- Basic error handling for file operations and updates.
- User notifications via message boxes.

## Future Improvements
- Implement task categories/priorities.
- Add due dates for tasks.
- Implement dark theme.
- Add user settings.
