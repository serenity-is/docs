# Serenity.Net.Entity assembly

## Serenity.Data namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [AliasedFields](Serenity.Data/AliasedFields.md) | Contains extension method to create aliased fields |
| class  | [BooleanField](Serenity.Data/BooleanField.md) | Field with boolean value |
| class  | [ByteArrayField](Serenity.Data/ByteArrayField.md) | Field with a byte[] value |
| class  | [CustomClassField&lt;TValue&gt;](Serenity.Data/CustomClassField-1.md) | Base class for custom fields with reference type values |
| class  | [DateTimeField](Serenity.Data/DateTimeField.md) | Field with a DateTime value |
| class  | [DateTimeOffsetField](Serenity.Data/DateTimeOffsetField.md) | Field with a DateTimeOffset value |
| class  | [DecimalField](Serenity.Data/DecimalField.md) | Field with a Decimal value |
| class  | [DefaultRowFieldsProvider](Serenity.Data/DefaultRowFieldsProvider.md) | Default row fields instance provider, that resolves row fields instances using ActivatorUtilities.CreateInstance through a IServiceProvider. |
| class  | [DefaultRowTypeRegistry](Serenity.Data/DefaultRowTypeRegistry.md) | Default row type registry |
| class  | [DialectExpressionSelector](Serenity.Data/DialectExpressionSelector.md) | Selects field expressions based on dialect |
| class  | [DoubleField](Serenity.Data/DoubleField.md) | Field with a Double value |
| static class  | [EntityConnectionExtensions](Serenity.Data/EntityConnectionExtensions.md) | Contains extension methods to perform entity CRUD operations directly on connections. Please note that all these methods operate on a low level, and none of them call service behaviors or performs service validations. |
| static class  | [EntityFieldExtensions](Serenity.Data/EntityFieldExtensions.md) | Contains static extension methods for Field objects. |
| static class  | [EntityQueryExtensions](Serenity.Data/EntityQueryExtensions.md) | Extensions for objects implementing IDbWhere interface. |
| static class  | [EntitySqlHelper](Serenity.Data/EntitySqlHelper.md) | Contains extension methods to query entities directly |
| static class  | [EntitySqlQueryExtensions](Serenity.Data/EntitySqlQueryExtensions.md) | Extensions for SqlQuery. |
| class  | [EnumField&lt;TEnum&gt;](Serenity.Data/EnumField-1.md) | Field with an Enum value |
| class  | [FallbackRowFieldsProvider](Serenity.Data/FallbackRowFieldsProvider.md) | Fallback row fields provider for cases where a IServiceProvider is not available. |
| abstract class  | [Field](Serenity.Data/Field.md) | Base Field class |
| enum  | [FieldType](Serenity.Data/FieldType.md) | Enumeration of field types |
| abstract class  | [GenericClassField&lt;TValue&gt;](Serenity.Data/GenericClassField-1.md) | Base class for fields with reference type values |
| abstract class  | [GenericField&lt;TValue&gt;](Serenity.Data/GenericField-1.md) | Base generic class for fields with a value |
| abstract class  | [GenericValueField&lt;TValue&gt;](Serenity.Data/GenericValueField-1.md) | Base class for fields with a value type value |
| class  | [GuidField](Serenity.Data/GuidField.md) | Field with a Guid value |
| interface  | [IDeleteLogRow](Serenity.Data/IDeleteLogRow.md) | Interface for rows that have DeleteUserId and DeleteDate fields. |
| interface  | [IDisplayOrderRow](Serenity.Data/IDisplayOrderRow.md) | Basic interface for rows that has a display order field and provides a default sorting order. |
| interface  | [IEntity](Serenity.Data/IEntity.md) | An interface for entities with Table property |
| interface  | [IEntityWithJoins](Serenity.Data/IEntityWithJoins.md) | Interface for an entity with join information |
| interface  | [IEnumTypeField](Serenity.Data/IEnumTypeField.md) | Interface for fields with an enum type property |
| interface  | [IFieldWithJoinInfo](Serenity.Data/IFieldWithJoinInfo.md) | Interface for a field with join and referenced join alias information |
| interface  | [IIdRow](Serenity.Data/IIdRow.md) | Basic interface for rows that has an ID field. You should put [IdProperty] attribute to corresponding field. |
| interface  | [IInsertLogRow](Serenity.Data/IInsertLogRow.md) | Interface for rows that have InsertUserId and InsertDate fields |
| interface  | [IIsActiveDeletedRow](Serenity.Data/IIsActiveDeletedRow.md) | Marks an IIsActiveRow that -1 is used as deleted value |
| interface  | [IIsActiveRow](Serenity.Data/IIsActiveRow.md) | Interface for an entity with active field |
| interface  | [IIsDeletedRow](Serenity.Data/IIsDeletedRow.md) | Determines that this row uses soft delete and the field that holds this flag |
| interface  | [ILoggingRow](Serenity.Data/ILoggingRow.md) | A combination of IUpdateLogRow and IInsertLogRow |
| interface  | [INameRow](Serenity.Data/INameRow.md) | Marks a row as having a Name field (e.g. description for row). You should put [NameProperty] attribute to corresponding field |
| class  | [Int16Field](Serenity.Data/Int16Field.md) | Field with Int16 value |
| class  | [Int32Field](Serenity.Data/Int32Field.md) | Field with Int32 value |
| class  | [Int64Field](Serenity.Data/Int64Field.md) | Field with Int64 value |
| interface  | [IParentIdRow](Serenity.Data/IParentIdRow.md) | Interface for rows that has a ParentId field |
| interface  | [IRow&lt;TFields&gt;](Serenity.Data/IRow-1.md) | Base interface for Rows with a known Fields type |
| interface  | [IRow](Serenity.Data/IRow.md) | Row interface |
| interface  | [IRowFieldsProvider](Serenity.Data/IRowFieldsProvider.md) | Abstraction for row fields instance providers |
| interface  | [IRowTypeRegistry](Serenity.Data/IRowTypeRegistry.md) | Abstraction for row type registry. |
| interface  | [IUpdateLogRow](Serenity.Data/IUpdateLogRow.md) | Interface for rows that has a UpdateUserId and UpdateDate fields |
| class  | [JsonField&lt;TValue&gt;](Serenity.Data/JsonField-1.md) | Field with JSON value |
| class  | [JsonRowConverter](Serenity.Data/JsonRowConverter.md) | Serialize/deserialize a row |
| class  | [ListField&lt;TItem&gt;](Serenity.Data/ListField-1.md) | Field with a list value |
| abstract class  | [Row&lt;TFields&gt;](Serenity.Data/Row-1.md) | Base class for Serenity entities |
| static class  | [RowExtensions](Serenity.Data/RowExtensions.md) | Contains extensions for row objects |
| class  | [RowField&lt;TForeign&gt;](Serenity.Data/RowField-1.md) | Field with a Row value |
| class  | [RowFieldsBase](Serenity.Data/RowFieldsBase.md) | Base class for row fields collection |
| static class  | [RowFieldsProvider](Serenity.Data/RowFieldsProvider.md) | Contains extension methods and settings for row fields providers |
| class  | [RowListField&lt;TForeign&gt;](Serenity.Data/RowListField-1.md) | Field with a RowList value |
| class  | [SingleField](Serenity.Data/SingleField.md) | Field with a Single value |
| class  | [StreamField](Serenity.Data/StreamField.md) | Field with a Stream value |
| class  | [StringField](Serenity.Data/StringField.md) | Field with a String value |
| class  | [TimeSpanField](Serenity.Data/TimeSpanField.md) | Field with a TimeSpan value |
| class  | [VariantField](Serenity.Data/VariantField.md) | Field with a Variant (e.g. SQL VARIANT) value |

## Serenity.Extensions.DependencyInjection namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [EntityServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/EntityServiceCollectionExtensions.md) | Contains extensions to register entity services |

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
| class  | [PropertyInfoSource](Serenity.PropertyGrid/PropertyInfoSource.md) | Property info source for a reflection PropertyInfo object |
| abstract class  | [PropertyProcessor](Serenity.PropertyGrid/PropertyProcessor.md) | Base class for property processors, which sets properties of a PropertyItem object by analysing a IPropertySource object. |

## Serenity.Services namespace

| signature | name | description |
| --: | --- | --- |
| class  | [RowValidationContext](Serenity.Services/RowValidationContext.md) | A validation context for rows |