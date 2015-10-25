# The Cast and Characters They Played

If we wanted to keep a record of actors and the roles they played like this:

*Actor/Actress*|*Character *
--|--
Keanu Reeves|Neo       
Laurence Fishburne|Morpheus
Carrie-Anne Moss|Trinity

We need a table MovieCast with columns like:

*MovieCastId*|*MovieId*|*PersonId*|*Character*
--|--|--
...|...|...|...
11|2 (Matrix)|77 (Keanu Reeves)|Neo
12|2 (Matrix)|99 (Laurence Fisburne)|Morpheus
13|2 (Matrix)|30 (Carrie-Anne Moss)|Trinitity
...|...|...|...

It's clear that we also need a Person table as we'll keep actors/actresses by their ID.

> It's better to call it *Person* as actors/actresses might become directors, scenario writers and such later.


### Creating Person and MovieCast Tables

Now its time to create a migration with two tables:

MovieTutorial.Web/Modules/Common/Migrations/DefaultDB/DefaultDB_20151025_170200_PersonAndMovieCast.cs:

```cs
using FluentMigrator;
using System;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20151025170200)]
    public class DefaultDB_20151025_170200_PersonAndMovieCast : Migration
    {
        public override void Up()
        {
            Create.Table("Person").InSchema("mov")
                .WithColumn("PersonId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Firstname").AsString(50).NotNullable()
                .WithColumn("Lastname").AsString(50).NotNullable()
                .WithColumn("BirthDate").AsDateTime().Nullable()
                .WithColumn("BirthPlace").AsString(100).Nullable()
                .WithColumn("Gender").AsInt32().Nullable()
                .WithColumn("Height").AsInt32().Nullable();

            Create.Table("MovieCast").InSchema("mov")
                .WithColumn("MovieCastId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("MovieId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_MovieId", "mov", "Movie", "MovieId")
                .WithColumn("PersonId").AsInt32().NotNullable()
                    .ForeignKey("FK_MovieCast_PersonId", "mov", "Person", "PersonId")
                .WithColumn("Character").AsString(50).Nullable();
        }
                
        public override void Down()
        {
        }
    }
}
```


### Generating Code For Person Table

First create UI for Person table:

