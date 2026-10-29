using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20221122_1151)]
public class DefaultDB_20221122_1151_PersonMovieImages : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Person")
            .AddColumn("PrimaryImage").AsString(100).Nullable()
            .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();

        Alter.Table("Movie")
            .AddColumn("PrimaryImage").AsString(100).Nullable()
            .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();
    }
}
