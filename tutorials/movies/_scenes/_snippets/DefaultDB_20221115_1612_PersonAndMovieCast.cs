using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20221115_1612)]
public class DefaultDB_20221115_1612_PersonAndMovieCast : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Person")
            .WithColumn("PersonId").AsInt32().IdentityKey(this)
            .WithColumn("FirstName").AsString(50).NotNullable()
            .WithColumn("LastName").AsString(50).NotNullable()
            .WithColumn("BirthDate").AsDateTime().Nullable()
            .WithColumn("BirthPlace").AsString(100).Nullable()
            .WithColumn("Gender").AsInt32().Nullable()
            .WithColumn("Height").AsInt32().Nullable();

        Create.Table("MovieCast")
            .WithColumn("MovieCastId").AsInt32().IdentityKey(this)
            .WithColumn("MovieId").AsInt32().NotNullable()
                .ForeignKey("FK_MovieCast_MovieId", "Movie", "MovieId")
            .WithColumn("PersonId").AsInt32().NotNullable()
                .ForeignKey("FK_MovieCast_PersonId", "Person", "PersonId")
            .WithColumn("Character").AsString(50).Nullable();

        Insert.IntoTable("Person")
            .Row(new
            {
                FirstName = "Keanu",
                LastName = "Reeves",
                BirthDate = new DateTime(1964, 9, 2),
                BirthPlace = "Beirut, Lebanon",
                Gender = 1,
                Height = 186
            })
            .Row(new
            {
                FirstName = "Carrie-Anne",
                LastName = "Moss",
                BirthDate = new DateTime(1967, 8, 21),
                BirthPlace = "Burnaby, BC, Canada",
                Gender = 2,
                Height = 174
            })
            .Row(new
            {
                FirstName = "Laurence John",
                LastName = "Fishburne",
                BirthDate = new DateTime(1961, 7, 30),
                BirthPlace = "Augusta, Georgia, US",
                Gender = 1,
                Height = 184
            });
    }
}
