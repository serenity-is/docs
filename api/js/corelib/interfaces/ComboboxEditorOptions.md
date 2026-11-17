[@serenity-is/corelib](../README.md) / ComboboxEditorOptions

# Interface: ComboboxEditorOptions

Defined in: [src/ui/editors/comboboxeditor.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L65)

Options for the [ComboboxEditor](../classes/ComboboxEditor.md).

## Extends

- [`ComboboxFilterOptions`](ComboboxFilterOptions.md).[`ComboboxInplaceAddOptions`](ComboboxInplaceAddOptions.md).[`ComboboxCommonOptions`](ComboboxCommonOptions.md)

## Extended by

- [`LookupEditorOptions`](LookupEditorOptions.md)
- [`ServiceLookupEditorOptions`](ServiceLookupEditorOptions.md)

## Properties

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L19)

Whether the selection can be cleared.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`allowClear`](ComboboxCommonOptions.md#allowclear)

***

### autoComplete?

> `optional` **autoComplete**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L57)

Whether arbitrary values are allowed.

#### Inherited from

[`ComboboxInplaceAddOptions`](ComboboxInplaceAddOptions.md).[`autoComplete`](ComboboxInplaceAddOptions.md#autocomplete)

***

### cascadeField?

> `optional` **cascadeField**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L37)

Field used for cascading.

#### Inherited from

[`ComboboxFilterOptions`](ComboboxFilterOptions.md).[`cascadeField`](ComboboxFilterOptions.md#cascadefield)

***

### cascadeFrom?

> `optional` **cascadeFrom**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L35)

Id of the parent editor to cascade from.

#### Inherited from

[`ComboboxFilterOptions`](ComboboxFilterOptions.md).[`cascadeFrom`](ComboboxFilterOptions.md#cascadefrom)

***

### cascadeValue?

> `optional` **cascadeValue**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L39)

Value used for cascading.

#### Inherited from

[`ComboboxFilterOptions`](ComboboxFilterOptions.md).[`cascadeValue`](ComboboxFilterOptions.md#cascadevalue)

***

### delimited?

> `optional` **delimited**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L21)

Whether multiple items can be selected.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`delimited`](ComboboxCommonOptions.md#delimited)

***

### dialogType?

> `optional` **dialogType**: `string` \| [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Defined in: [src/ui/editors/comboboxeditor.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L55)

Dialog type used for in-place add.

#### Inherited from

[`ComboboxInplaceAddOptions`](ComboboxInplaceAddOptions.md).[`dialogType`](ComboboxInplaceAddOptions.md#dialogtype)

***

### filterField?

> `optional` **filterField**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L41)

Field used for filtering.

#### Inherited from

[`ComboboxFilterOptions`](ComboboxFilterOptions.md).[`filterField`](ComboboxFilterOptions.md#filterfield)

***

### filterValue?

> `optional` **filterValue**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L43)

Value used for filtering.

#### Inherited from

[`ComboboxFilterOptions`](ComboboxFilterOptions.md).[`filterValue`](ComboboxFilterOptions.md#filtervalue)

***

### iconField?

> `optional` **iconField**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L27)

Name of the item field containing the icon class.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`iconField`](ComboboxCommonOptions.md#iconfield)

***

### inplaceAdd?

> `optional` **inplaceAdd**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L51)

Whether in-place add is enabled.

#### Inherited from

[`ComboboxInplaceAddOptions`](ComboboxInplaceAddOptions.md).[`inplaceAdd`](ComboboxInplaceAddOptions.md#inplaceadd)

***

### inplaceAddPermission?

> `optional` **inplaceAddPermission**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L53)

Permission required for in-place add.

#### Inherited from

[`ComboboxInplaceAddOptions`](ComboboxInplaceAddOptions.md).[`inplaceAddPermission`](ComboboxInplaceAddOptions.md#inplaceaddpermission)

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L23)

Minimum results required to show the search box.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`minimumResultsForSearch`](ComboboxCommonOptions.md#minimumresultsforsearch)

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L25)

Whether multiple items can be selected.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`multiple`](ComboboxCommonOptions.md#multiple)

***

### openDialogAsPanel?

> `optional` **openDialogAsPanel**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L59)

Whether the in-place add dialog opens as a panel.

#### Inherited from

[`ComboboxInplaceAddOptions`](ComboboxInplaceAddOptions.md).[`openDialogAsPanel`](ComboboxInplaceAddOptions.md#opendialogaspanel)
