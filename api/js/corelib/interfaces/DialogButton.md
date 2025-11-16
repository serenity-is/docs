[corelib](../README.md) / DialogButton

# Interface: DialogButton

Defined in: [src/base/dialogs.tsx:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L12)

Options for a message dialog button

## Properties

### click()?

> `optional` **click**: (`e`) => `false` \| `void` \| `Promise`\<`false` \| `void`\>

Defined in: [src/base/dialogs.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L20)

Click handler

#### Parameters

##### e

`MouseEvent`

#### Returns

`false` \| `void` \| `Promise`\<`false` \| `void`\>

***

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/base/dialogs.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L22)

CSS class for button

***

### hint?

> `optional` **hint**: `string`

Defined in: [src/base/dialogs.tsx:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L16)

Button hint

***

### icon?

> `optional` **icon**: [`IconClassName`](../type-aliases/IconClassName.md)

Defined in: [src/base/dialogs.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L18)

Button icon

***

### result?

> `optional` **result**: `string`

Defined in: [src/base/dialogs.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L26)

The code that is returned from message dialog function when this button is clicked.
 If this is set, and click event will not be defaultPrevented dialog will close.

***

### text?

> `optional` **text**: `string`

Defined in: [src/base/dialogs.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/dialogs.tsx#L14)

Button text
