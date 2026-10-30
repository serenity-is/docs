using FluentMigrator;

namespace CourseTutorial.Migrations.DefaultDB;

// Fixture-only: the courses chapter 03 asks the reader to add by hand.
// Department ids follow the order chapter 01 adds them in.
[DefaultDB, MigrationKey(20250615_1221)]
public class FixtureSeed_20250615_1221_Courses : Migration
{
    public override void Up()
    {
        const int ComputerScience = 1, Mathematics = 2, Physics = 3;
        Insert.IntoTable("Courses")
            .Row(new { DepartmentId = ComputerScience, Name = "Introduction to Programming", Code = "CS101", Credit = 4 })
            .Row(new { DepartmentId = ComputerScience, Name = "Data Structures", Code = "CS201", Credit = 4 })
            .Row(new { DepartmentId = Mathematics, Name = "Calculus I", Code = "MATH101", Credit = 3 })
            .Row(new { DepartmentId = Physics, Name = "Physics I", Code = "PHYS101", Credit = 3 });
    }

    public override void Down()
    {
    }
}
