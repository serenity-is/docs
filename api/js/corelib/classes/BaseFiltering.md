[@serenity-is/corelib](../README.md) / BaseFiltering

# Abstract Class: BaseFiltering

Defined in: [src/ui/filtering/basefiltering.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L15)

Base class for filtering handlers that build criteria and editors for a field.

## Extended by

- [`BaseEditorFiltering`](BaseEditorFiltering.md)
- [`BooleanFiltering`](BooleanFiltering.md)
- [`StringFiltering`](StringFiltering.md)

## Implements

- [`IFiltering`](IFiltering.md)
- [`IQuickFiltering`](IQuickFiltering.md)

## Constructors

### Constructor

> **new BaseFiltering**(): `BaseFiltering`

#### Returns

`BaseFiltering`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/basefiltering.ts:370](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L370)

#### Implementation of

[`IQuickFiltering`](IQuickFiltering.md).[`[typeInfo]`](IQuickFiltering.md#typeinfo)

## Methods

### appendComparisonOperators()

> `protected` **appendComparisonOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/basefiltering.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L96)

Appends the comparison operators (eq, ne, lt, le, gt, ge).

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operator list.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operator list.

***

### appendNullableOperators()

> `protected` **appendNullableOperators**(`list`): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/basefiltering.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L82)

Appends the is-null and is-not-null operators when the field is nullable.

#### Parameters

##### list

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operator list.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operator list.

***

### argumentNull()

> `protected` **argumentNull**(): `Error`

Defined in: [src/ui/filtering/basefiltering.ts:287](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L287)

Returns the error thrown when a required value is missing.

#### Returns

`Error`

The error.

***

### createEditor()

> **createEditor**(): `void`

Defined in: [src/ui/filtering/basefiltering.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L117)

Creates the editor for the current operator.

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`createEditor`](IFiltering.md#createeditor)

***

### displayText()

> `protected` **displayText**(`op`, `values?`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L168)

Builds the display text for an operator and its values.

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

The operator.

##### values?

`any`[]

The filter values.

#### Returns

`string`

The display text.

***

### get\_container()

> **get\_container**(): `HTMLElement`

Defined in: [src/ui/filtering/basefiltering.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L41)

Returns the container element for the editor.

#### Returns

`HTMLElement`

The container element.

#### Implementation of

[`IFiltering`](IFiltering.md).[`get_container`](IFiltering.md#get_container)

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/filtering/basefiltering.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L23)

Returns the field being filtered.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

The field.

#### Implementation of

[`IFiltering`](IFiltering.md).[`get_field`](IFiltering.md#get_field)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

Defined in: [src/ui/filtering/basefiltering.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L59)

Returns the current operator.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

The operator.

#### Implementation of

[`IFiltering`](IFiltering.md).[`get_operator`](IFiltering.md#get_operator)

***

### getCriteria()

> **getCriteria**(): `CriteriaWithText`

Defined in: [src/ui/filtering/basefiltering.ts:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L192)

Returns the criteria and display text for the current operator.

#### Returns

`CriteriaWithText`

The criteria with display text.

#### Implementation of

[`IFiltering`](IFiltering.md).[`getCriteria`](IFiltering.md#getcriteria)

***

### getCriteriaField()

> `protected` **getCriteriaField**(): `string`

Defined in: [src/ui/filtering/basefiltering.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L184)

Returns the criteria field name.

#### Returns

`string`

The field name.

***

### getEditorText()

> **getEditorText**(): `string`

Defined in: [src/ui/filtering/basefiltering.ts:333](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L333)

Returns the display text of the current editor value.

#### Returns

`string`

The editor text.

***

### getEditorValue()

> **getEditorValue**(): `string`

Defined in: [src/ui/filtering/basefiltering.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L307)

Returns the current editor value.

#### Returns

`string`

The editor value.

***

### getOperators()

> `abstract` **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/basefiltering.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L75)

Returns the operators supported by this filtering handler.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operators.

#### Implementation of

[`IFiltering`](IFiltering.md).[`getOperators`](IFiltering.md#getoperators)

***

### getTitle()

> `protected` **getTitle**(`field`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L158)

Returns the localized title of a field.

#### Parameters

##### field

[`PropertyItem`](../interfaces/PropertyItem.md)

The field.

#### Returns

`string`

The title.

***

### initQuickFilter()

> **initQuickFilter**(`filter`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:354](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L354)

Initializes a quick filter for this field.

#### Parameters

##### filter

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>

The quick filter to initialize.

#### Returns

`void`

#### Implementation of

[`IQuickFiltering`](IQuickFiltering.md).[`initQuickFilter`](IQuickFiltering.md#initquickfilter)

***

### isNullable()

> `protected` **isNullable**(): `boolean`

Defined in: [src/ui/filtering/basefiltering.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L110)

Whether the field is nullable.

#### Returns

`boolean`

True when the field is not required.

***

### loadState()

> **loadState**(`state`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L257)

Loads persisted state into the editor.

#### Parameters

##### state

`any`

The persisted state.

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`loadState`](IFiltering.md#loadstate)

***

### operatorFormat()

> `protected` **operatorFormat**(`op`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L149)

Returns the format string for an operator.

#### Parameters

##### op

[`FilterOperator`](../interfaces/FilterOperator.md)

The operator.

#### Returns

`string`

The format string.

***

### saveState()

> **saveState**(): `string`

Defined in: [src/ui/filtering/basefiltering.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L266)

Saves the editor state for persistence.

#### Returns

`string`

The saved state.

#### Implementation of

[`IFiltering`](IFiltering.md).[`saveState`](IFiltering.md#savestate)

***

### set\_container()

> **set\_container**(`value`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L49)

Sets the container element for the editor.

#### Parameters

##### value

`HTMLElement`

The container element.

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`set_container`](IFiltering.md#set_container)

***

### set\_field()

> **set\_field**(`value`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L31)

Sets the field being filtered.

#### Parameters

##### value

[`PropertyItem`](../interfaces/PropertyItem.md)

The field.

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`set_field`](IFiltering.md#set_field)

***

### set\_operator()

> **set\_operator**(`value`): `void`

Defined in: [src/ui/filtering/basefiltering.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L67)

Sets the current operator.

#### Parameters

##### value

[`FilterOperator`](../interfaces/FilterOperator.md)

The operator.

#### Returns

`void`

#### Implementation of

[`IFiltering`](IFiltering.md).[`set_operator`](IFiltering.md#set_operator)

***

### validateEditorValue()

> **validateEditorValue**(`value`): `string`

Defined in: [src/ui/filtering/basefiltering.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L296)

Validates the editor value.

#### Parameters

##### value

`string`

The value to validate.

#### Returns

`string`

The validated value.

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/filtering/basefiltering.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L361)

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>
