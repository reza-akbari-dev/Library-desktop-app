🛠 How to Run the Project
After downloading the source code, follow these steps to set up and run the application:

✅ Step 1: Prepare the Database
Open Package Manager Console in Visual Studio and run:

powershell
Copy
Edit
Add-Migration InitialCreate
Update-Database
This will create the SQL Server database schema.

✅ Step 2: Bypass Login for Development
To skip the login screen and run the application with a fake admin user:

Modify Program.cs:

Comment out the original code.

Uncomment the provided development code that sets a fake admin user.

✅ This allows you to run the application without login.

Modify MainForm.cs:

In MainForm_Shown, comment the login form line:

csharp
Copy
Edit
new FormLogin().ShowDialog();
Then uncomment the version that skips login (already included and marked).

✅ This shows the main form directly.

Run the Project.
Now you can access the application without authentication.

Inside the application:

Go to Person Management and create a person.

Then create an admin user with that person and set a username and password.

Assign the user to the Administrator role.

Stop debugging once the admin is created.

❗ Revert changes to Program.cs and MainForm.cs:

Restore the login form and remove the fake user.

This makes the application require real authentication again.

✅ Step 3: Use the Application
Now run the app normally. You can:

Define people with contact info and photos.

Use people records to define:

Users

Members

Writers

Explore borrowing system, book management, and more!

🙏 Thank You!
Thanks for checking out the project!
Hope you enjoy using the application 🙌
