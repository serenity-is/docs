# Serenity.Net.Services assembly

## Serenity namespace

| signature | name | description |
| --: | --- | --- |
| enum  | [CaptureOperationType](Serenity/CaptureOperationType.md) | Contains capture logging operation types |
| static class  | [ChainableExtensions](Serenity/ChainableExtensions.md) | Contains method chaining extensions for objects like SQL queries that implement [`IChainable`](Serenity/IChainable.md) |
| interface  | [IChainable](Serenity/IChainable.md) | Interface for chainable objects, e.g. with functions returning themselves. |
| interface  | [ICriteria](Serenity/ICriteria.md) | Shared criteria interface |
| interface  | [ICustomValidator](Serenity/ICustomValidator.md) | Custom validator abstraction |
| interface  | [IValidationContext](Serenity/IValidationContext.md) | Validation context abstraction |
| struct  | [OptionalValue&lt;T&gt;](Serenity/OptionalValue-1.md) | An optional value returned by some methods like interceptors. It can be used to indicate that the result is optional and if default is returned, the operation should continue normally. |
| static class  | [PrefixHelper](Serenity/PrefixHelper.md) | Contains static methods to determine prefix length for a list E.g. to find the prefix that all the columns of a table have |

## Serenity.ComponentModel namespace

| signature | name | description |
| --: | --- | --- |
| class  | [AddBehaviorAttribute](Serenity.ComponentModel/AddBehaviorAttribute.md) | Attaches an explicit behavior |

## Serenity.Data namespace

| signature | name | description |
| --: | --- | --- |
| class  | [Alias](Serenity.Data/Alias.md) | Used to define aliases like (T0). |
| static class  | [AliasedFields](Serenity.Data/AliasedFields.md) | Contains extension method to create aliased fields |
| static class  | [AliasExtensions](Serenity.Data/AliasExtensions.md) | Contains extension methods for Alias objects |
| abstract class  | [BaseCriteria](Serenity.Data/BaseCriteria.md) | Base criteria object type |
| abstract class  | [BaseCriteriaVisitor](Serenity.Data/BaseCriteriaVisitor.md) | A visitor implementation for BaseCriteria object trees. |
| class  | [BinaryCriteria](Serenity.Data/BinaryCriteria.md) | Binary criteria object, which has two operands and a operator. |
| class  | [BooleanField](Serenity.Data/BooleanField.md) | Field with boolean value |
| static class  | [BracketLocator](Serenity.Data/BracketLocator.md) | Contains helper methods for locating / replacing brackets in an SQL expression |
| class  | [ByteArrayField](Serenity.Data/ByteArrayField.md) | Field with a byte[] value |
| class  | [CaptureLogAttribute](Serenity.Data/CaptureLogAttribute.md) | Enables capture logging for a row type |
| static class  | [ConnectionExtensions](Serenity.Data/ConnectionExtensions.md) | Contains DB connection related extensions |
| class  | [ConnectionKeyAttribute](Serenity.Data/ConnectionKeyAttribute.md) | Determines the connection key used for a class |
| class  | [ConnectionStringEntry](Serenity.Data/ConnectionStringEntry.md) | Connection string setting |
| class  | [ConnectionStringInfo](Serenity.Data/ConnectionStringInfo.md) | Contains a connection string, its key and provider name. |
| class  | [ConnectionStringOptions](Serenity.Data/ConnectionStringOptions.md) | Connection string options |
| static class  | [ConnectionStringsExtensions](Serenity.Data/ConnectionStringsExtensions.md) | Contains connection string extensions |
| class  | [ConstantCriteria](Serenity.Data/ConstantCriteria.md) | A constant criteria object, which only contains a value expression that would be converted to its string representation in SQL, not a parameterized value. |
| class  | [Criteria](Serenity.Data/Criteria.md) | An object that is used to create criterias by employing operator overloading features of C# language, instead of using string based criterias. |
| class  | [CriteriaFieldExpressionReplacer](Serenity.Data/CriteriaFieldExpressionReplacer.md) | Converts field names in a criteria to their corresponding SQL field expressions. |
| enum  | [CriteriaOperator](Serenity.Data/CriteriaOperator.md) | Set of criteria operator types |
| class  | [CrossApply](Serenity.Data/CrossApply.md) | CROSS APPLY type of join |
| class  | [CustomClassField&lt;TValue&gt;](Serenity.Data/CustomClassField-1.md) | Base class for custom fields with reference type values |
| class  | [DataAuditLogAttribute](Serenity.Data/DataAuditLogAttribute.md) | Indicates that the entity should be audit logged. This feature is only available in premium app. |
| class  | [DatabaseAliasAttribute](Serenity.Data/DatabaseAliasAttribute.md) | Determines database alias, used for unit test database contexts. |
| class  | [DatabaseCaretReferences](Serenity.Data/DatabaseCaretReferences.md) | Helper class for replacing database caret references in format [^ConnectionKey] in SQL expressions. |
| static class  | [DataReaderExtensions](Serenity.Data/DataReaderExtensions.md) | Extension methods for IDataReader objects. |
| class  | [DateOnlyField](Serenity.Data/DateOnlyField.md) | Field with a DateOnly value |
| enum  | [DateParts](Serenity.Data/DateParts.md) | DateParts type |
| class  | [DateTimeField](Serenity.Data/DateTimeField.md) | Field with a DateTime value |
| class  | [DateTimeKindAttribute](Serenity.Data/DateTimeKindAttribute.md) | Determines Time kind for a DateTime field. |
| class  | [DateTimeOffsetField](Serenity.Data/DateTimeOffsetField.md) | Field with a DateTimeOffset value |
| class  | [DecimalField](Serenity.Data/DecimalField.md) | Field with a Decimal value |
| class  | [DefaultConnectionStrings](Serenity.Data/DefaultConnectionStrings.md) | Default connection string source |
| class  | [DefaultRowFieldsProvider](Serenity.Data/DefaultRowFieldsProvider.md) | Default row fields instance provider, that resolves row fields instances using ActivatorUtilities.CreateInstance through a IServiceProvider. |
| class  | [DefaultRowTypeRegistry](Serenity.Data/DefaultRowTypeRegistry.md) | Default row type registry |
| class  | [DefaultSqlConnections](Serenity.Data/DefaultSqlConnections.md) | Default connection factory |
| class  | [DefaultSqlDialectMapper](Serenity.Data/DefaultSqlDialectMapper.md) | Sql Dialect mapper |
| class  | [DeltaLister&lt;TItem&gt;](Serenity.Data/DeltaLister-1.md) | Helper class to find differences between to lists for updating |
| [Flags] enum  | [DeltaOptions](Serenity.Data/DeltaOptions.md) | Delta options flags |
| class  | [DialectExpressionSelector](Serenity.Data/DialectExpressionSelector.md) | Selects field expressions based on dialect |
| static class  | [DisplayOrderHelper](Serenity.Data/DisplayOrderHelper.md) | A static class with helper functions to update display orders of all records or groups of records in a table. |
| class  | [DoubleField](Serenity.Data/DoubleField.md) | Field with a Double value |
| class  | [EmitFieldTypeAttribute](Serenity.Data/EmitFieldTypeAttribute.md) | Declares that the field generated for this template property should be of type specified. |
| class  | [EmitNameAttribute](Serenity.Data/EmitNameAttribute.md) | Declares that the property generated for this template property should have the specified name, instead of the auto generated one. |
| static class  | [EntityConnectionExtensions](Serenity.Data/EntityConnectionExtensions.md) | Contains extension methods to perform entity CRUD operations directly on connections. Please note that all these methods operate on a low level, and none of them call service behaviors or performs service validations. |
| static class  | [EntityFieldExtensions](Serenity.Data/EntityFieldExtensions.md) | Contains static extension methods for Field objects. |
| static class  | [EntityQueryExtensions](Serenity.Data/EntityQueryExtensions.md) | Extensions for objects implementing IDbWhere interface. |
| static class  | [EntitySqlHelper](Serenity.Data/EntitySqlHelper.md) | Contains extension methods to query entities directly |
| static class  | [EntitySqlQueryExtensions](Serenity.Data/EntitySqlQueryExtensions.md) | Extensions for SqlQuery. |
| class  | [EnumField&lt;TEnum&gt;](Serenity.Data/EnumField-1.md) | Field with an Enum value |
| enum  | [ExpectedRows](Serenity.Data/ExpectedRows.md) | Expected number of rows enumeration for SQL Update / Delete operation. This enumeration is used to avoid updating/deleting multiple records by mistake when forgot to add a WHERE statement. |
| class  | [FallbackRowFieldsProvider](Serenity.Data/FallbackRowFieldsProvider.md) | Fallback row fields provider for cases where a IServiceProvider is not available. |
| abstract class  | [Field](Serenity.Data/Field.md) | Base Field class |
| [Flags] enum  | [FieldFlags](Serenity.Data/FieldFlags.md) | Flags that determine basic properties of a field |
| enum  | [FieldType](Serenity.Data/FieldType.md) | Enumeration of field types |
| static class  | [FilterableQueryExtensions](Serenity.Data/FilterableQueryExtensions.md) | Extensions for objects implementing IDbWhere interface. |
| class  | [FirebirdDialect](Serenity.Data/FirebirdDialect.md) | Firebird dialect |
| abstract class  | [FunctionCallCriteria](Serenity.Data/FunctionCallCriteria.md) | Criteria object that identifies a function call |
| abstract class  | [GenericClassField&lt;TValue&gt;](Serenity.Data/GenericClassField-1.md) | Base class for fields with reference type values |
| abstract class  | [GenericField&lt;TValue&gt;](Serenity.Data/GenericField-1.md) | Base generic class for fields with a value |
| abstract class  | [GenericValueField&lt;TValue&gt;](Serenity.Data/GenericValueField-1.md) | Base class for fields with a value type value |
| class  | [GuidField](Serenity.Data/GuidField.md) | Field with a Guid value |
| interface  | [IAlias](Serenity.Data/IAlias.md) | Interface for table aliases. |
| interface  | [ICaptureLogHandler](Serenity.Data/ICaptureLogHandler.md) | Capture logging handler abstraction |
| interface  | [ICaptureLogRow](Serenity.Data/ICaptureLogRow.md) | Interface for capture logging row types |
| interface  | [IConnectionProfiler](Serenity.Data/IConnectionProfiler.md) | An interface used to abstract profilers like Mini Profiler. |
| interface  | [IConnectionString](Serenity.Data/IConnectionString.md) | Contains a connection string, its key and provider name. |
| interface  | [IConnectionStrings](Serenity.Data/IConnectionStrings.md) | Abstraction to access connection strings along with dialect and provider information |
| interface  | [IDeleteLogRow](Serenity.Data/IDeleteLogRow.md) | Interface for rows that have DeleteUserId and DeleteDate fields. |
| interface  | [IDisplayNameRow](Serenity.Data/IDisplayNameRow.md) | An interface to provide access to a display name field |
| interface  | [IDisplayOrderRow](Serenity.Data/IDisplayOrderRow.md) | Basic interface for rows that has a display order field and provides a default sorting order. |
| class  | [IdPropertyAttribute](Serenity.Data/IdPropertyAttribute.md) | Determines that the attached property is the ID field of the table. |
| interface  | [IEditableRow](Serenity.Data/IEditableRow.md) | Methods and properties of a row to support desktop app grid etc. editing |
| interface  | [IEmailRow](Serenity.Data/IEmailRow.md) | An interface that provides access to email field |
| interface  | [IEntity](Serenity.Data/IEntity.md) | An interface for entities with Table property |
| interface  | [IEntityWithJoins](Serenity.Data/IEntityWithJoins.md) | Interface for an entity with join information |
| interface  | [IEnumTypeField](Serenity.Data/IEnumTypeField.md) | Interface for fields with an enum type property |
| interface  | [IField](Serenity.Data/IField.md) | Field object abstraction for SQL query |
| interface  | [IFieldWithJoinInfo](Serenity.Data/IFieldWithJoinInfo.md) | Interface for a field with join and referenced join alias information |
| interface  | [IFilterableQuery](Serenity.Data/IFilterableQuery.md) | Interface for query classes (e.g. SqlSelect, SqlUpdate) having a where method to filter records |
| interface  | [IGetExpressionByName](Serenity.Data/IGetExpressionByName.md) | Interface for query classes (e.g. SqlQuery) that can return expression given column name |
| interface  | [IHasActualConnection](Serenity.Data/IHasActualConnection.md) | Interfaces for types that has an ActualConnection property of type IDbConnection |
| interface  | [IHasActualTransaction](Serenity.Data/IHasActualTransaction.md) | Interfaces for types that has an ActualTransaction property of type IDbTransaction |
| interface  | [IHasCommandTimeout](Serenity.Data/IHasCommandTimeout.md) | Interfaces for types that has an CommandTimeout property that determines the default command timeout for that connection |
| interface  | [IHasConnectionStateChange](Serenity.Data/IHasConnectionStateChange.md) | Interfaces for types that has a connection StateChange event (e.g. connection) |
| interface  | [IHasCurrentTransaction](Serenity.Data/IHasCurrentTransaction.md) | Interfaces for types that has a CurrentTransaction property of type IDbTransaction |
| interface  | [IHasDialect](Serenity.Data/IHasDialect.md) | Interfaces for types that has a Dialect property of type ISqlDialect |
| interface  | [IHasLogger](Serenity.Data/IHasLogger.md) | Interfaces for types that has an Logger |
| interface  | [IHasOpenedOnce](Serenity.Data/IHasOpenedOnce.md) | Interfaces for types that has an OpenedOnce property that determines if the connection has opened at least once |
| interface  | [IHaveJoins](Serenity.Data/IHaveJoins.md) | Interface for row type that provides a list of its joins |
| interface  | [IIdRow](Serenity.Data/IIdRow.md) | Basic interface for rows that has an ID field. You should put [IdProperty] attribute to corresponding field. |
| interface  | [IInsertDateRow](Serenity.Data/IInsertDateRow.md) | Interface for rows that has InsertDate field |
| interface  | [IInsertLogRow](Serenity.Data/IInsertLogRow.md) | Interface for rows that have InsertUserId and InsertDate fields |
| interface  | [IInsertUserIdRow](Serenity.Data/IInsertUserIdRow.md) | Interface for rows that has InsertUserId field |
| interface  | [IIsActiveDeletedRow](Serenity.Data/IIsActiveDeletedRow.md) | Marks an IIsActiveRow that -1 is used as deleted value |
| interface  | [IIsActiveRow](Serenity.Data/IIsActiveRow.md) | Interface for an entity with active field |
| interface  | [IIsDeletedRow](Serenity.Data/IIsDeletedRow.md) | Determines that this row uses soft delete and the field that holds this flag |
| interface  | [ILocalizationRow](Serenity.Data/ILocalizationRow.md) | Interface for rows with a CultureId field |
| interface  | [ILoggingRow](Serenity.Data/ILoggingRow.md) | A combination of IUpdateLogRow and IInsertLogRow |
| interface  | [IMustRemoveT0](Serenity.Data/IMustRemoveT0.md) | Obsolete interface |
| interface  | [INameRow](Serenity.Data/INameRow.md) | Marks a row as having a Name field (e.g. description for row). You should put [NameProperty] attribute to corresponding field |
| class  | [InnerJoin](Serenity.Data/InnerJoin.md) | INNER JOIN type |
| class  | [InstanceNameAttribute](Serenity.Data/InstanceNameAttribute.md) | Determines non-plural name for an entity. |
| class  | [Int16Field](Serenity.Data/Int16Field.md) | Field with Int16 value |
| class  | [Int32Field](Serenity.Data/Int32Field.md) | Field with Int32 value |
| class  | [Int64Field](Serenity.Data/Int64Field.md) | Field with Int64 value |
| interface  | [IParentIdRow](Serenity.Data/IParentIdRow.md) | Interface for rows that has a ParentId field |
| interface  | [IPasswordRow](Serenity.Data/IPasswordRow.md) | An interface that provides access to password hash and salt fields |
| interface  | [IQueryWithParams](Serenity.Data/IQueryWithParams.md) | Interface for objects setting parameters by PARAM method (like SqlInsert, SqlUpdate, SqlDelete...) |
| interface  | [IRow&lt;TFields&gt;](Serenity.Data/IRow-1.md) | Base interface for Rows with a known Fields type |
| interface  | [IRow](Serenity.Data/IRow.md) | Row interface |
| interface  | [IRowFieldsProvider](Serenity.Data/IRowFieldsProvider.md) | Abstraction for row fields instance providers |
| interface  | [IRowOperationInterceptor](Serenity.Data/IRowOperationInterceptor.md) | An interface that allows you to intercept SQL operations on entities. Note that this does not intercept all SQL operations, only the ones that are done through EntityConnectionExtensions. This interface should be implemented by the mock connection class used in tests. |
| interface  | [IRowTypeRegistry](Serenity.Data/IRowTypeRegistry.md) | Abstraction for row type registry. |
| interface  | [ISetFieldByStatement](Serenity.Data/ISetFieldByStatement.md) | Interface for objects setting values by SetTo method (like SqlInsert, SqlUpdate...) |
| interface  | [ISqlConnections](Serenity.Data/ISqlConnections.md) | An interface used to abstract sql connections |
| interface  | [ISqlDialect](Serenity.Data/ISqlDialect.md) | Abstraction for SQL dialect, e.g. syntax for different SQL server types and connection settings. |
| interface  | [ISqlDialectMapper](Serenity.Data/ISqlDialectMapper.md) | The sql dialect mapper |
| interface  | [ISqlExpressionTranslator](Serenity.Data/ISqlExpressionTranslator.md) | An interface custom ISqlDialect types can implement to change generated expressions for dynamic expression like ConcatExpressionAttribute. They should return NULL if it can't handle this expression type |
| interface  | [ISqlOperationInterceptor](Serenity.Data/ISqlOperationInterceptor.md) | An interface that makes it possible to intercept basic SQL operations on connections (e.g. SqlHelper extensions) mostly for testing purposes. Note that this does not intercept all SQL operations, only the ones that are done through SqlHelper extensions. It does not intercept Dapper operations, for example. This interface should be implemented by the mock connection class used in tests. |
| interface  | [ISqlQuery](Serenity.Data/ISqlQuery.md) | SqlQuery interface. |
| interface  | [ISqlQueryExtensible](Serenity.Data/ISqlQueryExtensible.md) | Extensible SQL query interface. Used to abstract Serenity.Data.Row dependency from SqlQuery. |
| interface  | [ISqlQueryToString](Serenity.Data/ISqlQueryToString.md) | SqlQuery interface. |
| interface  | [IUnitOfWork](Serenity.Data/IUnitOfWork.md) | An interface to implement unit of work pattern, e.g. a transaction. |
| interface  | [IUpdateDateRow](Serenity.Data/IUpdateDateRow.md) | Interface for rows that has a UpdateDate field |
| interface  | [IUpdateLogRow](Serenity.Data/IUpdateLogRow.md) | Interface for rows that have UpdateUserId and UpdateDate fields |
| interface  | [IUpdateUserIdRow](Serenity.Data/IUpdateUserIdRow.md) | Interface for rows that has a UpdateUserId field |
| abstract class  | [Join](Serenity.Data/Join.md) | Corresponds to an SQL JOIN (INNER, OUTER, CROSS etc.) |
| class  | [JoinAliasLocator](Serenity.Data/JoinAliasLocator.md) | Locates alias references in an SQL expression |
| class  | [JsonCriteriaConverter](Serenity.Data/JsonCriteriaConverter.md) | Serialize/deserialize a BaseCriteria object |
| class  | [JsonField&lt;TValue&gt;](Serenity.Data/JsonField-1.md) | Field with JSON value |
| class  | [JsonRowConverter](Serenity.Data/JsonRowConverter.md) | Serialize/deserialize a row |
| class  | [JsonSafeCriteriaConverter](Serenity.Data/JsonSafeCriteriaConverter.md) | Serialize/deserialize a BaseCriteria object and checks for safety of criteria expressions. |
| class  | [LeftJoin](Serenity.Data/LeftJoin.md) | LEFT JOIN type |
| class  | [ListField&lt;TItem&gt;](Serenity.Data/ListField-1.md) | Field with a list value |
| class  | [LocalizationRowAttribute](Serenity.Data/LocalizationRowAttribute.md) | Maps a row to its localization row |
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
| class  | [RightJoin](Serenity.Data/RightJoin.md) | RIGHT JOIN type |
| abstract class  | [Row&lt;TFields&gt;](Serenity.Data/Row-1.md) | Base class for Serenity entities |
| static class  | [RowExtensions](Serenity.Data/RowExtensions.md) | Contains extensions for row objects |
| class  | [RowField&lt;TForeign&gt;](Serenity.Data/RowField-1.md) | Field with a Row value |
| class  | [RowFieldsBase](Serenity.Data/RowFieldsBase.md) | Base class for row fields collection |
| static class  | [RowFieldsProvider](Serenity.Data/RowFieldsProvider.md) | Contains extension methods and settings for row fields providers |
| class  | [RowListField&lt;TForeign&gt;](Serenity.Data/RowListField-1.md) | Field with a RowList value |
| class  | [SafeCriteriaValidator](Serenity.Data/SafeCriteriaValidator.md) | Validates a criteria for allowed field names, operators and SQL injection safety |
| enum  | [SelectLevel](Serenity.Data/SelectLevel.md) | Select level enumeration |
| enum  | [ServerType](Serenity.Data/ServerType.md) | Contains server type names for common dialects |
| static class  | [ServiceAuthorizationExtensions](Serenity.Data/ServiceAuthorizationExtensions.md) | Contains static extension methods for DbField and Meta objects. |
| static class  | [ServiceRequestExtensions](Serenity.Data/ServiceRequestExtensions.md) | Contains static extension methods for DbField and Meta objects. |
| static class  | [SetFieldByStatementExtensions](Serenity.Data/SetFieldByStatementExtensions.md) | Extension methods for classes implementing IDbSet interface |
| class  | [SingleField](Serenity.Data/SingleField.md) | Field with a Single value |
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
| class  | [StreamField](Serenity.Data/StreamField.md) | Field with a Stream value |
| class  | [StringField](Serenity.Data/StringField.md) | Field with a String value |
| static class  | [T0ReferenceRemover](Serenity.Data/T0ReferenceRemover.md) | Removes T0. references in SQL expression |
| class  | [TimeSpanField](Serenity.Data/TimeSpanField.md) | Field with a TimeSpan value |
| class  | [TransactionlessUnitOfWork](Serenity.Data/TransactionlessUnitOfWork.md) | Unit of work implementation without an underlying actual transaction. Use with care only to pass a IUnitOfWork instance to some methods that you don't want to actually start a transaction. |
| class  | [TransactionSettings](Serenity.Data/TransactionSettings.md) | Determines the transaction isolation level and defer start flag used for service endpoint action use when creating the UnitOfWork class |
| class  | [TransactionSettingsAttribute](Serenity.Data/TransactionSettingsAttribute.md) | Determines the transaction isolation level and defer start flag used for a service endpoint action use when creating the UnitOfWork class |
| class  | [TwoLevelCachedAttribute](Serenity.Data/TwoLevelCachedAttribute.md) | This attribute marks a row so that when it is Inserted/Updated/Deleted through handler, its related cache, if any should be cleared. It doesn't turn on/off caching. A sample of related cached item to a row, might be its lookup if any. |
| class  | [UnaryCriteria](Serenity.Data/UnaryCriteria.md) | Unary criteria with one operand and operator |
| class  | [UnitOfWork](Serenity.Data/UnitOfWork.md) | Unit of work implementation. |
| class  | [UpperFunctionCriteria](Serenity.Data/UpperFunctionCriteria.md) | Criteria object that identifies an UPPER function call |
| class  | [ValueCriteria](Serenity.Data/ValueCriteria.md) | Criteria object with one value |
| class  | [VariantField](Serenity.Data/VariantField.md) | Field with a Variant (e.g. SQL VARIANT) value |
| class  | [WrappedConnection](Serenity.Data/WrappedConnection.md) | Wraps a connection to add current transaction and dialect support. |
| class  | [WrappedTransaction](Serenity.Data/WrappedTransaction.md) | Wraps a transaction instance to add current transaction support for the wrapped connection. |

## Serenity.Data.Mapping namespace

| signature | name | description |
| --: | --- | --- |
| class  | [AuditedAttribute](Serenity.Data.Mapping/AuditedAttribute.md) | Indicates if the field is audited. For DataAuditLog, all fields are audited by default, but if the field has [Audited(false)] it will not be logged. |
| class  | [AutoIncrementAttribute](Serenity.Data.Mapping/AutoIncrementAttribute.md) | Marks the field as auto increment, e.g. generated on insert in SQL side |
| abstract class  | [BaseExpressionAttribute](Serenity.Data.Mapping/BaseExpressionAttribute.md) | Specifies SQL expression this property corresponds to. You may use brackets ([]) to escape identifiers. Brackets will be converted to database specific quotes. |
| class  | [CaseAttribute](Serenity.Data.Mapping/CaseAttribute.md) | Concat expression attribute |
| class  | [CaseSwitchAttribute](Serenity.Data.Mapping/CaseSwitchAttribute.md) | Case expression with simple switch value |
| class  | [ColumnAttribute](Serenity.Data.Mapping/ColumnAttribute.md) | Explicitly specifies the database column name for property. Use this attribute if matching column name in database is different than the property name. |
| class  | [ConcatAttribute](Serenity.Data.Mapping/ConcatAttribute.md) | Concat expression attribute |
| class  | [DateDiffAttribute](Serenity.Data.Mapping/DateDiffAttribute.md) | DateDiff expression attribute |
| class  | [DatePartAttribute](Serenity.Data.Mapping/DatePartAttribute.md) | DatePart expression attribute |
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
| class  | [SqlDateTimeOffsetAttribute](Serenity.Data.Mapping/SqlDateTimeOffsetAttribute.md) | Dialect specific SQL expression for current date/time with timezone |
| class  | [SqlNowAttribute](Serenity.Data.Mapping/SqlNowAttribute.md) | Dialect specific SQL expression for current date/time in server's timezone |
| class  | [SqlUtcNowAttribute](Serenity.Data.Mapping/SqlUtcNowAttribute.md) | Dialect specific SQL expression for UTC date/time |
| class  | [TableNameAttribute](Serenity.Data.Mapping/TableNameAttribute.md) | Determines table name for the row. |
| class  | [TextualFieldAttribute](Serenity.Data.Mapping/TextualFieldAttribute.md) | Determines textual field for this field. This is placed on foreign keys and specifies which field in joined table (view fields in this row that originates from foreign table) should be used for display / filtering. |
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
| static class  | [EntityServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/EntityServiceCollectionExtensions.md) | Contains extensions to register entity services |
| static class  | [ServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions.md) | Contains dependency injection extensions for IServiceCollection |

## Serenity.IO namespace

| signature | name | description |
| --: | --- | --- |
| class  | [CommandLineTools](Serenity.IO/CommandLineTools.md) | Contains functions related to command line |

## Serenity.JsonConverters namespace

| signature | name | description |
| --: | --- | --- |
| class  | [CriteriaJsonConverter](Serenity.JsonConverters/CriteriaJsonConverter.md) | Serialize/deserialize a BaseCriteria object |
| class  | [RowJsonConverter](Serenity.JsonConverters/RowJsonConverter.md) | Serialize/deserialize a row |
| class  | [SafeCriteriaJsonConverter](Serenity.JsonConverters/SafeCriteriaJsonConverter.md) | Serialize/deserialize a BaseCriteria object and checks for safety of criteria expressions. |
| class  | [SortByJsonConverter](Serenity.JsonConverters/SortByJsonConverter.md) | Serialize/deserialize a SortBy object as string |

## Serenity.Localization namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [EntityLocalTexts](Serenity.Localization/EntityLocalTexts.md) | EntityLocalTexts |

## Serenity.PropertyGrid namespace

| signature | name | description |
| --: | --- | --- |
| class  | [BasicPropertyProcessor](Serenity.PropertyGrid/BasicPropertyProcessor.md) | Basic property processor |
| class  | [DefaultPropertyItemProvider](Serenity.PropertyGrid/DefaultPropertyItemProvider.md) | Default property item provider |
| interface  | [IPropertyItemProvider](Serenity.PropertyGrid/IPropertyItemProvider.md) | Abstraction for the provider that returns a list of property items for a given type |
| interface  | [IPropertyProcessor](Serenity.PropertyGrid/IPropertyProcessor.md) | Interface for property processors, which sets properties of a PropertyItem object by analysing a IPropertySource object. |
| interface  | [IPropertySource](Serenity.PropertyGrid/IPropertySource.md) | Abstracts the property source that returns PropertyInfo and some other info |
| class  | [LocalizablePropertyProcessor](Serenity.PropertyGrid/LocalizablePropertyProcessor.md) | Property processor for handling localizable properties |
| class  | [PropertyInfoSource](Serenity.PropertyGrid/PropertyInfoSource.md) | Property info source for a reflection PropertyInfo object |
| abstract class  | [PropertyProcessor](Serenity.PropertyGrid/PropertyProcessor.md) | Base class for property processors, which sets properties of a PropertyItem object by analysing a IPropertySource object. |
| class  | [PropertyProcessorOptions](Serenity.PropertyGrid/PropertyProcessorOptions.md) | Property item generation options for BasicPropertyProcessor |

## Serenity.Reporting namespace

| signature | name | description |
| --: | --- | --- |
| abstract class  | [BaseCellDecorator](Serenity.Reporting/BaseCellDecorator.md) | Base class for cell decorators, implementing all [`ICellDecorator`](Serenity.Reporting/ICellDecorator.md) members. |
| abstract class  | [BaseReport](Serenity.Reporting/BaseReport.md) | Base class for reports that implement [`IReport`](Serenity.Reporting/IReport.md) and optionally [`IReportWithAdditionalData`](Serenity.Reporting/IReportWithAdditionalData.md) |
| class  | [CellDecoratorAttribute](Serenity.Reporting/CellDecoratorAttribute.md) | Attribute used to set the [`ICellDecorator`](Serenity.Reporting/ICellDecorator.md) type for a property. |
| class  | [EnumDecorator](Serenity.Reporting/EnumDecorator.md) | A decorator used to export enum name instead of the enum integer value. |
| class  | [GenerateCsvRequest](Serenity.Reporting/GenerateCsvRequest.md) | Request model for a CSV exporter. |
| class  | [GenerateExcelFileRequest](Serenity.Reporting/GenerateExcelFileRequest.md) | Request model for an Excel exporter. |
| class  | [HtmlReportRenderUrl](Serenity.Reporting/HtmlReportRenderUrl.md) | Response type for IHtmlReportRenderUrlBuilder.GetRenderUrl method |
| class  | [HtmlToPdfOptions](Serenity.Reporting/HtmlToPdfOptions.md) | HTML to PDF options |
| interface  | [ICellDecorator](Serenity.Reporting/ICellDecorator.md) | Cell decorator interface mainly used for Excel export styling. |
| interface  | [ICustomFileName](Serenity.Reporting/ICustomFileName.md) | Interface to customize the output file name, e.g. name of the XLSX or PDF file outputted by reports. By default, reports has output file name of format "{ReportKey}_yyyyMMdd_HHmmss.ext". |
| interface  | [ICustomizeHtmlToPdf](Serenity.Reporting/ICustomizeHtmlToPdf.md) | An interface reports can implement to customize HTML to PDF converter settings. |
| interface  | [ICustomTitle](Serenity.Reporting/ICustomTitle.md) | Interface to customize the report title. |
| interface  | [IDataOnlyReport](Serenity.Reporting/IDataOnlyReport.md) | Interface for reports that only contain data, e.g. no design. These are usually Excel/CSV etc. export type of reports. |
| interface  | [IDataReportExcelRenderer](Serenity.Reporting/IDataReportExcelRenderer.md) | Excel exporter interface for data only reports. This is usually implemented by ClosedXML based exporter. The interface abstracts that dependency. |
| interface  | [IExcelExporter](Serenity.Reporting/IExcelExporter.md) | Interface for Excel exporters |
| interface  | [IExternalReport](Serenity.Reporting/IExternalReport.md) | This interface marks a report class as a report that should open an external URL, e.g. an SSRS report url, or any arbitrary site The URL should be returned from GetData() method of report class. |
| interface  | [IHtmlReportCallbackUrlBuilder](Serenity.Reporting/IHtmlReportCallbackUrlBuilder.md) | Abstraction for HTML report callback url builder |
| interface  | [IHtmlReportPdfRenderer](Serenity.Reporting/IHtmlReportPdfRenderer.md) | PDF exporter interface for HTML reports. |
| interface  | [IHtmlReportRenderUrlBuilder](Serenity.Reporting/IHtmlReportRenderUrlBuilder.md) | Interface abstraction to get HTML report render URL |
| interface  | [IHtmlToPdfConverter](Serenity.Reporting/IHtmlToPdfConverter.md) | Abstraction for service that converts HTML to PDF |
| interface  | [IHtmlToPdfOptions](Serenity.Reporting/IHtmlToPdfOptions.md) | Set of options for HTML to PDF converter (WKHTMLToPdf) |
| interface  | [IReport](Serenity.Reporting/IReport.md) | The basic interface for all reports |
| interface  | [IReportCallbackInterceptor](Serenity.Reporting/IReportCallbackInterceptor.md) | Abstraction for a report callback interceptor that is called by ~/Serenity.Extensions/Report/Render. This is implemented by HtmlReportCallbackUrlInterceptor to implement impersonation and transient granting during report callbacks. |
| interface  | [IReportFactory](Serenity.Reporting/IReportFactory.md) | Abstraction for the a report factory that creates a report by its key and populates it with the JSON options passed |
| interface  | [IReportRegistry](Serenity.Reporting/IReportRegistry.md) | Abstraction for the registry which holds and allows querying list of available reports by their keys and categories. |
| interface  | [IReportRenderer](Serenity.Reporting/IReportRenderer.md) | Abstraction for the a report render that renders a report |
| interface  | [IReportRetrieveHandler](Serenity.Reporting/IReportRetrieveHandler.md) | Abstraction for report info retriever |
| interface  | [IReportWithAdditionalData](Serenity.Reporting/IReportWithAdditionalData.md) | The interface for reports that return some type of additional data. For example, the system settings. This can be considered as additional datasets. |
| interface  | [IWKHtmlToPdfConverter](Serenity.Reporting/IWKHtmlToPdfConverter.md) | WKHTMLToPdf converter interface |
| class  | [ReportAttribute](Serenity.Reporting/ReportAttribute.md) | Marks a class as Report |
| class  | [ReportColumn](Serenity.Reporting/ReportColumn.md) | Information about a report column |
| static class  | [ReportColumnConverter](Serenity.Reporting/ReportColumnConverter.md) | Contains methods to extract ReportColumns from other types. |
| class  | [ReportDesignAttribute](Serenity.Reporting/ReportDesignAttribute.md) | The attribute used to determine the location of the report design which is usually a CSHTML file. |
| static class  | [ReportFactoryExtensions](Serenity.Reporting/ReportFactoryExtensions.md) | Contains extension methods for IReportFactory |
| class  | [ReportRegistry](Serenity.Reporting/ReportRegistry.md) | Default report registry implementation |
| class  | [ReportRenderOptions](Serenity.Reporting/ReportRenderOptions.md) | Render request a report |
| class  | [ReportRenderResult](Serenity.Reporting/ReportRenderResult.md) | Render result for a report |
| class  | [ReportRetrieveRequest](Serenity.Reporting/ReportRetrieveRequest.md) | Request model to retrieve a report by its key. This only returns the metadata, e.g. parameters of report etc. |
| class  | [ReportRetrieveResponse](Serenity.Reporting/ReportRetrieveResponse.md) | Response model for a report retrieve request. |
| class  | [TabularDataReport](Serenity.Reporting/TabularDataReport.md) | An implementation of a data only report which is used mainly for Excel export. |
| class  | [UseWKHtmlToPdfAttribute](Serenity.Reporting/UseWKHtmlToPdfAttribute.md) | Marks a report to determine if it should use WKHTML instead of another converter, e.g. Puppeteer etc. (only if configured in service provider). |

## Serenity.Services namespace

| signature | name | description |
| --: | --- | --- |
| abstract class  | [BaseDeleteBehavior](Serenity.Services/BaseDeleteBehavior.md) | Base class for types implementing [`IDeleteBehavior`](Serenity.Services/IDeleteBehavior.md) |
| abstract class  | [BaseListBehavior](Serenity.Services/BaseListBehavior.md) | Base class for behaviors implementing [`IListBehavior`](Serenity.Services/IListBehavior.md) |
| class  | [BaseRepository](Serenity.Services/BaseRepository.md) | An base class that can be used for repositories (obsolete, [`BaseRequestHandler`](Serenity.Services/BaseRequestHandler.md)) that accept a [`IRequestContext`](Serenity.Services/IRequestContext.md) instance. |
| abstract class  | [BaseRequestHandler](Serenity.Services/BaseRequestHandler.md) | An abstract class that can be used as base for request handlers that accept a [`IRequestContext`](Serenity.Services/IRequestContext.md) instance. |
| abstract class  | [BaseRetrieveBehavior](Serenity.Services/BaseRetrieveBehavior.md) | Base class for behaviors implementing [`IRetrieveBehavior`](Serenity.Services/IRetrieveBehavior.md) |
| abstract class  | [BaseSaveBehavior](Serenity.Services/BaseSaveBehavior.md) | Base class for behaviors implementing [`ISaveBehavior`](Serenity.Services/ISaveBehavior.md) |
| abstract class  | [BaseSaveDeleteBehavior](Serenity.Services/BaseSaveDeleteBehavior.md) | Base class for behaviors implementing save and delete behavior interfaces |
| abstract class  | [BaseUndeleteBehavior](Serenity.Services/BaseUndeleteBehavior.md) | Base class for types implementing [`IUndeleteBehavior`](Serenity.Services/IUndeleteBehavior.md) |
| static class  | [BehaviorProviderExtensions](Serenity.Services/BehaviorProviderExtensions.md) | Extension methods for behavior provider |
| class  | [CaptureLogBehavior](Serenity.Services/CaptureLogBehavior.md) | Capture log behavior |
| class  | [CaptureLogConsts](Serenity.Services/CaptureLogConsts.md) | Contains constants related to the capture logging |
| static class  | [DataValidation](Serenity.Services/DataValidation.md) | Contains validation related helper methods for service handlers |
| static class  | [DataValidationTexts](Serenity.Services/DataValidationTexts.md) |  |
| class  | [DefaultBehaviorFactory](Serenity.Services/DefaultBehaviorFactory.md) | Default [`IBehaviorFactory`](Serenity.Services/IBehaviorFactory.md) implementation |
| class  | [DefaultBehaviorProvider](Serenity.Services/DefaultBehaviorProvider.md) | Default implementation for [`IBehaviorProvider`](Serenity.Services/IBehaviorProvider.md) |
| class  | [DefaultHandlerActivator](Serenity.Services/DefaultHandlerActivator.md) | Default implementation of the [`IHandlerActivator`](Serenity.Services/IHandlerActivator.md) |
| class  | [DefaultHandlerAttribute](Serenity.Services/DefaultHandlerAttribute.md) | Specifies that the class this attribute attached to is the default handler (list, create, delete, update etc). and should be used by some behaviors like MasterDetailRelationBehavior instead of creating a generic handler. |
| class  | [DefaultHandlerFactory](Serenity.Services/DefaultHandlerFactory.md) | Default implementation for the [`IDefaultHandlerFactory`](Serenity.Services/IDefaultHandlerFactory.md) |
| static class  | [DefaultHandlerFactoryExtensions](Serenity.Services/DefaultHandlerFactoryExtensions.md) | Extension methods for [`IDefaultHandlerFactory`](Serenity.Services/IDefaultHandlerFactory.md) |
| class  | [DefaultHandlerRegistry](Serenity.Services/DefaultHandlerRegistry.md) | Default implentation for the [`IDefaultHandlerFactory`](Serenity.Services/IDefaultHandlerFactory.md) |
| class  | [DefaultImplicitBehaviorRegistry](Serenity.Services/DefaultImplicitBehaviorRegistry.md) | Default implementation for the [`IImplicitBehaviorRegistry`](Serenity.Services/IImplicitBehaviorRegistry.md) |
| class  | [DefaultRequestContext](Serenity.Services/DefaultRequestContext.md) | Default implementation for a [`IRequestContext`](Serenity.Services/IRequestContext.md) |
| class  | [DeleteRequest](Serenity.Services/DeleteRequest.md) | Service object for delete requests |
| class  | [DeleteRequestHandler&lt;TRow&gt;](Serenity.Services/DeleteRequestHandler-1.md) | Base generic class for delete request handlers that use [`DeleteRequest`](Serenity.Services/DeleteRequest.md) as the request type, and [`DeleteResponse`](Serenity.Services/DeleteResponse.md) as the response type. |
| class  | [DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](Serenity.Services/DeleteRequestHandler-3.md) | Generic base class for delete request handlers |
| class  | [DeleteResponse](Serenity.Services/DeleteResponse.md) | The response object returned from a delete service |
| class  | [DisplayOrderFilterHelper](Serenity.Services/DisplayOrderFilterHelper.md) | Display order related helper methods |
| class  | [GenericHandlerTypeAttribute](Serenity.Services/GenericHandlerTypeAttribute.md) | Assigns the generic handler type (e.g. [`SaveRequestHandler`](Serenity.Services/SaveRequestHandler-1.md) for a handler interface (like [`ISaveRequestHandler`](Serenity.Services/ISaveRequestHandler.md)) |
| interface  | [IBehaviorFactory](Serenity.Services/IBehaviorFactory.md) | Behavior factory abstraction |
| interface  | [IBehaviorProvider](Serenity.Services/IBehaviorProvider.md) | Interface abstraction for behavior provider which resolves list of behavior instances of a specified type, like [`ISaveBehavior`](Serenity.Services/ISaveBehavior.md) etc. |
| interface  | [ICreateHandler&lt;TRow&gt;](Serenity.Services/ICreateHandler-1.md) | Interface for create request handlers |
| interface  | [ICreateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/ICreateHandler-3.md) | Interface for create request handlers with custom request / response types. |
| interface  | [IDefaultHandlerFactory](Serenity.Services/IDefaultHandlerFactory.md) | Interface to get a new instace of a default request handler, given its row type and the handler interface |
| interface  | [IDefaultHandlerRegistry](Serenity.Services/IDefaultHandlerRegistry.md) | Abstraction for the registry that contains default handler types. |
| interface  | [IDeleteBehavior](Serenity.Services/IDeleteBehavior.md) | A delete behavior that can be used as a mixin within a DeleteRequestHandler lifecycle |
| interface  | [IDeleteExceptionBehavior](Serenity.Services/IDeleteExceptionBehavior.md) | This is an extension for delete behaviors that should be called for exceptions that occur during delete. It could be useful to preview the exception and raise another exception for FK / PK database errors etc. |
| interface  | [IDeleteHandler&lt;TRow&gt;](Serenity.Services/IDeleteHandler-1.md) | Interface for delete request handlers that use [`DeleteRequest`](Serenity.Services/DeleteRequest.md) as request, and [`DeleteResponse`](Serenity.Services/DeleteResponse.md) as response types. |
| interface  | [IDeleteHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](Serenity.Services/IDeleteHandler-3.md) | Interface for delete request handlers with custom delete request / response types. |
| interface  | [IDeleteRequestHandler](Serenity.Services/IDeleteRequestHandler.md) | Represents a DeleteRequestHandler. Is used with DeleteBehavior objects. |
| interface  | [IDeleteRequestProcessor](Serenity.Services/IDeleteRequestProcessor.md) | Abstraction for delete request handlers with a Process method. |
| interface  | [IFieldBehavior](Serenity.Services/IFieldBehavior.md) | Represents a request handler behavior that is targeted to a field. |
| interface  | [IHandlerActivator](Serenity.Services/IHandlerActivator.md) | Abstraction for request handler activator, that is used to create instances of an handler type. |
| interface  | [IImplicitBehavior](Serenity.Services/IImplicitBehavior.md) | An implicit behavior is a request handler behavior (save/list/retrieve/delete etc.) which can be implicitly activated for a row type without explicitly attached to that row type. |
| interface  | [IImplicitBehaviorRegistry](Serenity.Services/IImplicitBehaviorRegistry.md) | An interface to query list of implicit behaviors registered through the dependency resolver. Implicit behaviors are automatically activated behaviors by querying via their ActivateFor method. See [`IImplicitBehavior`](Serenity.Services/IImplicitBehavior.md) |
| interface  | [IIncludeExcludeColumns](Serenity.Services/IIncludeExcludeColumns.md) | Abstraction for service objects containing include / exclude column sets. See [`ListRequest`](Serenity.Services/ListRequest.md) and [`RetrieveRequest`](Serenity.Services/RetrieveRequest.md). |
| interface  | [IListBehavior](Serenity.Services/IListBehavior.md) | A list behavior that can be used as a mixin within a ListRequestHandler lifecycle |
| interface  | [IListExceptionBehavior](Serenity.Services/IListExceptionBehavior.md) | This is an extension for list behaviors that should be called for exceptions that occur during list. It could be useful to preview the exception and raise another exception for JSON serialization errors etc. |
| interface  | [IListHandler&lt;TRow&gt;](Serenity.Services/IListHandler-1.md) | Interface for list request handlers |
| interface  | [IListHandler&lt;TRow,TListRequest&gt;](Serenity.Services/IListHandler-2.md) | Interface for list request handlers with a custom list request type. |
| interface  | [IListHandler&lt;TRow,TListRequest,TListResponse&gt;](Serenity.Services/IListHandler-3.md) | Interface for list request handlers with custom list request / response types. |
| interface  | [IListMapFieldExpressionBehavior](Serenity.Services/IListMapFieldExpressionBehavior.md) | An extension for list behaviors that can map fields to custom expressions within a ListRequestHandler lifecycle. Note that the first behavior that returns a non-null value will be used. |
| interface  | [IListRequestHandler](Serenity.Services/IListRequestHandler.md) | Represents a ListRequestHandler. Is used with ListBehavior objects. |
| interface  | [IListRequestProcessor](Serenity.Services/IListRequestProcessor.md) | Abstraction for list request handlers with a Process method. |
| interface  | [IListResponse](Serenity.Services/IListResponse.md) | The interface for list response. This is used to easily access list response members as the [`ListResponse`](Serenity.Services/ListResponse-1.md) class itself is generic. |
| interface  | [IRequestContext](Serenity.Services/IRequestContext.md) | A service request context abstraction containing services that are mostly used by all service handler types. This is a type similar to the HttpContext but is specialized for service handlers. |
| interface  | [IRequestHandler&lt;TRow&gt;](Serenity.Services/IRequestHandler-1.md) | Marker interface for request handlers that operate on a specific entity type. |
| interface  | [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](Serenity.Services/IRequestHandler-3.md) | Marker interface for request handlers that operate on a specific entity type, request type and a response type. |
| interface  | [IRequestType&lt;TRequestType&gt;](Serenity.Services/IRequestType-1.md) | Interface to access the request type of a request handler |
| interface  | [IResponseType&lt;TResponseType&gt;](Serenity.Services/IResponseType-1.md) | Interface to access the response type of a request handler |
| interface  | [IRetrieveBehavior](Serenity.Services/IRetrieveBehavior.md) | A retrieve behavior that can be used as a mixin within a RetrieveRequestHandler lifecycle |
| interface  | [IRetrieveExceptionBehavior](Serenity.Services/IRetrieveExceptionBehavior.md) | This is an extension for retrieve behaviors that should be called for exceptions that occur during retrieve. It could be useful to preview the exception and raise another exception for JSON serialization errors etc. |
| interface  | [IRetrieveHandler&lt;TRow&gt;](Serenity.Services/IRetrieveHandler-1.md) | Interface for list request handlers |
| interface  | [IRetrieveHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](Serenity.Services/IRetrieveHandler-3.md) | Interface for retrieve request handlers with custom retrieve request / response types. |
| interface  | [IRetrieveRequestHandler](Serenity.Services/IRetrieveRequestHandler.md) | Represents a RetrieveRequestHandler. Is used with RetrieveBehavior objects. |
| interface  | [IRetrieveRequestProcessor](Serenity.Services/IRetrieveRequestProcessor.md) | Abstraction for retrieve request handlers with a Process method. |
| interface  | [IRetrieveResponse](Serenity.Services/IRetrieveResponse.md) | Interface for a [`RetrieveResponse`](Serenity.Services/RetrieveResponse-1.md). As the RetrieveResponse itself is generic, this allows easier access to its members. |
| interface  | [ISaveBehavior](Serenity.Services/ISaveBehavior.md) | A save behavior that can be used as a mixin within a SaveRequestHandler lifecycle |
| interface  | [ISaveExceptionBehavior](Serenity.Services/ISaveExceptionBehavior.md) | This is an extension for save behaviors that should be called for exceptions that occur during save. It could be useful to preview the exception and raise another exception for FK / PK database errors etc. |
| interface  | [ISaveHandler&lt;TRow&gt;](Serenity.Services/ISaveHandler-1.md) | Interface for save request handlers |
| interface  | [ISaveHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/ISaveHandler-3.md) | Interface for save request handlers with custom request / response types. |
| interface  | [ISaveRequest](Serenity.Services/ISaveRequest.md) | Interface for a [`SaveRequest`](Serenity.Services/SaveRequest-1.md). As the SaveRequest itself is generic, this allows easier access to its members. |
| interface  | [ISaveRequestHandler](Serenity.Services/ISaveRequestHandler.md) | Represents a SaveRequestHandler. Is used with SaveBehavior objects. |
| interface  | [ISaveRequestProcessor](Serenity.Services/ISaveRequestProcessor.md) | Abstraction for save request handlers with a Process method. |
| interface  | [IUndeleteBehavior](Serenity.Services/IUndeleteBehavior.md) | A undelete behavior that can be used as a mixin within a UndeleteRequestHandler lifecycle |
| interface  | [IUndeleteExceptionBehavior](Serenity.Services/IUndeleteExceptionBehavior.md) | This is an extension for undelete behaviors that should be called for exceptions that occur during delete. It could be useful to preview the exception and raise another exception for FK / PK database errors etc. |
| interface  | [IUndeleteHandler&lt;TRow&gt;](Serenity.Services/IUndeleteHandler-1.md) | Interface for undelete request handlers that use [`UndeleteRequest`](Serenity.Services/UndeleteRequest.md) as request, and [`UndeleteResponse`](Serenity.Services/UndeleteResponse.md) as response types. |
| interface  | [IUndeleteHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](Serenity.Services/IUndeleteHandler-3.md) | Interface for undelete request handlers with custom undelete request / response types. |
| interface  | [IUndeleteRequestHandler](Serenity.Services/IUndeleteRequestHandler.md) | Represents a UndeleteRequestHandler. Is used with UndeleteBehavior objects. |
| interface  | [IUndeleteRequestProcessor](Serenity.Services/IUndeleteRequestProcessor.md) | Abstraction for undelete request handlers with a Process method. |
| interface  | [IUpdateHandler&lt;TRow&gt;](Serenity.Services/IUpdateHandler-1.md) | Interface for update request handlers |
| interface  | [IUpdateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/IUpdateHandler-3.md) | Interface for update request handlers with custom request / response types. |
| class  | [JsonServiceClient](Serenity.Services/JsonServiceClient.md) | A JSON service client implementation |
| class  | [JsonSortByConverter](Serenity.Services/JsonSortByConverter.md) | Serialize/deserialize a SortBy object as string |
| class  | [LinkingSetRelationBehavior](Serenity.Services/LinkingSetRelationBehavior.md) | Behavior class that handles [`LinkingSetRelationAttribute`](Serenity.Data.Mapping/LinkingSetRelationAttribute.md) |
| class  | [ListRequest](Serenity.Services/ListRequest.md) | The request model for a List service. |
| class  | [ListRequestHandler&lt;TRow&gt;](Serenity.Services/ListRequestHandler-1.md) | Base generic class for list request handlers that use [`ListRequest`](Serenity.Services/ListRequest.md) as the request type, and [`ListResponse`](Serenity.Services/ListResponse-1.md) as the response type. |
| class  | [ListRequestHandler&lt;TRow,TListRequest&gt;](Serenity.Services/ListRequestHandler-2.md) | Base generic class for list request handlers that use a custom list request as the request type, and [`ListResponse`](Serenity.Services/ListResponse-1.md) as the response type. |
| class  | [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](Serenity.Services/ListRequestHandler-3.md) | Generic base class for list request handlers |
| class  | [ListResponse&lt;T&gt;](Serenity.Services/ListResponse-1.md) | The response model for a list service. |
| class  | [LocalizationBehavior](Serenity.Services/LocalizationBehavior.md) | Behavior for handling localizable rows / properties |
| class  | [MasterDetailRelationBehavior](Serenity.Services/MasterDetailRelationBehavior.md) | Behavior class that handles [`MasterDetailRelationAttribute`](Serenity.Data.Mapping/MasterDetailRelationAttribute.md) |
| static class  | [RequestHandlerExtensions](Serenity.Services/RequestHandlerExtensions.md) | Contains extension methods to create request / response types for a request handler instance |
| enum  | [RetrieveColumnSelection](Serenity.Services/RetrieveColumnSelection.md) | The group of columns to retrieve |
| class  | [RetrieveRequest](Serenity.Services/RetrieveRequest.md) | The request model for a Retrieve service |
| class  | [RetrieveRequestHandler&lt;TRow&gt;](Serenity.Services/RetrieveRequestHandler-1.md) | Base generic class for retrieve request handlers that use [`RetrieveRequest`](Serenity.Services/RetrieveRequest.md) as the request type, and [`RetrieveResponse`](Serenity.Services/RetrieveResponse-1.md) as the response type. |
| class  | [RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](Serenity.Services/RetrieveRequestHandler-3.md) | Generic base class for retrieve request handlers |
| class  | [RetrieveResponse&lt;T&gt;](Serenity.Services/RetrieveResponse-1.md) | The service response model for a Retrieve service |
| class  | [RowValidationContext](Serenity.Services/RowValidationContext.md) | A validation context for rows |
| class  | [SaveRequest&lt;TEntity&gt;](Serenity.Services/SaveRequest-1.md) | The service model for a Save (Create / Update) service. |
| class  | [SaveRequestHandler&lt;TRow&gt;](Serenity.Services/SaveRequestHandler-1.md) | Base generic class for save request handlers that use [`SaveRequest`](Serenity.Services/SaveRequest-1.md) as the request type, and [`SaveResponse`](Serenity.Services/SaveResponse.md) as the response type. |
| class  | [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/SaveRequestHandler-3.md) | Generic base class for save request handlers |
| enum  | [SaveRequestType](Serenity.Services/SaveRequestType.md) | Save request type for save request processors |
| class  | [SaveResponse](Serenity.Services/SaveResponse.md) | The response model for a Save service |
| class  | [ServiceError](Serenity.Services/ServiceError.md) | The error object model returned from a service |
| static class  | [ServiceHelper](Serenity.Services/ServiceHelper.md) | Contains some helper methods for service handlers |
| static class  | [ServiceQueryHelper](Serenity.Services/ServiceQueryHelper.md) | Contains static helper methods for service handler queries. |
| class  | [ServiceRequest](Serenity.Services/ServiceRequest.md) | The base request object model for all service requests. Your custom request objects should all derive from this type. |
| class  | [ServiceResponse](Serenity.Services/ServiceResponse.md) | The base service response object model for all service response types. Your custom response objects should derive from this class. |
| class  | [SortBy](Serenity.Services/SortBy.md) | A sort column. In JSON this is deserialized from strings in the format "field" or "field desc" |
| static class  | [TreeOrdering](Serenity.Services/TreeOrdering.md) | Tree based sorting helper. E.g. in a tree, a node's parents should come before itself. Such an ordering is not easy in SQL so we use this helper to do ordering client side. |
| static class  | [TwoLevelCacheInvalidationExtensions](Serenity.Services/TwoLevelCacheInvalidationExtensions.md) | Contains helper methods for two level cache invalidation |
| class  | [UndeleteRequest](Serenity.Services/UndeleteRequest.md) | The request model for an undelete service |
| class  | [UndeleteRequestHandler&lt;TRow&gt;](Serenity.Services/UndeleteRequestHandler-1.md) | Base generic class for undelete request handlers that use [`UndeleteRequest`](Serenity.Services/UndeleteRequest.md) as the request type, and [`UndeleteResponse`](Serenity.Services/UndeleteResponse.md) as the response type. |
| class  | [UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](Serenity.Services/UndeleteRequestHandler-3.md) | Generic base class for undelete request handlers |
| class  | [UndeleteResponse](Serenity.Services/UndeleteResponse.md) | The response model for an undelete service |
| class  | [UniqueConstraintSaveBehavior](Serenity.Services/UniqueConstraintSaveBehavior.md) | Behavior that handles [`UniqueConstraintAttribute`](Serenity.Data.Mapping/UniqueConstraintAttribute.md) |
| class  | [UniqueFieldSaveBehavior](Serenity.Services/UniqueFieldSaveBehavior.md) | Interface that handles [`UniqueConstraintAttribute`](Serenity.Data.Mapping/UniqueConstraintAttribute.md) on fields |
| class  | [UpdatableExtensionBehavior](Serenity.Services/UpdatableExtensionBehavior.md) | Behavior that handles [`UpdatableExtensionAttribute`](Serenity.Data.Mapping/UpdatableExtensionAttribute.md) |
| class  | [UpdateInsertLogBehavior](Serenity.Services/UpdateInsertLogBehavior.md) | Behavior class that handles assignment of relevant fields for rows with [`IInsertLogRow`](Serenity.Data/IInsertLogRow.md) and [`IUpdateLogRow`](Serenity.Data/IUpdateLogRow.md) interfaces |
| class  | [UploadedFile](Serenity.Services/UploadedFile.md) | Uploaded file item which is used by multiple upload editors to store file information in a string field as JSON array. |
| class  | [ValidateParentBehavior](Serenity.Services/ValidateParentBehavior.md) | Validation behavior for rows that have a parent record via [`IParentIdRow`](Serenity.Data/IParentIdRow.md) interface |

## Serenity.Web namespace

| signature | name | description |
| --: | --- | --- |
| class  | [ColumnsScript](Serenity.Web/ColumnsScript.md) | Dynamic script type for columns (ColumnsScriptAttribute) |
| class  | [CombinedUploadStorage](Serenity.Web/CombinedUploadStorage.md) | A combined upload storage implementation that uses two upload storage instances, while serving one of them from a sub path like "/temporary/" |
| class  | [ConcatenatedScript](Serenity.Web/ConcatenatedScript.md) | A dynamic script that is formed from concatenation of other scripts |
| class  | [CopyTemporaryFileOptions](Serenity.Web/CopyTemporaryFileOptions.md) | Options for copying a temporary file to its target |
| class  | [CopyTemporaryFileResult](Serenity.Web/CopyTemporaryFileResult.md) | Result of the copying of a temporary file to its target |
| abstract class  | [DataScript&lt;TData&gt;](Serenity.Web/DataScript-1.md) | Generic subclass of the [`DataScript`](Serenity.Web/DataScript.md) |
| class  | [DataScript](Serenity.Web/DataScript.md) | Dynamic script that contains remote data |
| class  | [DefaultImageProcessor](Serenity.Web/DefaultImageProcessor.md) | Default implementation for the [`IImageProcessor`](Serenity.Web/IImageProcessor.md) |
| class  | [DefaultUploadProcessor](Serenity.Web/DefaultUploadProcessor.md) | Default implementation for [`IUploadProcessor`](Serenity.Web/IUploadProcessor.md) |
| class  | [DefaultUploadValidator](Serenity.Web/DefaultUploadValidator.md) | Default implementation for [`IUploadValidator`](Serenity.Web/IUploadValidator.md) |
| class  | [DiskUploadStorage](Serenity.Web/DiskUploadStorage.md) | A file system based upload storage implementation |
| class  | [DiskUploadStorageOptions](Serenity.Web/DiskUploadStorageOptions.md) | Options for [`DiskUploadStorage`](Serenity.Web/DiskUploadStorage.md) |
| abstract class  | [DynamicScript](Serenity.Web/DynamicScript.md) | Base abstract implementation for IDynamicScript |
| static class  | [FileMetadataKeys](Serenity.Web/FileMetadataKeys.md) | Contains file metadata key constants |
| class  | [FilesToDelete](Serenity.Web/FilesToDelete.md) | A container that stores list of file paths to delete (old files) if the upload related operation is successful. If it is not, the old files will be kept while the new files will be deleted. |
| static class  | [FilesToDeleteExtensions](Serenity.Web/FilesToDeleteExtensions.md) | Extension methods for [`FilesToDelete`](Serenity.Web/FilesToDelete.md) |
| static class  | [FileUploadTexts](Serenity.Web/FileUploadTexts.md) |  |
| class  | [FormatFilenameOptions](Serenity.Web/FormatFilenameOptions.md) | Options for formatting a file name |
| class  | [FormScript](Serenity.Web/FormScript.md) | Dynamic script type for forms (FormScriptAttribute) |
| interface  | [IDiskUploadFileSystem](Serenity.Web/IDiskUploadFileSystem.md) | Extension for IFileSystem with disk upload storage specific methods. |
| interface  | [IFilesToDelete](Serenity.Web/IFilesToDelete.md) | Interface for a files to delete container ([`FilesToDelete`](Serenity.Web/FilesToDelete.md)) |
| interface  | [IImageProcessor](Serenity.Web/IImageProcessor.md) | Image processor abstraction |
| class  | [ImageChecker](Serenity.Web/ImageChecker.md) | Checks stream data if valid image file and validate required conditions. |
| enum  | [ImageCheckResult](Serenity.Web/ImageCheckResult.md) | [`ImageChecker`](Serenity.Web/ImageChecker.md)'s result codes. |
| static class  | [ImageCheckResultTexts](Serenity.Web/ImageCheckResultTexts.md) |  |
| class  | [ImageEncoderParams](Serenity.Web/ImageEncoderParams.md) | Parameters for image encoding. Currently only contains a JPEG quality parameter. |
| class  | [ImageFormatInfo](Serenity.Web/ImageFormatInfo.md) | Information about an image format |
| interface  | [IUploadAVScanner](Serenity.Web/IUploadAVScanner.md) | Abstraction for an upload antivirus scanner, which scans temporary uploads before getting processed |
| interface  | [IUploadProcessor](Serenity.Web/IUploadProcessor.md) | Abstraction for an upload processor, which handles temporary uploads |
| interface  | [IUploadStorage](Serenity.Web/IUploadStorage.md) | Abstraction for an upload storage |
| interface  | [IUploadValidator](Serenity.Web/IUploadValidator.md) | An upload validator abstraction for checking IUploadFileConstraints and IUploadImageContrains |
| enum  | [OverwriteOption](Serenity.Web/OverwriteOption.md) | Enum that contains what to do when a file at desired path exists |
| class  | [PhysicalDiskUploadFileSystem](Serenity.Web/PhysicalDiskUploadFileSystem.md) | Implementation of the [`IDiskUploadFileSystem`](Serenity.Web/IDiskUploadFileSystem.md) |
| class  | [ProcessedUploadInfo](Serenity.Web/ProcessedUploadInfo.md) | Information about a processed temporary upload |
| abstract class  | [PropertyItemsScript](Serenity.Web/PropertyItemsScript.md) | Abstract base class for [`ColumnsScript`](Serenity.Web/ColumnsScript.md) and [`FormScript`](Serenity.Web/FormScript.md) |
| class  | [TempUploadStorage](Serenity.Web/TempUploadStorage.md) | A subclass of [`DiskUploadStorage`](Serenity.Web/DiskUploadStorage.md) specialized for the temporary upload folder, allowing to purge temporary files |
| static class  | [ThumbnailGenerator](Serenity.Web/ThumbnailGenerator.md) | Static class that contains thumbnail generator methods |
| static class  | [UploadFormatting](Serenity.Web/UploadFormatting.md) | Contains helper methods for upload file name formatting |
| static class  | [UploadPathHelper](Serenity.Web/UploadPathHelper.md) | Contains helper functions for upload paths |
| class  | [UploadSettings](Serenity.Web/UploadSettings.md) | Upload settings |
| static class  | [UploadStorageExtensions](Serenity.Web/UploadStorageExtensions.md) | Extension methods for [`IUploadStorage`](Serenity.Web/IUploadStorage.md) and related classes |