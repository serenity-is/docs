[@serenity-is/corelib](../README.md) / DialogButton

# Interface: DialogButton

Options for a message dialog button

## Properties

### click()?

> `optional` **click**: (`e`) => `false` \| `void` \| `Promise`\<`false` \| `void`\>

Click handler

#### Parameters

##### e

`MouseEvent`

#### Returns

`false` \| `void` \| `Promise`\<`false` \| `void`\>

#### Defined in

[src/base/dialogs.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L19)

***

### cssClass?

> `optional` **cssClass**: `string`

CSS class for button

#### Defined in

[src/base/dialogs.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L21)

***

### hint?

> `optional` **hint**: `string`

Button hint

#### Defined in

[src/base/dialogs.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L15)

***

### icon?

> `optional` **icon**: [`IconClassName`](../type-aliases/IconClassName.md)

Button icon

#### Defined in

[src/base/dialogs.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L17)

***

### result?

> `optional` **result**: `string`

The code that is returned from message dialog function when this button is clicked.
 If this is set, and click event will not be defaultPrevented dialog will close.

#### Defined in

[src/base/dialogs.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L25)

***

### text?

> `optional` **text**: `string`

Button text

#### Defined in

[src/base/dialogs.tsx:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L13)
