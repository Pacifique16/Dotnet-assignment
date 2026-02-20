# Student Management System

A Windows Forms application for managing student records built with C# and SQL Server.

## 📋 Features

- **User Authentication**: Login form with admin credentials
- **Student Management**: Complete CRUD operations for student records
- **Modern UI**: Clean, professional interface with color-coded buttons
- **Data Validation**: Input validation to prevent empty submissions
- **Real-time Display**: DataGridView showing all students
- **Click-to-Edit**: Click any row to load student data for editing

## 🗄️ Database Structure

### STUDENT Table
```sql
- id (NVARCHAR(50), PRIMARY KEY)
- name (NVARCHAR(100), NOT NULL)
- address (NVARCHAR(200))
- dob (DATE)
```

## 🚀 Setup Instructions

### Step 1: Database Setup

The application uses SQL Server Express. The database is automatically created when you run the application for the first time.

**Connection String** (in App.config):
```
Data Source=PACIFIQUE\SQLEXPRESS;Initial Catalog=AppointmentDB;Integrated Security=True;TrustServerCertificate=True
```

**Note**: Update `PACIFIQUE\SQLEXPRESS` to match your SQL Server instance name.

### Step 2: Run the Application

1. Open **WindowsFormsApp1.sln** in Visual Studio
2. Press **F5** to build and run
3. Login with:
   - Username: `admin`
   - Password: `admin`

## 💻 Technology Stack

- **Framework**: .NET Framework 4.7.2
- **Language**: C# 
- **UI**: Windows Forms
- **Database**: SQL Server Express
- **Data Access**: ADO.NET (SqlClient)

## 🎨 User Interface

### Login Form
- Modern blue and white color scheme
- Side panel with system branding
- Secure password input

### Student Management Form
- Large DataGridView (left side) displaying all students
- Input fields (right side) for student details:
  - Student ID
  - Full Name
  - Address
  - Date of Birth
- Color-coded action buttons:
  - **Green** - Save new student
  - **Blue** - Update existing student
  - **Red** - Delete student

## 📁 Project Structure

```
WindowsFormsApp1/
│
├── Form1.cs                      # Login form
├── Form1.Designer.cs
├── Form1.resx
│
├── StudentFrm.cs                 # Student management form
├── StudentFrm.Designer.cs
├── StudentFrm.resx
│
├── Program.cs                    # Application entry point
├── App.config                    # Database connection string
│
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx
│   └── Settings.settings
│
├── CreateDatabase.sql            # Database creation script
├── WindowsFormsApp1.csproj
└── WindowsFormsApp1.slnx
```

## ✅ Features Implemented

- ✅ User authentication (Login form)
- ✅ Add new students
- ✅ Update student information
- ✅ Delete students with confirmation
- ✅ View all students in grid
- ✅ Input validation (prevents empty saves)
- ✅ Duplicate ID detection
- ✅ Error handling with user-friendly messages
- ✅ Modern, responsive UI design
- ✅ Click-to-edit functionality
- ✅ Auto-refresh after operations

## 🎯 How to Use

### Login
1. Run the application
2. Enter username: `admin`
3. Enter password: `admin`
4. Click "Login"

### Add a Student
1. Fill in all fields (Student ID and Full Name are required)
2. Select Date of Birth
3. Click the green "Save" button
4. Student appears in the grid

### Update a Student
1. Click on any row in the grid
2. Student data loads into the input fields
3. Modify the information
4. Click the blue "Update" button

### Delete a Student
1. Click on a row to select the student
2. Click the red "Delete" button
3. Confirm the deletion in the dialog

## 🔧 Configuration

To change the database connection:

1. Open **App.config**
2. Update the connection string:
```xml
<connectionStrings>
    <add name="conString"
         connectionString="Data Source=YOUR_SERVER\SQLEXPRESS;Initial Catalog=AppointmentDB;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient"/>
</connectionStrings>
```

## 🐛 Troubleshooting

### "Cannot connect to database"
- Ensure SQL Server Express is running
- Verify the server name in App.config matches your SQL Server instance
- Check Windows Services for SQL Server (SQLEXPRESS)

### "Student ID already exists"
- Each student must have a unique ID
- Choose a different ID or update the existing record

### Build Errors
- Ensure .NET Framework 4.7.2 is installed
- Rebuild solution (Ctrl+Shift+B)
- Check all NuGet packages are restored

## 📊 Sample Data

After first run, you can add sample students:
- ID: 26937, Name: Pacifique Harerimana, Address: Gisenyi, DOB: 2026-02-11

## 🎨 Design Features

- **Color Scheme**: Blue (#2980B9) and White
- **Font**: Segoe UI for modern look
- **Layout**: 1250x700 window, centered on screen
- **Buttons**: Flat style with hover effects
- **Grid**: Full row selection, auto-sized columns

## 📝 Default Credentials

- **Username**: admin
- **Password**: admin

**Security Note**: Change these credentials in production environments.

## 📝 License

© Copyright 2026 Pacifique Harerimana

This project is for educational purposes as part of AUCA Dot Net coursework. Feel free to fork and learn from it, but please give credit where it's due.

## ⭐ Show Your Support

**If you found this project helpful or interesting, please consider giving it a star!** 🌟

Your support motivates me to create more educational projects and helps others discover useful resources.

## 👨💻 Author

**Pacifique Harerimana**  
📧 Contact: [GitHub](https://github.com/Pacifique16)

- Institution: AUCA (Adventist University of Central Africa)
- Course: .NET Programming
- Semester: 8

## 📞 Support

For issues or questions:
- Check the troubleshooting section
- Review SQL Server connection settings
- Ensure all dependencies are installed

## 🔄 Version History

- **v1.0.0** (2024) - Initial release
  - Login functionality
  - Complete CRUD operations
  - Modern UI design
  - Input validation
  - Error handling

---

*Built with ❤️ for learning and sharing knowledge*
