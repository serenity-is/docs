[@serenity-is/corelib](../README.md) / DialogButton

# Interface: DialogButton

Options for a message dialog button

## Table of contents

### Properties

- [click](DialogButton.md#click)
- [cssClass](DialogButton.md#cssclass)
- [hint](DialogButton.md#hint)
- [icon](DialogButton.md#icon)
- [result](DialogButton.md#result)
- [text](DialogButton.md#text)

## Properties

### click

• `Optional` **click**: (`e`: `MouseEvent`) => ``false`` \| `void` \| `Promise`\<``false`` \| `void`\>

Click handler

#### Type declaration

▸ (`e`): ``false`` \| `void` \| `Promise`\<``false`` \| `void`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

##### Returns

``false`` \| `void` \| `Promise`\<``false`` \| `void`\>

#### Defined in

[src/base/dialogs.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L19)

___

### cssClass

• `Optional` **cssClass**: `string`

CSS class for button

#### Defined in

[src/base/dialogs.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L21)

___

### hint

• `Optional` **hint**: `string`

Button hint

#### Defined in

[src/base/dialogs.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L15)

___

### icon

• `Optional` **icon**: [`IconClassName`](../README.md#iconclassname)

Button icon

#### Defined in

[src/base/dialogs.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L17)

___

### result

• `Optional` **result**: `string`

The code that is returned from message dialog function when this button is clicked.
 If this is set, and click event will not be defaultPrevented dialog will close.

#### Defined in

[src/base/dialogs.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L25)

___

### text

• `Optional` **text**: `string`

Button text

#### Defined in

[src/base/dialogs.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.ts#L13)
