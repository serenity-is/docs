# Building a Student Information System

> This tutorial is contributed by `Burcu Canur`.

## What you will build

In this tutorial we'll build a simple **Student Information System** with Serenity. By the end you'll be able to manage:

- **Departments** (e.g., Computer Science, Mathematics)
- **Terms** (academic periods, e.g., Fall 2026, Spring 2027)
- **Courses** (with departments, codes, and credits)
- **Students** (with personal info and department assignment)
- **Student enrollments** (student ↔ course relationships via a master–detail grid)
- **Teachers and course assignments**
- **Grades** (midterm/final/average for each student/course/term)

Along the way you'll learn how to:

- Define database schema using migrations
- Generate CRUD screens with Sergen
- Build a master–detail UI (students + enrollments)
- Add filtering, exporting (Excel/PDF), and friendly navigation

## Running the Application

Before you begin, start the application from your IDE or from the command line with `dotnet run`. The default login is:

- **Username:** `admin`
- **Password:** `serenity`

You'll need to be signed in to create records through the screens you build.
