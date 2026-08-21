[@serenity-is/corelib](../README.md) / ComboboxInplaceAddOptions

# Interface: ComboboxInplaceAddOptions

Defined in: [src/ui/editors/comboboxeditor.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L47)

Options for in-place add functionality in combobox editors.

## Extended by

- [`ComboboxEditorOptions`](ComboboxEditorOptions.md)

## Properties

### autoComplete?

> `optional` **autoComplete**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L55)

Whether arbitrary values are allowed.

***

### dialogType?

> `optional` **dialogType**: `string` \| [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Defined in: [src/ui/editors/comboboxeditor.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L53)

Dialog type used for in-place add.

***

### inplaceAdd?

> `optional` **inplaceAdd**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L49)

Whether in-place add is enabled.

***

### inplaceAddPermission?

> `optional` **inplaceAddPermission**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L51)

Permission required for in-place add.
