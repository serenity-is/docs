# How To: Setup Cascaded Editors

You might need multi-level cascaded editors like Country => City, Course => Class Name => Subject.

Starting with Serenity 1.8.2, it's rather simple. Lookup editors has this functionality.

> For versions before 1.8.2, it was also possible, and there was some samples in Serene, but you had to define some editor classes to make it work.

Let's say we have a database with three tables, Country, City, District