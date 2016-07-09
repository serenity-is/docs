# Creating Lookup Tables

Let's start by creating lookup tables we'll need.

Here is a list of these tables:

* Meeting Types (Board Meeting, Weekly Analytics, SCRUM Meeting, Annual Meeting, so on...)
* Locations (where meeting will be held, room numbers, address etc.)
* Agenda Types (what subject(s) an agenda is about, might be multiple)
* Units (which unit is organizing the meeting)
* Contacts (people which would attend meetings, reporters, managers etc.)

We'll use database schema *met* for tables.

Create a new migration under, *Modules/Common/Migrations/DefaultDB* with name *DefaultDB_20160709_232400_MeetingLookups*:

```cs
using FluentMigrator;

namespace MeetingManagement.Migrations.DefaultDB
{
    [Migration(20160709232400)]
    public class DefaultDB_20160709_232400_MeetingLookups 
        : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("AgendaTypes").InSchema("met")
                .WithColumn("AgendaTypeId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();

            Create.Table("Contacts").InSchema("met")
                .WithColumn("ContactId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(30).Nullable()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("Email").AsString(100).NotNullable();

            Create.Table("Locations").InSchema("met")
                .WithColumn("LocationId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Address").AsString(300).Nullable()
                .WithColumn("Latitude").AsDouble()
                .WithColumn("Longitude").AsDouble();

            Create.Table("MeetingTypes").InSchema("met")
                .WithColumn("MeetingTypeId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();

            Create.Table("Units").InSchema("met")
                .WithColumn("UnitId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();
        }
    }
}
```