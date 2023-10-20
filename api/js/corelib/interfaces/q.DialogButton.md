[@serenity-is](../README.md) / [Modules](../modules.md) / [q](../modules/q.md) / DialogButton

# Interface: DialogButton

[q](../modules/q.md).DialogButton

Options for a message dialog button

## Table of contents

### Properties

- [click](q.DialogButton.md#click)
- [cssClass](q.DialogButton.md#cssclass)
- [hint](q.DialogButton.md#hint)
- [htmlEncode](q.DialogButton.md#htmlencode)
- [icon](q.DialogButton.md#icon)
- [result](q.DialogButton.md#result)
- [text](q.DialogButton.md#text)

## Properties

### click

• `Optional` **click**: (`e`: `MouseEvent`) => `void`

#### Type declaration

▸ (`e`): `void`

Click handler

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L20)

___

### cssClass

• `Optional` **cssClass**: `string`

CSS class for button

#### Defined in

[src/q/dialogs.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L22)

___

### hint

• `Optional` **hint**: `string`

Button hint

#### Defined in

[src/q/dialogs.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L16)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

HTML encode button text. Default is true.

#### Defined in

[src/q/dialogs.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L24)

___

### icon

• `Optional` **icon**: `string`

Button icon

#### Defined in

[src/q/dialogs.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L18)

___

### result

• `Optional` **result**: `string`

The code that is returned from message dialog function when this button is clicked

#### Defined in

[src/q/dialogs.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L26)

___

### text

• `Optional` **text**: `string`

Button text

#### Defined in

[src/q/dialogs.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L14)
