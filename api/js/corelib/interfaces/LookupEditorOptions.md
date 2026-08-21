[@serenity-is/corelib](../README.md) / LookupEditorOptions

# Interface: LookupEditorOptions

Defined in: [src/ui/editors/lookupeditor.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L11)

Options for the [LookupEditor](../classes/LookupEditor.md).

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

### async?

> `optional` **async**: `boolean`

Defined in: [src/ui/editors/lookupeditor.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L15)

Whether items are loaded asynchronously.

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

### lookupKey?

> `optional` **lookupKey**: `string`

Defined in: [src/ui/editors/lookupeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L13)

Key of the lookup to load items from.

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L23)

Minimum results required to show the search box.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`minimumResultsForSearch`](ComboboxEditorOptions.md#minimumresultsforsearch)

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L25)

Whether multiple items can be selected.

#### Inherited from

[`ComboboxEditorOptions`](ComboboxEditorOptions.md).[`multiple`](ComboboxEditorOptions.md#multiple)
