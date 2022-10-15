# Serenity.Net.Data assembly

## Serenity namespace

| signature | name | description |
| --: | --- | --- |
| interface  | [IChainable](Serenity/IChainable.md) | Interface for chainable objects, e.g. with functions returning themselves. |
| interface  | [ICriteria](Serenity/ICriteria.md) | Shared criteria interface |
| interface  | [ICustomValidator](Serenity/ICustomValidator.md) | Custom validator abstraction |
| interface  | [IValidationContext](Serenity/IValidationContext.md) | Validation context abstraction |
| static class  | [MethodChainingExtensions](Serenity/MethodChainingExtensions.md) | Contains method chaining extensions |

## Serenity.Data namespace

| signature | name | description |
| --: | --- | --- |
| class  | [Alias](Serenity.Data/Alias.md) | Used to define aliases like (T0). |
| static class  | [AliasExtensions](Serenity.Data/AliasExtensions.md) | Contains extension methods for Alias objects |
| abstract class  | [BaseCriteria](Serenity.Data/BaseCriteria.md) | Base criteria object type |
| abstract class  | [BaseCriteriaVisitor](Serenity.Data/BaseCriteriaVisitor.md) | A visitor implementation for BaseCriteria object trees. |
| class  | [BinaryCriteria](Serenity.Data/BinaryCriteria.md) | Binary criteria object, which has two operands and a operator. |
| static class  | [BracketLocator](Serenity.Data/BracketLocator.md) | Contains helper methods for locating / replacing brackets in an SQL expression |
| static class  | [ConnectionExtensions](Serenity.Data/ConnectionExtensions.md) | Contains DB connection related extensions |
| class  | [ConnectionKeyAttribute](Serenity.Data/ConnectionKeyAttribute.md) | Determines the connection key used for a class |
| class  | [ConnectionStringEntry](Serenity.Data/ConnectionStringEntry.md) | Connection string setting |
| class  | [ConnectionStringInfo](Serenity.Data/ConnectionStringInfo.md) | Contains a connection string, its key and provider name. |
| class  | [ConnectionStringOptions](Serenity.Data/ConnectionStringOptions.md) | Connection string options |
| static class  | [ConnectionStringsExtensions](Serenity.Data/ConnectionStringsExtensions.md) | Contains connection string extensions |
| class  | [ConstantCriteria](Serenity.Data/ConstantCriteria.md) | A constant criteria object, which only contains a value expression that would be converted to its string representation in SQL, not a parameterized value. |
| class  | [Criteria](Serenity.Data/Criteria.md) | An object that is used to create criterias by employing operator overloading features of C# language, instead of using string based criterias. |
| enum  | [CriteriaOperator](Serenity.Data/CriteriaOperator.md) | Set of criteria operator types |
| class  | [CrossApply](Serenity.Data/CrossApply.md) | CROSS APPLY type of join |
| class  | [DataAuditLogAttribute](Serenity.Data/DataAuditLogAttribute.md) | Indicates that the entity should be audit logged. This feature is only available in premium app. |
| class  | [DatabaseAliasAttribute](Serenity.Data/DatabaseAliasAttribute.md) | Determines database alias, used for unit test database contexts. |
| class  | [DatabaseCaretReferences](Serenity.Data/DatabaseCaretReferences.md) | Helper class for replacing database caret references in format [^ConnectionKey] in SQL expressions. |
| static class  | [DataReaderExtensions](Serenity.Data/DataReaderExtensions.md) | Extension methods for IDataReader objects. |
| class  | [DateTimeKindAttribute](Serenity.Data/DateTimeKindAttribute.md) | Determines Time kind for a DateTime field. |
| class  | [DefaultConnectionStrings](Serenity.Data/DefaultConnectionStrings.md) | Default connection string source |
| class  | [DefaultSqlConnections](Serenity.Data/DefaultSqlConnections.md) | Default connection factory |
| class  | [DefaultSqlDialectMapper](Serenity.Data/DefaultSqlDialectMapper.md) | Sql Dialect mapper |
| class  | [DeltaLister&lt;TItem&gt;](Serenity.Data/DeltaLister-1.md) | Helper class to find differences between to lists for updating |
| [Flags] enum  | [DeltaOptions](Serenity.Data/DeltaOptions.md) | Delta options flags |
| class  | [EmitFieldTypeAttribute](Serenity.Data/EmitFieldTypeAttribute.md) | Declares that the field generated for this template property should be of type specified. |
| enum  | [ExpectedRows](Serenity.Data/ExpectedRows.md) | Expected number of rows enumeration for SQL Update / Delete operation. This enumeration is used to avoid updating/deleting multiple records by mistake when forgot to add a WHERE statement. |
| [Flags] enum  | [FieldFlags](Serenity.Data/FieldFlags.md) | Flags that determine basic properties of a field |
| static class  | [FilterableQueryExtensions](Serenity.Data/FilterableQueryExtensions.md) | Extensions for objects implementing IDbWhere interface. |
| class  | [FirebirdDialect](Serenity.Data/FirebirdDialect.md) | Firebird dialect |
| interface  | [IAlias](Serenity.Data/IAlias.md) | Interface for table aliases. |
| interface  | [IConnectionProfiler](Serenity.Data/IConnectionProfiler.md) | An interface used to abstract profilers like Mini Profiler. |
| interface  | [IConnectionString](Serenity.Data/IConnectionString.md) | Contains a connection string, its key and provider name. |
| interface  | [IConnectionStrings](Serenity.Data/IConnectionStrings.md) | Abstraction to access connection strings along with dialect and provider information |
| class  | [IdPropertyAttribute](Serenity.Data/IdPropertyAttribute.md) | Determines that the attached property is the ID field of the table. |
| interface  | [IField](Serenity.Data/IField.md) | Field object abstraction for SQL query |
| interface  | [IFilterableQuery](Serenity.Data/IFilterableQuery.md) | Interface for query classes (e.g. SqlSelect, SqlUpdate) having a where method to filter records |
| interface  | [IGetExpressionByName](Serenity.Data/IGetExpressionByName.md) | Interface for query classes (e.g. SqlQuery) that can return expression given column name |
| interface  | [IHasActualConnection](Serenity.Data/IHasActualConnection.md) | Interfaces for types that has an ActualConnection property of type IDbConnection |
| interface  | [IHasActualTransaction](Serenity.Data/IHasActualTransaction.md) | Interfaces for types that has an ActualTransaction property of type IDbTransaction |
| interface  | [IHasCommandTimeout](Serenity.Data/IHasCommandTimeout.md) | Interfaces for types that has an CommandTimeout property that determines the default command timeout for that connection |
| interface  | [IHasCurrentTransaction](Serenity.Data/IHasCurrentTransaction.md) | Interfaces for types that has a CurrentTransaction property of type IDbTransaction |
| interface  | [IHasDialect](Serenity.Data/IHasDialect.md) | Interfaces for types that has a Dialect property of type ISqlDialect |
| interface  | [IHasOpenedOnce](Serenity.Data/IHasOpenedOnce.md) | Interfaces for types that has an OpenedOnce property that determines if the connection has opened at least once |
| interface  | [IHaveJoins](Serenity.Data/IHaveJoins.md) | Interface for row type that provides a list of its joins |
| interface  | [IMustRemoveT0](Serenity.Data/IMustRemoveT0.md) | Obsolete interface |
| class  | [InnerJoin](Serenity.Data/InnerJoin.md) | INNER JOIN type |
| class  | [InstanceNameAttribute](Serenity.Data/InstanceNameAttribute.md) | Determines non-plural name for an entity. |
| interface  | [IQueryWithParams](Serenity.Data/IQueryWithParams.md) | Interface for objects setting parameters by PARAM method (like SqlInsert, SqlUpdate, SqlDelete...) |
| interface  | [ISetFieldByStatement](Serenity.Data/ISetFieldByStatement.md) | Interface for objects setting values by SetTo method (like SqlInsert, SqlUpdate...) |
| interface  | [ISqlConnections](Serenity.Data/ISqlConnections.md) | An interface used to abstract sql connections |
| interface  | [ISqlDialect](Serenity.Data/ISqlDialect.md) | Abstraction for SQL dialect, e.g. syntax for different SQL server types and connection settings. |
| interface  | [ISqlDialectMapper](Serenity.Data/ISqlDialectMapper.md) | The sql dialect mapper |
| interface  | [ISqlQuery](Serenity.Data/ISqlQuery.md) | SqlQuery interface. |
| interface  | [ISqlQueryExtensible](Serenity.Data/ISqlQueryExtensible.md) | Extensible SQL query interface. Used to abstract Serenity.Data.Row dependency from SqlQuery. |
| interface  | [ISqlQueryToString](Serenity.Data/ISqlQueryToString.md) | SqlQuery interface. |
| interface  | [IUnitOfWork](Serenity.Data/IUnitOfWork.md) | An interface to implement unit of work pattern, e.g. a transaction. |
| abstract class  | [Join](Serenity.Data/Join.md) | Corresponds to an SQL JOIN (INNER, OUTER, CROSS etc.) |
| class  | [JoinAliasLocator](Serenity.Data/JoinAliasLocator.md) | Locates alias references in an SQL expression |
| class  | [JsonCriteriaConverter](Serenity.Data/JsonCriteriaConverter.md) | Serialize/deserialize a BaseCriteria object |
| class  | [JsonSafeCriteriaConverter](Serenity.Data/JsonSafeCriteriaConverter.md) | Serialize/deserialize a BaseCriteria object and checks for safety of criteria expressions. |
| class  | [LeftJoin](Serenity.Data/LeftJoin.md) | LEFT JOIN type |
| class  | [MySqlDialect](Serenity.Data/MySqlDialect.md) | MySql dialect. |
| class  | [NamePropertyAttribute](Serenity.Data/NamePropertyAttribute.md) | Determines that the attached property is the name field of the table. |
| struct  | [OldNewPair&lt;TItem&gt;](Serenity.Data/OldNewPair-1.md) | A pair of old new values |
| class  | [Oracle12cDialect](Serenity.Data/Oracle12cDialect.md) | Oracle12cDialect which uses OFFSET FETCH instead of ROWNUM |
| class  | [OracleDialect](Serenity.Data/OracleDialect.md) | Oracle dialect |
| class  | [OuterApply](Serenity.Data/OuterApply.md) | OUTER APPLY join type |
| class  | [ParamCriteria](Serenity.Data/ParamCriteria.md) | A criteria object containing a parameter name |
| struct  | [Parameter](Serenity.Data/Parameter.md) | Parameter struct |
| static class  | [ParamPrefixReplacer](Serenity.Data/ParamPrefixReplacer.md) | Param prefix replacer |
| class  | [PostgresDialect](Serenity.Data/PostgresDialect.md) | Postgres dialect |
| class  | [QueryWithParams](Serenity.Data/QueryWithParams.md) | Base class for queries with params like SqlQuery, SqlUpdate, SqlInsert |
| static class  | [QueryWithParamsExtensions](Serenity.Data/QueryWithParamsExtensions.md) | Extension methods for classes implementing IDbWhereParam interface. |
| delegate  | [ReaderCallBack](Serenity.Data/ReaderCallBack.md) | A delegate that gets a data reader parameter |
| class  | [RightJoin](Serenity.Data/RightJoin.md) | RIGHT JOIN type |
| class  | [SafeCriteriaValidator](Serenity.Data/SafeCriteriaValidator.md) | Validates a criteria for allowed field names, operators and SQL injection safety |
| enum  | [SelectLevel](Serenity.Data/SelectLevel.md) | Select level enumeration |
| enum  | [ServerType](Serenity.Data/ServerType.md) | Contains server type names for common dialects |
| static class  | [SetFieldByStatementExtensions](Serenity.Data/SetFieldByStatementExtensions.md) | Extension methods for classes implementing IDbSet interface |
| static class  | [Sql](Serenity.Data/Sql.md) | Contains SQL expression generation helpers |
| class  | [SqlCommandDumper](Serenity.Data/SqlCommandDumper.md) | http://stackoverflow.com/questions/265192/get-the-generated-sql-statement-from-a-sqlcommand-object (answer by Mitch) |
| static class  | [SqlConversions](Serenity.Data/SqlConversions.md) | Value to SQL constant expression conversions |
| class  | [SqlDebugDumper](Serenity.Data/SqlDebugDumper.md) | Formats a debug version of a query, replacing parameters with SQL constants, fixing brackets, database caret references etc. |
| class  | [SqlDelete](Serenity.Data/SqlDelete.md) | Class to generate queries of form `DELETE FROM tablename WHERE [conditions]`. |
| static class  | [SqlHelper](Serenity.Data/SqlHelper.md) | Contains static SQL related helper functions and extensions. |
| class  | [SqlInsert](Serenity.Data/SqlInsert.md) | Class to generate queries of the form `INSERT INTO tablename (field1, field2..fieldN) VALUES (value1, value2..valueN)` |
| class  | [SqliteDialect](Serenity.Data/SqliteDialect.md) | Sqlite dialect. |
| static class  | [SqlMapper](Serenity.Data/SqlMapper.md) | Dapper wrapper |
| class  | [SqlQuery](Serenity.Data/SqlQuery.md) | SQL query string builder |
| class  | [SqlServer2000Dialect](Serenity.Data/SqlServer2000Dialect.md) | SqlServer 2000 dialect. |
| class  | [SqlServer2005Dialect](Serenity.Data/SqlServer2005Dialect.md) | Sql Server 2005 dialect. |
| class  | [SqlServer2008Dialect](Serenity.Data/SqlServer2008Dialect.md) | Sql Server 2008 dialect. |
| class  | [SqlServer2012Dialect](Serenity.Data/SqlServer2012Dialect.md) | Sql Server 2012 dialect. |
| static class  | [SqlSettings](Serenity.Data/SqlSettings.md) | Global SQL settings |
| static class  | [SqlSyntax](Serenity.Data/SqlSyntax.md) | Contains SQL syntax helpers. |
| enum  | [SqlUnionType](Serenity.Data/SqlUnionType.md) | Type of SQL UNIONs. |
| class  | [SqlUpdate](Serenity.Data/SqlUpdate.md) | Generates queries of the form `UPDATE tablename SET field1 = value1, field2 = value2 ... fieldN = valueN WHERE [filter]`. |
| static class  | [T0ReferenceRemover](Serenity.Data/T0ReferenceRemover.md) | Removes T0. references in SQL expression |
| class  | [TwoLevelCachedAttribute](Serenity.Data/TwoLevelCachedAttribute.md) | This attribute marks a row so that when it is Inserted/Updated/Deleted through repository, its related cache, if any should be cleared. It doesn't turn on/off caching. A sample of related cached item to a row, might be its lookup if any. |
| class  | [UnaryCriteria](Serenity.Data/UnaryCriteria.md) | Unary criteria with one operand and operator |
| class  | [UnitOfWork](Serenity.Data/UnitOfWork.md) | Unit of work implementation. |
| class  | [ValueCriteria](Serenity.Data/ValueCriteria.md) | Criteria object with one value |
| class  | [WrappedConnection](Serenity.Data/WrappedConnection.md) | Wraps a connection to add current transaction and dialect support. |
| class  | [WrappedTransaction](Serenity.Data/WrappedTransaction.md) | Wraps a transaction instance to add current transaction support for the wrapped connection. |

## Serenity.Data.Mapping namespace

| signature | name | description |
| --: | --- | --- |
| class  | [AutoIncrementAttribute](Serenity.Data.Mapping/AutoIncrementAttribute.md) | Marks the field as auto increment, e.g. generated on insert in SQL side |
| class  | [ColumnAttribute](Serenity.Data.Mapping/ColumnAttribute.md) | Explicitly specifies the database column name for property. Use this attribute if matching column name in database is different than the property name. |
| class  | [ExpressionAttribute](Serenity.Data.Mapping/ExpressionAttribute.md) | Specifies SQL expression this property corresponds to. You may use brackets ([]) to escape identifiers. Brackets will be converted to database specific quotes. |
| class  | [ForeignKeyAttribute](Serenity.Data.Mapping/ForeignKeyAttribute.md) | Specifies that this property is a foreign key to another field in a primary key table. There is no need for foreign key to exist in database actually. It is not checked. This is mostly used for joins. |
| class  | [IdentityAttribute](Serenity.Data.Mapping/IdentityAttribute.md) | Marks the field as Identity, a combination of PrimaryKey, AutoIncrement and NotNull flags. |
| class  | [InnerJoinAttribute](Serenity.Data.Mapping/InnerJoinAttribute.md) | INNER JOIN type |
| interface  | [ISqlJoin](Serenity.Data.Mapping/ISqlJoin.md) | Interface for SQL join types |
| class  | [LeftJoinAttribute](Serenity.Data.Mapping/LeftJoinAttribute.md) | LEFT JOIN type |
| class  | [LinkingSetRelationAttribute](Serenity.Data.Mapping/LinkingSetRelationAttribute.md) | Specifies a linking set relation (1-N relation of ID values, like a check list.) |
| class  | [LookupIncludeAttribute](Serenity.Data.Mapping/LookupIncludeAttribute.md) | Marks the property so that it should be included in lookup by default. |
| class  | [MasterDetailRelationAttribute](Serenity.Data.Mapping/MasterDetailRelationAttribute.md) | Defines a master detail relation (1-N) between this row and another |
| class  | [MinSelectLevelAttribute](Serenity.Data.Mapping/MinSelectLevelAttribute.md) | Determines minimum selection level for this field. |
| class  | [NotMappedAttribute](Serenity.Data.Mapping/NotMappedAttribute.md) | Specifies that this property is not mapped to an SQL column/expression |
| class  | [NotNullAttribute](Serenity.Data.Mapping/NotNullAttribute.md) | Specifies that field can not be null. |
| class  | [OriginAttribute](Serenity.Data.Mapping/OriginAttribute.md) | Specifies that this column belongs to another table. |
| class  | [OuterApplyAttribute](Serenity.Data.Mapping/OuterApplyAttribute.md) | Adds a OUTER APPLY to the row |
| class  | [PrimaryKeyAttribute](Serenity.Data.Mapping/PrimaryKeyAttribute.md) | Marks the property as part of the primary key. |
| class  | [QuickSearchAttribute](Serenity.Data.Mapping/QuickSearchAttribute.md) | Marks the property so that it should be included in quick text searches. |
| class  | [ScaleAttribute](Serenity.Data.Mapping/ScaleAttribute.md) | Determines numeric scale (decimal places) for the field. |
| enum  | [SearchType](Serenity.Data.Mapping/SearchType.md) | Quick search type enumeration |
| class  | [SetFieldFlagsAttribute](Serenity.Data.Mapping/SetFieldFlagsAttribute.md) | Used to turn on (include) or turn off (exclude) field flags. |
| class  | [SizeAttribute](Serenity.Data.Mapping/SizeAttribute.md) | Determines size (max length or numeric precision for) for the field. |
| class  | [TableNameAttribute](Serenity.Data.Mapping/TableNameAttribute.md) | Determines table name for the row. |
| class  | [TextualFieldAttribute](Serenity.Data.Mapping/TextualFieldAttribute.md) | Determines textual field for this field. This is placed on FK's and specifies which field in joined table (view fields in this row that originates from foreign table) should be used for display / filtering. |
| class  | [UniqueAttribute](Serenity.Data.Mapping/UniqueAttribute.md) | Defines a unique constraint on the field |
| class  | [UniqueConstraintAttribute](Serenity.Data.Mapping/UniqueConstraintAttribute.md) | Adds a unique constraint check to the row. |
| class  | [UpdatableExtensionAttribute](Serenity.Data.Mapping/UpdatableExtensionAttribute.md) | Marks the JOIN as an updatable extension. |

## Serenity.Data.Schema namespace

| signature | name | description |
| --: | --- | --- |
| class  | [FieldInfo](Serenity.Data.Schema/FieldInfo.md) | Meta data information for an SQL column |
| class  | [FirebirdSchemaProvider](Serenity.Data.Schema/FirebirdSchemaProvider.md) | Firebird metadata provider. |
| class  | [ForeignKeyInfo](Serenity.Data.Schema/ForeignKeyInfo.md) | SQL metadata for a foreign key |
| interface  | [ISchemaProvider](Serenity.Data.Schema/ISchemaProvider.md) | Abstraction for SQL metadata providers |
| class  | [MySqlSchemaProvider](Serenity.Data.Schema/MySqlSchemaProvider.md) | MySql metadata provider |
| class  | [OracleSchemaProvider](Serenity.Data.Schema/OracleSchemaProvider.md) | Oracle metadata provider. |
| class  | [PostgresSchemaProvider](Serenity.Data.Schema/PostgresSchemaProvider.md) | PostgreSQL metadata provider |
| class  | [SqliteSchemaProvider](Serenity.Data.Schema/SqliteSchemaProvider.md) | SQLite metadata provider |
| class  | [SqlServerSchemaProvider](Serenity.Data.Schema/SqlServerSchemaProvider.md) | SQL server metadata provider |
| class  | [TableName](Serenity.Data.Schema/TableName.md) | Table schema/name and view information |

## Serenity.Extensions.DependencyInjection namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [DataServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/DataServiceCollectionExtensions.md) | Contains extensions to register data services |