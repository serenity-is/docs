[@serenity-is/corelib](../README.md) / IDialog

# Abstract Class: IDialog

Defined in: [src/interfaces/idialog.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/idialog.ts#L6)

Type token for dialog widgets. Implemented by dialogs that can be opened as modal or panel.

## Constructors

### Constructor

> **new IDialog**(): `IDialog`

#### Returns

`IDialog`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/interfaces/idialog.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/idialog.ts#L7)

## Methods

### dialogOpen()

> **dialogOpen**(`asPanel?`): `void`

Defined in: [src/interfaces/idialog.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/idialog.ts#L15)

Opens the dialog.

#### Parameters

##### asPanel?

`boolean`

When true, opens as an in-page panel instead of a modal dialog.

#### Returns

`void`
