# Simple .NET Web API - CRUD Without Database

This is a basic .NET Web API project demonstrating full **CRUD (Create, Read, Update, Delete)** operations using an **in-memory list** instead of a database.

> Author: **Muhammad Nouman**

---

## 📌 Project Overview

This project showcases how to:

- Create a RESTful API using ASP.NET Core
- Implement full CRUD functionality for a `Student` model
- Store and manage data in a static `List<Student>` (in-memory storage)
- Use services and interfaces to keep the code clean and extensible

---

## 💡 Features

- ✅ Add new student (no duplicates by email)
- ✅ Get all students
- ✅ Get a student by email
- ✅ Update student details
- ✅ Delete student by email
- ❌ No database used (data resets when app restarts)

---

## 🔧 Technologies Used

- ASP.NET Core Web API
- C#
- In-memory static list (no database)
- REST architecture
- Visual Studio / VS Code

---

## 📁 Project Structure

Simple_webAPi/
│
├── Models/
│ └── Student.cs
│
├── Interface/
│ └── IStudent.cs
│
├── Services/
│ └── StudentService.cs
│
├── Controllers/
│ └── StudentController.cs
│
├── Program.cs
├── Startup.cs (if applicable)
└── README.md


## 🚀 How to Run

1. **Clone the repository**:

```bash
git clone https://github.com/noumanatgsystem/dotnet-crud-no-db.git
cd dotnet-crud-no-db
