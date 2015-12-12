# Fluent SQL

Serenity contains a set of query builders for SELECT, INSERT, UPDATE and DELETE statements.

These builders can be used with simple strings or Serenity entity (row) system.

Their output can be executed directly, through a micro-orm like Dapper (which is integrated with Serenity), or Serenity extensions.

> Serenity entity system is just a micro-orm, which is in love with SQL just like Dapper. It just provides minimum features required to query databases with intellisense, compile time checking and easy refactoring.