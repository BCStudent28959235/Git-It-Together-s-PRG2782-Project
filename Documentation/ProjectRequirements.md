# Project PRG2782
## Create a Version-Controlled Student Management System using Windows Forms and GitHub

### Task
Develop a C# Windows Forms application that manages student records using text files and incorporates Git version control. The application should include the following features:

1. **Add New Student**: 
   Through a form interface, allow the user to input student details (Student ID, Name, Age, and Course) and save these details to a file called `students.txt`.
   
2. **View All Students**: 
   Display all student records from `students.txt` in a DataGridView.
   
3. **Update Student Information**: 
   Enable the user to search for a student by ID, update their details through a form, and save changes.
   
4. **Delete a Student**: 
   Allow the user to select a student from the DataGridView and delete the corresponding record from the file.
   
5. **Generate a Summary Report**: 
   Calculate the total number of students and the average age, and display the results on the form, saving this summary to a file named `summary.txt`.
   
6. **Version Control with Git**:
   - Initialize a Git repository for the project.
   - Stage and commit changes after each major modification (add, update, delete, or report generation).
   - Push the repository to GitHub.

### Requirements
1. **Create a C# Windows Forms Application**:
   - The application should be designed with an interface that allows users to interact with the Student Management System, including input fields and action buttons.

2. **Implement Core Functionalities**:
   - **Add New Student**:
     - Use input fields (TextBox controls) for Student ID, Name, Age, and Course.
     - Save new student details to a file called `students.txt`.
   - **View All Students**:
     - Display the list of students in a DataGridView control on the form.
     - Load student data from `students.txt` and populate the DataGridView.
   - **Update Student Information**:
     - Allow selection of a student record from the DataGridView, and populate the input fields for editing.
     - Save the updated information back to `students.txt`.
   - **Delete a Student**:
     - Enable the user to delete a selected student from the DataGridView.
     - Remove the corresponding record from `students.txt`.
   - **Generate a Summary Report**:
     - Calculate and display the total number of students and average age on the form.
     - Save these details in a file called `summary.txt`.

3. **Implement Version Control Using Git**:
   - **Initialize a Git Repository**:
     - In the project directory, initialize a Git repository.
   - **Commit Changes**:
     - After implementing each major feature (Add, Update, Delete, Generate Report), stage and commit the changes.
     - Ensure clear, meaningful commit messages that describe each change.

4. **Integrate with GitHub**:
   - **Create a GitHub Repository**:
     - Set up a new repository on GitHub and push your local commits to this remote repository.
   - **Push Changes**:
     - After completing each task, push all commits to the GitHub repository.

5. **Error Handling and Documentation**:
   - Implement error handling for file I/O operations and input validation to ensure a smooth user experience.
   - Include inline comments explaining key parts of the code for better readability and maintainability.

### Rubric

| Criteria                          | Description                                                                                               | Marks |
|-----------------------------------|-----------------------------------------------------------------------------------------------------------|-------|
| 1. Adding New Student             | The form correctly accepts input for Student ID, Name, Age, and Course.                                  | 15    |
|                                   | Data validation for fields (e.g., age is a number, no empty fields).                                     | 5     |
|                                   | Successfully appends the new student record to `students.txt`.                                           | 5     |
|                                   | Clear error messages are shown if input is invalid (e.g., empty fields, non-numeric age).                | 2     |
| 2. Viewing All Students           | Data is successfully read from `students.txt`.                                                            | 15    |
|                                   | The DataGridView is correctly populated with the data in a readable, formatted manner.                    | 5     |
|                                   | The view is refreshed correctly when the file is updated (e.g., after adding or deleting a student).      | 5     |
| 3. Updating Student Info          | The selected student record is loaded into the form fields for editing.                                   | 5     |
|                                   | Updated information is validated and saved back to `students.txt`.                                       | 5     |
|                                   | The DataGridView displays updated information without errors or data duplication.                         | 5     |
| 4. Deleting a Student            | Allows selection of a student from DataGridView and deletion with confirmation prompt.                   | 5     |
|                                   | Removes the corresponding record from `students.txt`.                                                    | 5     |
|                                   | The DataGridView is refreshed after deletion, reflecting the changes.                                    | 5     |
| 5. Generating Summary             | Calculates total number of students and average age accurately.                                          | 10    |
|                                   | Displays the results on the form in designated text boxes/labels.                                        | 3     |
|                                   | Saves the summary to `summary.txt` with correct formatting.                                              | 3     |
| 6. Version Control with Git       | Initializes a Git repository and commits the initial project files.                                      | 15    |
|                                   | Properly commits changes with meaningful commit messages for each major feature (add, update, delete, report). | 6   |
|                                   | Maintains a clear commit history, with no redundant or unnecessary commits.                               | 3     |
|                                   | Shows evidence of incremental commits during the development process.                                     | 3     |
| 7. GitHub Integration             | Creates a GitHub repository and pushes the project files to it.                                         | 15    |
|                                   | Links the local Git repository with the GitHub remote and pushes all commits.                            | 5     |
|                                   | Ensures the GitHub repository is public or shared with the lecturer.                                     | 5     |
| 8. Error Handling and Documentation | Provides error handling for file operations (e.g., missing files, permission errors).                    | 10    |
|                                   | Provides input validation and informative error messages for user actions.                                | 3     |
|                                   | Includes inline comments in the code, explaining the functionality of each section and purpose of major functions. | 3 |
| **Total**                         |                                                                                                           | **100** |

### Presentation Requirements

**Group Setup**
- **Group Size**: Groups of 3-4 students.
- **Time Limit**: Each group will have 10-15 minutes to present their project, with an additional 5 minutes for questions from the assessors.
- **Order of Presentations**: Groups will present online in front of a panel of assessors, but not their own lecturer. This is to ensure impartial evaluation.

**Presentation Structure**
1. **Introduction (2-3 minutes)**:
   - Briefly introduce the project and its purpose.
   - Outline the technologies used (C#, Windows Forms, Git, GitHub).

2. **Project Demonstration (5-7 minutes)**:
   - Show the interface and demonstrate the core functionalities:
     - Adding a student.
     - Viewing all students.
     - Updating a student record.
     - Deleting a student.
     - Generating a summary report.
   - Highlight how they used Git for version control, explaining key commits and how changes were tracked.
   - Show the GitHub repository and explain how they collaborated as a team (if applicable).

3. **Question and Answer Session (5 minutes)**:
   - The assessors will ask questions related to:
     - The code and implementation choices.
     - The challenges they encountered and how they solved them.
     - How they used Git and GitHub for collaboration and version control.
   - Groups should be prepared to explain their code, especially around file handling and error handling.

### Assessment
The presentation is assessed based on:
- **Understanding of the Project**: How well the students understand their own code and the functionality they implemented.
- **Demonstration of Features**: Clear demonstration of each feature listed in the requirements.
- **Use of Git and GitHub**: Evidence of effective use of Git version control, including frequent commits and pushing the project to GitHub.
- **Responsiveness to Questions**: How well the group responds to questions, demonstrating their knowledge and involvement in the project.
