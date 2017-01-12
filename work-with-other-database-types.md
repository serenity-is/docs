# How To: Work With Other Database Types

Serenity has a dialect system for working with database types other than Sql Server.

> Dialect system is currently an experimental feature that is constantly improved. Although it will probably work, you might have some minor problems that you should report at Serenity GitHub repository.

If you need to support multiple database types, just by changing connection strings in web.config, you should be careful about not using database specific functions in expressions and avoid using reserved words.

