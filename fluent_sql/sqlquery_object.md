# SqlQuery Object

[**namespace**: *Serenity.Data*] - [**assembly**: *Serenity.Data*]

SqlQuery is an object to compose dynamic SQL SELECT queries through a fluent interface.

# Advantages

SqlQuery offers some advantages over hand crafted SQL:

* Using IntelliSense feature of Visual Studio while composing SQL

* Fluent interface with minimal overhead

* Reduced syntax errors as the query is checked compile time, not execution time.

* Clauses like Select, Where, Order By can be used in any order. They are placed at correct positions when converting the query to string. Similary, such clauses can be used more than once and they are merged during string conversion. So you can conditionally build SQL depending on input parameters.

* No need to mess up with parameters and parameter names. All values used are converted to auto named parameters. You can also use manually named parameters if required.

* It can generate a special query to perform paging on server types that doesn't support it natively (e.g. SQL Server 2000)

* With the dialect system, query can be targeted at specific server type and version.

* If it is used along with Serenity entities (it can also be used with micro ORMs like Dapper), helps to load query results from a data reader with zero reflection. Also it does left/right joins automatically.



