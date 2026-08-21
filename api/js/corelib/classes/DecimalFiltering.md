[@serenity-is/corelib](../README.md) / DecimalFiltering

# Class: DecimalFiltering

Defined in: [src/ui/filtering/decimalfiltering.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/decimalfiltering.ts#L9)

Filtering handler for decimal fields using a decimal editor.

## Extends

- [`BaseEditorFiltering`](BaseEditorFiltering.md)\<[`DecimalEditor`](DecimalEditor.md)\>

## Constructors

### Constructor

> **new DecimalFiltering**(): `DecimalFiltering`

Defined in: [src/ui/filtering/decimalfiltering.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/decimalfiltering.ts#L15)

Creates a decimal filtering handler.

#### Returns

`DecimalFiltering`

#### Overrides

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`constructor`](BaseEditorFiltering.md#constructor)

## Properties

### editor

> `protected` **editor**: [`DecimalEditor`](DecimalEditor.md)

Defined in: [src/ui/filtering/baseeditorfiltering.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L39)

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`editor`](BaseEditorFiltering.md#editor)

***

### editorTypeRef

> **editorTypeRef**: `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L18)

Constructor of the editor widget type.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`editorTypeRef`](BaseEditorFiltering.md#editortyperef)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/decimalfiltering.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/decimalfiltering.ts#L10)

#### Overrides

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`[typeInfo]`](BaseEditorFiltering.md#typeinfo)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`appendComparisonOperators`](BaseEditorFiltering.md#appendcomparisonoperators)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`appendNullableOperators`](BaseEditorFiltering.md#appendnullableoperators)

***

### argumentNull()

> `protected` **argumentNull**(): `Error`

Defined in: [src/ui/filtering/basefiltering.ts:287](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L287)

Returns the error thrown when a required value is missing.

#### Returns

`Error`

The error.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`argumentNull`](BaseEditorFiltering.md#argumentnull)

***

### createEditor()

> **createEditor**(): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L44)

Creates the editor for the current operator.

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`createEditor`](BaseEditorFiltering.md#createeditor)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`displayText`](BaseEditorFiltering.md#displaytext)

***

### get\_container()

> **get\_container**(): `HTMLElement`

Defined in: [src/ui/filtering/basefiltering.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L41)

Returns the container element for the editor.

#### Returns

`HTMLElement`

The container element.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`get_container`](BaseEditorFiltering.md#get_container)

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/filtering/basefiltering.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L23)

Returns the field being filtered.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

The field.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`get_field`](BaseEditorFiltering.md#get_field)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

Defined in: [src/ui/filtering/basefiltering.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L59)

Returns the current operator.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

The operator.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`get_operator`](BaseEditorFiltering.md#get_operator)

***

### getCriteria()

> **getCriteria**(): `CriteriaWithText`

Defined in: [src/ui/filtering/basefiltering.ts:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L192)

Returns the criteria and display text for the current operator.

#### Returns

`CriteriaWithText`

The criteria with display text.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getCriteria`](BaseEditorFiltering.md#getcriteria)

***

### getCriteriaField()

> **getCriteriaField**(): `string`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L70)

Returns the criteria field name, using the filtering id field when applicable.

#### Returns

`string`

The criteria field name.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getCriteriaField`](BaseEditorFiltering.md#getcriteriafield)

***

### getEditorOptions()

> **getEditorOptions**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L84)

Returns the options for the editor widget.

#### Returns

`any`

The editor options.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getEditorOptions`](BaseEditorFiltering.md#geteditoroptions)

***

### getEditorText()

> **getEditorText**(): `string`

Defined in: [src/ui/filtering/basefiltering.ts:333](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L333)

Returns the display text of the current editor value.

#### Returns

`string`

The editor text.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getEditorText`](BaseEditorFiltering.md#geteditortext)

***

### getEditorValue()

> **getEditorValue**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L124)

Returns the current editor value.

#### Returns

`any`

The editor value.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getEditorValue`](BaseEditorFiltering.md#geteditorvalue)

***

### getOperators()

> **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/decimalfiltering.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/decimalfiltering.ts#L23)

Returns the operators supported by this filtering handler.

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

The operators.

#### Overrides

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getOperators`](BaseEditorFiltering.md#getoperators)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`getTitle`](BaseEditorFiltering.md#gettitle)

***

### initQuickFilter()

> **initQuickFilter**(`filter`): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L141)

Initializes a quick filter using the editor type.

#### Parameters

##### filter

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>

The quick filter to initialize.

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`initQuickFilter`](BaseEditorFiltering.md#initquickfilter)

***

### isNullable()

> `protected` **isNullable**(): `boolean`

Defined in: [src/ui/filtering/basefiltering.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/basefiltering.ts#L110)

Whether the field is nullable.

#### Returns

`boolean`

True when the field is not required.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`isNullable`](BaseEditorFiltering.md#isnullable)

***

### loadState()

> **loadState**(`state`): `void`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L95)

Loads persisted state into the editor.

#### Parameters

##### state

`any`

The persisted state.

#### Returns

`void`

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`loadState`](BaseEditorFiltering.md#loadstate)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`operatorFormat`](BaseEditorFiltering.md#operatorformat)

***

### saveState()

> **saveState**(): `any`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L112)

Saves the editor state for persistence.

#### Returns

`any`

The saved state.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`saveState`](BaseEditorFiltering.md#savestate)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`set_container`](BaseEditorFiltering.md#set_container)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`set_field`](BaseEditorFiltering.md#set_field)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`set_operator`](BaseEditorFiltering.md#set_operator)

***

### useEditor()

> `protected` **useEditor**(): `boolean`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L26)

Whether the current operator uses an editor.

#### Returns

`boolean`

True when an editor is used.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`useEditor`](BaseEditorFiltering.md#useeditor)

***

### useIdField()

> `protected` **useIdField**(): `boolean`

Defined in: [src/ui/filtering/baseeditorfiltering.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/baseeditorfiltering.ts#L62)

Whether to use the id field for the criteria.

#### Returns

`boolean`

True when the id field is used.

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`useIdField`](BaseEditorFiltering.md#useidfield)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`validateEditorValue`](BaseEditorFiltering.md#validateeditorvalue)

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

#### Inherited from

[`BaseEditorFiltering`](BaseEditorFiltering.md).[`registerClass`](BaseEditorFiltering.md#registerclass)
