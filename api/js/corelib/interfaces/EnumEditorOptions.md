[@serenity-is/corelib](../README.md) / EnumEditorOptions

# Interface: EnumEditorOptions

Defined in: [src/ui/editors/enumeditor.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L10)

Options for the [EnumEditor](../classes/EnumEditor.md).

## Extends

- [`ComboboxCommonOptions`](ComboboxCommonOptions.md)

## Properties

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L19)

Whether the selection can be cleared.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`allowClear`](ComboboxCommonOptions.md#allowclear)

***

### delimited?

> `optional` **delimited**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L21)

Whether multiple items can be selected.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`delimited`](ComboboxCommonOptions.md#delimited)

***

### enumKey?

> `optional` **enumKey**: `string`

Defined in: [src/ui/editors/enumeditor.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L12)

Key of the enum to load items from.

***

### enumType?

> `optional` **enumType**: `any`

Defined in: [src/ui/editors/enumeditor.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L14)

The enum type to load items from.

***

### flags?

> `optional` **flags**: `boolean`

Defined in: [src/ui/editors/enumeditor.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L21)

Whether the enum is a set of flags, like a [Flags] enum on the server side. Along with the multiple option, the value is a
number, the members selected OR-ed together, or null for none, and the members combining others, like SourceAdapter of the
list request capabilities, are offered too, while none (zero) is not. Without multiple, a single member is selected as usual.
When it is not set, it is what the enum is registered with, see the enumFlags option of registerEnum.

***

### iconField?

> `optional` **iconField**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L27)

Name of the item field containing the icon class.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`iconField`](ComboboxCommonOptions.md#iconfield)

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
