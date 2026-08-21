[@serenity-is/corelib](../README.md) / ServiceLookupEditorOptions

# Interface: ServiceLookupEditorOptions

Defined in: [src/ui/editors/servicelookupeditor.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L9)

Options for the [ServiceLookupEditor](../classes/ServiceLookupEditor.md).

## Extends

- [`ComboboxEditorOptions`](ComboboxEditorOptions.md)

## Properties

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L19)

Whether the selection can be cleared.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`allowClear`](ComboboxEditorOptions.md#allowclear)

***

### autoComplete?

> `optional` **autoComplete**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L55)

Whether arbitrary values are allowed.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`autoComplete`](ComboboxEditorOptions.md#autocomplete)

***

### cascadeField?

> `optional` **cascadeField**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L35)

Field used for cascading.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`cascadeField`](ComboboxEditorOptions.md#cascadefield)

***

### cascadeFrom?

> `optional` **cascadeFrom**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L33)

Id of the parent editor to cascade from.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`cascadeFrom`](ComboboxEditorOptions.md#cascadefrom)

***

### cascadeValue?

> `optional` **cascadeValue**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L37)

Value used for cascading.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`cascadeValue`](ComboboxEditorOptions.md#cascadevalue)

***

### columnSelection?

> `optional` **columnSelection**: [`ColumnSelection`](../enumerations/ColumnSelection.md)

Defined in: [src/ui/editors/servicelookupeditor.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L23)

Column selection mode.

***

### containsField?

> `optional` **containsField**: `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L31)

Field used for contains-text search.

***

### criteria?

> `optional` **criteria**: `any`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L35)

Criteria applied to the request.

***

### delimited?

> `optional` **delimited**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L21)

Whether multiple items can be selected.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`delimited`](ComboboxEditorOptions.md#delimited)

***

### dialogType?

> `optional` **dialogType**: `string` \| [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Defined in: [src/ui/editors/comboboxeditor.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L53)

Dialog type used for in-place add.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`dialogType`](ComboboxEditorOptions.md#dialogtype)

***

### equalityFilter?

> `optional` **equalityFilter**: `any`

Defined in: [src/ui/editors/servicelookupeditor.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L33)

Equality filter applied to the request.

***

### excludeColumns?

> `optional` **excludeColumns**: `string`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L27)

Columns to exclude.

***

### filterField?

> `optional` **filterField**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L39)

Field used for filtering.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`filterField`](ComboboxEditorOptions.md#filterfield)

***

### filterValue?

> `optional` **filterValue**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L41)

Value used for filtering.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`filterValue`](ComboboxEditorOptions.md#filtervalue)

***

### idField?

> `optional` **idField**: `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L13)

Id field name.

***

### includeColumns?

> `optional` **includeColumns**: `string`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L25)

Columns to include.

***

### includeDeleted?

> `optional` **includeDeleted**: `boolean`

Defined in: [src/ui/editors/servicelookupeditor.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L29)

Whether to include deleted rows.

***

### inplaceAdd?

> `optional` **inplaceAdd**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L49)

Whether in-place add is enabled.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`inplaceAdd`](ComboboxEditorOptions.md#inplaceadd)

***

### inplaceAddPermission?

> `optional` **inplaceAddPermission**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L51)

Permission required for in-place add.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`inplaceAddPermission`](ComboboxEditorOptions.md#inplaceaddpermission)

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `any`

Defined in: [src/ui/editors/servicelookupeditor.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L19)

Minimum results required to show the search box.

#### Overrides

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`minimumResultsForSearch`](ComboboxEditorOptions.md#minimumresultsforsearch)

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L25)

Whether multiple items can be selected.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`multiple`](ComboboxEditorOptions.md#multiple)

***

### pageSize?

> `optional` **pageSize**: `number`

Defined in: [src/ui/editors/servicelookupeditor.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L17)

Page size for paged searches.

***

### service?

> `optional` **service**: `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L11)

Service endpoint to load items from.

***

### sort?

> `optional` **sort**: `string`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L21)

Sort order for results.

***

### textField?

> `optional` **textField**: `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L15)

Text field name.
