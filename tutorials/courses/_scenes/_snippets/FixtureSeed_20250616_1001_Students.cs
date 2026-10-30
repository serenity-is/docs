using FluentMigrator;

namespace CourseTutorial.Migrations.DefaultDB;

// Fixture-only: the students chapter 04 asks the reader to add by hand.
[DefaultDB, MigrationKey(20250616_1001)]
public class FixtureSeed_20250616_1001_Students : Migration
{
    public override void Up()
    {
        const int ComputerScience = 1, Mathematics = 2, Physics = 3;
        Insert.IntoTable("Students")
            .Row(new { FirstName = "John", LastName = "Smith", FullName = "John Smith", BirthDate = new DateTime(2004, 3, 15), DepartmentId = ComputerScience })
            .Row(new { FirstName = "Emily", LastName = "Johnson", FullName = "Emily Johnson", BirthDate = new DateTime(2003, 7, 22), DepartmentId = Mathematics })
            .Row(new { FirstName = "Michael", LastName = "Brown", FullName = "Michael Brown", BirthDate = new DateTime(2004, 11, 5), DepartmentId = Physics })
            .Row(new { FirstName = "Sarah", LastName = "Davis", FullName = "Sarah Davis", BirthDate = new DateTime(2003, 5, 18), DepartmentId = ComputerScience });
    }

    public override void Down()
    {
    }
}
