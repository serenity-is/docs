[@serenity-is/corelib](../README.md) / ServiceLookupEditorOptions

# Interface: ServiceLookupEditorOptions

Defined in: [src/ui/editors/servicelookupeditor.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L10)

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

Defined in: [src/ui/editors/comboboxeditor.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L57)

Whether arbitrary values are allowed.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`autoComplete`](ComboboxEditorOptions.md#autocomplete)

***

### capabilities?

> `optional` **capabilities**: [`ListRequestCapabilities`](../enumerations/ListRequestCapabilities.md)

Defined in: [src/ui/editors/servicelookupeditor.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L32)

Supported ListRequest capabilities. When omitted, all standard properties are sent.

***

### cascadeField?

> `optional` **cascadeField**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L37)

Field used for cascading.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`cascadeField`](ComboboxEditorOptions.md#cascadefield)

***

### cascadeFrom?

> `optional` **cascadeFrom**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L35)

Id of the parent editor to cascade from.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`cascadeFrom`](ComboboxEditorOptions.md#cascadefrom)

***

### cascadeValue?

> `optional` **cascadeValue**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L39)

Value used for cascading.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`cascadeValue`](ComboboxEditorOptions.md#cascadevalue)

***

### columnSelection?

> `optional` **columnSelection**: [`ColumnSelection`](../enumerations/ColumnSelection.md)

Defined in: [src/ui/editors/servicelookupeditor.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L24)

Column selection mode.

***

### containsField?

> `optional` **containsField**: `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L40)

Field used for contains-text search.

***

### criteria?

> `optional` **criteria**: `any`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L44)

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

Defined in: [src/ui/editors/comboboxeditor.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L55)

Dialog type used for in-place add.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`dialogType`](ComboboxEditorOptions.md#dialogtype)

***

### equalityFilter?

> `optional` **equalityFilter**: `any`

Defined in: [src/ui/editors/servicelookupeditor.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L42)

Equality filter applied to the request.

***

### excludeColumns?

> `optional` **excludeColumns**: `string`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L28)

Columns to exclude.

***

### filterField?

> `optional` **filterField**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L41)

Field used for filtering.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`filterField`](ComboboxEditorOptions.md#filterfield)

***

### filterValue?

> `optional` **filterValue**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L43)

Value used for filtering.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`filterValue`](ComboboxEditorOptions.md#filtervalue)

***

### iconField?

> `optional` **iconField**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L27)

Name of the item field containing the icon class.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`iconField`](ComboboxEditorOptions.md#iconfield)

***

### idField?

> `optional` **idField**: `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L14)

Id field name.

***

### includeColumns?

> `optional` **includeColumns**: `string`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L26)

Columns to include.

***

### includeDeleted?

> `optional` **includeDeleted**: `boolean`

Defined in: [src/ui/editors/servicelookupeditor.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L30)

Whether to include deleted rows.

***

### inplaceAdd?

> `optional` **inplaceAdd**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L51)

Whether in-place add is enabled.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`inplaceAdd`](ComboboxEditorOptions.md#inplaceadd)

***

### inplaceAddPermission?

> `optional` **inplaceAddPermission**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L53)

Permission required for in-place add.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`inplaceAddPermission`](ComboboxEditorOptions.md#inplaceaddpermission)

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `any`

Defined in: [src/ui/editors/servicelookupeditor.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L20)

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

### openDialogAsPanel?

> `optional` **openDialogAsPanel**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L59)

Whether the in-place add dialog opens as a panel.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`openDialogAsPanel`](ComboboxEditorOptions.md#opendialogaspanel)

***

### pageSize?

> `optional` **pageSize**: `number`

Defined in: [src/ui/editors/servicelookupeditor.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L18)

Page size for paged searches.

***

### quickSearchFields?

> `optional` **quickSearchFields**: `string`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L38)

Additional fields searched by the client-side ContainsText fallback.
The editor's itemText output is always searched unless ContainsField is set.
This fallback cannot reproduce server-side QuickSearch behavior exactly.

***

### service?

> `optional` **service**: `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L12)

Service endpoint to load items from.

***

### sort?

> `optional` **sort**: `string`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L22)

Sort order for results.

***

### textField?

> `optional` **textField**: `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L16)

Text field name.
