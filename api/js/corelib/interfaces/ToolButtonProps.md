[@serenity-is/corelib](../README.md) / ToolButtonProps

# Interface: ToolButtonProps

Defined in: [src/ui/widgets/toolbar.tsx:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L7)

Props describing a single toolbar button.

## Extended by

- [`ToolButton`](ToolButton.md)

## Properties

### action?

> `optional` **action**: `string`

Defined in: [src/ui/widgets/toolbar.tsx:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L9)

Optional action name stored on the button's `data-action` attribute.

***

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/ui/widgets/toolbar.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L15)

Optional CSS class(es) applied to the button.

***

### disabled?

> `optional` **disabled**: `boolean` \| () => `boolean`

Defined in: [src/ui/widgets/toolbar.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L25)

Whether the button is disabled; may be a function evaluated on update.

***

### hint?

> `optional` **hint**: `string`

Defined in: [src/ui/widgets/toolbar.tsx:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L13)

Optional tooltip hint shown on hover.

***

### icon?

> `optional` **icon**: [`IconClassName`](../type-aliases/IconClassName.md)

Defined in: [src/ui/widgets/toolbar.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L17)

Optional icon class name to display before the title.

***

### onClick()?

> `optional` **onClick**: (`e`) => `void`

Defined in: [src/ui/widgets/toolbar.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L19)

Handler invoked when the button is clicked.

#### Parameters

##### e

`MouseEvent` & `object`

#### Returns

`void`

***

### ref()?

> `optional` **ref**: (`el`) => `void`

Defined in: [src/ui/widgets/toolbar.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L21)

Callback invoked with the created button element.

#### Parameters

##### el

`HTMLElement`

#### Returns

`void`

***

### title?

> `optional` **title**: `string` \| `HTMLElement` \| `DocumentFragment` \| `SVGElement` \| `MathMLElement`

Defined in: [src/ui/widgets/toolbar.tsx:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L11)

The button's title (text or element).

***

### visible?

> `optional` **visible**: `boolean` \| () => `boolean`

Defined in: [src/ui/widgets/toolbar.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L23)

Whether the button is visible; may be a function evaluated on update.
