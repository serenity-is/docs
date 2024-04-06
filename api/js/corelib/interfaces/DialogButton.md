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

[../base/dist/index.d.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L244)

___

### cssClass

• `Optional` **cssClass**: `string`

CSS class for button

#### Defined in

[../base/dist/index.d.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L246)

___

### hint

• `Optional` **hint**: `string`

Button hint

#### Defined in

[../base/dist/index.d.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L240)

___

### icon

• `Optional` **icon**: [`IconClassName`](../README.md#iconclassname)

Button icon

#### Defined in

[../base/dist/index.d.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L242)

___

### result

• `Optional` **result**: `string`

The code that is returned from message dialog function when this button is clicked.
 If this is set, and click event will not be defaultPrevented dialog will close.

#### Defined in

[../base/dist/index.d.ts:250](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L250)

___

### text

• `Optional` **text**: `string`

Button text

#### Defined in

[../base/dist/index.d.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L238)
