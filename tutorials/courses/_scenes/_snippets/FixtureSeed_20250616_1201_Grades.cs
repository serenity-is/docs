using FluentMigrator;

namespace CourseTutorial.Migrations.DefaultDB;

// Fixture-only: grades for the screens chapters 07 and 08 show. The chapters
// list no sample grades; the Calculus I rows match their screenshots, and the
// others give the quick filters something to filter out. Average is what
// GradesRow.CalculateAverage stores on save.
[DefaultDB, MigrationKey(20250616_1201)]
public class FixtureSeed_20250616_1201_Grades : Migration
{
    public override void Up()
    {
        const int John = 1, Emily = 2, Michael = 3, Sarah = 4;
        const int CS101 = 1, CS201 = 2, MATH101 = 3, PHYS101 = 4;
        const int Fall2026 = 1;
        Insert.IntoTable("Grades")
            .Row(new { StudentId = John, CourseId = CS101, TermId = Fall2026, Midterm = 85m, Final = 91m, Average = 88m })
            .Row(new { StudentId = Emily, CourseId = MATH101, TermId = Fall2026, Midterm = 78m, Final = 88m, Average = 83m })
            .Row(new { StudentId = Sarah, CourseId = CS201, TermId = Fall2026, Midterm = 92m, Final = 96m, Average = 94m })
            .Row(new { StudentId = John, CourseId = MATH101, TermId = Fall2026, Midterm = 70m, Final = 80m, Average = 75m })
            .Row(new { StudentId = Michael, CourseId = MATH101, TermId = Fall2026, Midterm = 64m, Final = 76m, Average = 70m })
            .Row(new { StudentId = Michael, CourseId = PHYS101, TermId = Fall2026, Midterm = 88m, Final = 84m, Average = 86m });
    }

    public override void Down()
    {
    }
}
