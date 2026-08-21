[@serenity-is/corelib](../README.md) / TimeEditorOptions

# Interface: TimeEditorOptions

Defined in: [src/ui/editors/timeeditor.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L133)

Options for the [TimeEditor](../classes/TimeEditor.md).

## Extends

- [`TimeEditorBaseOptions`](TimeEditorBaseOptions.md)

## Properties

### endHour?

> `optional` **endHour**: `any`

Defined in: [src/ui/editors/timeeditor.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L15)

Ending hour for the hour select.

#### Inherited from

[`TimeEditorBaseOptions`](TimeEditorBaseOptions.md).[`endHour`](TimeEditorBaseOptions.md#endhour)

***

### intervalMinutes?

> `optional` **intervalMinutes**: `any`

Defined in: [src/ui/editors/timeeditor.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L17)

Interval in minutes between minute options.

#### Inherited from

[`TimeEditorBaseOptions`](TimeEditorBaseOptions.md).[`intervalMinutes`](TimeEditorBaseOptions.md#intervalminutes)

***

### multiplier?

> `optional` **multiplier**: `number`

Defined in: [src/ui/editors/timeeditor.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L135)

Default is 1. Set to 60 to store seconds, 60000 to store ms in an integer field

***

### noEmptyOption?

> `optional` **noEmptyOption**: `boolean`

Defined in: [src/ui/editors/timeeditor.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L11)

Whether to omit the empty option.

#### Inherited from

[`TimeEditorBaseOptions`](TimeEditorBaseOptions.md).[`noEmptyOption`](TimeEditorBaseOptions.md#noemptyoption)

***

### startHour?

> `optional` **startHour**: `any`

Defined in: [src/ui/editors/timeeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L13)

Starting hour for the hour select.

#### Inherited from

[`TimeEditorBaseOptions`](TimeEditorBaseOptions.md).[`startHour`](TimeEditorBaseOptions.md#starthour)
