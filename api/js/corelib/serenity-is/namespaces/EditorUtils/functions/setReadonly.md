[serenity-is/corelib](../../../../README.md) / [EditorUtils](../README.md) / setReadonly

# Function: setReadonly()

> **setReadonly**(`elements`, `value`): `void`

Defined in: [src/ui/editors/editorutils.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorutils.tsx#L157)

This functions sets readonly class and disabled (for select, radio, checkbox) or readonly attribute (for other inputs) on given elements
or widgets. If a widget is passed and it has set_readOnly method it is called instead of setting readonly class or attributes.
Note that if an element, instead of the widget attached to it is passed directly, this searchs for a widget attached to it.
If you don't want this behavior, use setElementReadOnly method.

## Parameters

### elements

`Element` | [`Widget`](../../../../classes/Widget.md)\<`any`\> | `ArrayLike`\<`Element` \| [`Widget`](../../../../classes/Widget.md)\<\{ \}\>\>

### value

`boolean`

## Returns

`void`
