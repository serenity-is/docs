using FluentMigrator;

namespace CourseTutorial.Migrations.DefaultDB;

// Fixture-only: the terms chapter 02 asks the reader to add by hand.
[DefaultDB, MigrationKey(20250614_1707)]
public class FixtureSeed_20250614_1707_Terms : Migration
{
    public override void Up()
    {
        Insert.IntoTable("Terms")
            .Row(new
            {
                Name = "Fall 2026",
                StartDate = new DateTime(2026, 9, 1),
                EndDate = new DateTime(2026, 12, 31),
                IsActive = true,
                IsRegistrationOpen = true
            })
            .Row(new
            {
                Name = "Spring 2027",
                StartDate = new DateTime(2027, 2, 1),
                EndDate = new DateTime(2027, 6, 15),
                IsActive = false,
                IsRegistrationOpen = false
            });
    }

    public override void Down()
    {
    }
}
