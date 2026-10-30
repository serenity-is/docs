using FluentMigrator;

namespace CourseTutorial.Migrations.DefaultDB;

// Fixture-only: the departments chapter 01 asks the reader to add by hand.
[DefaultDB, MigrationKey(20250614_1701)]
public class FixtureSeed_20250614_1701_Department : Migration
{
    public override void Up()
    {
        Insert.IntoTable("Department")
            .Row(new { Name = "Computer Science" })
            .Row(new { Name = "Mathematics" })
            .Row(new { Name = "Physics" });
    }

    public override void Down()
    {
    }
}
