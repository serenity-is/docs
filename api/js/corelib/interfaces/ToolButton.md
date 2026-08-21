[@serenity-is/corelib](../README.md) / ToolButton

# Interface: ToolButton

Defined in: [src/ui/widgets/toolbar.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L32)

A toolbar button definition, extending [ToolButtonProps](ToolButtonProps.md) with hotkey
and separator support.

## Extends

- [`ToolButtonProps`](ToolButtonProps.md)

## Properties

### action?

> `optional` **action**: `string`

Defined in: [src/ui/widgets/toolbar.tsx:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L9)

Optional action name stored on the button's `data-action` attribute.

#### Inherited from

[`ToolButtonProps`](ToolButtonProps.md).[`action`](ToolButtonProps.md#action)

***

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/ui/widgets/toolbar.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L15)

Optional CSS class(es) applied to the button.

#### Inherited from

[`ToolButtonProps`](ToolButtonProps.md).[`cssClass`](ToolButtonProps.md#cssclass)

***

### disabled?

> `optional` **disabled**: `boolean` \| () => `boolean`

Defined in: [src/ui/widgets/toolbar.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L25)

Whether the button is disabled; may be a function evaluated on update.

#### Inherited from

[`ToolButtonProps`](ToolButtonProps.md).[`disabled`](ToolButtonProps.md#disabled)

***

### hint?

> `optional` **hint**: `string`

Defined in: [src/ui/widgets/toolbar.tsx:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L13)

Optional tooltip hint shown on hover.

#### Inherited from

[`ToolButtonProps`](ToolButtonProps.md).[`hint`](ToolButtonProps.md#hint)

***

### hotkey?

> `optional` **hotkey**: `string`

Defined in: [src/ui/widgets/toolbar.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L34)

Optional hotkey binding (e.g. "ctrl+s").

***

### hotkeyAllowDefault?

> `optional` **hotkeyAllowDefault**: `boolean`

Defined in: [src/ui/widgets/toolbar.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L36)

Whether the browser's default hotkey behavior should be allowed.

***

### hotkeyContext?

> `optional` **hotkeyContext**: `any`

Defined in: [src/ui/widgets/toolbar.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L38)

Optional context element to which the hotkey is bound.

***

### icon?

> `optional` **icon**: [`IconClassName`](../type-aliases/IconClassName.md)

Defined in: [src/ui/widgets/toolbar.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L17)

Optional icon class name to display before the title.

#### Inherited from

[`ToolButtonProps`](ToolButtonProps.md).[`icon`](ToolButtonProps.md#icon)

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

#### Inherited from

[`ToolButtonProps`](ToolButtonProps.md).[`onClick`](ToolButtonProps.md#onclick)

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

#### Inherited from

[`ToolButtonProps`](ToolButtonProps.md).[`ref`](ToolButtonProps.md#ref)

***

### separator?

> `optional` **separator**: `boolean` \| `"left"` \| `"right"` \| `"both"`

Defined in: [src/ui/widgets/toolbar.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L40)

Whether (and where) a separator should be rendered before the button.

***

### title?

> `optional` **title**: `string` \| `HTMLElement` \| `DocumentFragment` \| `SVGElement` \| `MathMLElement`

Defined in: [src/ui/widgets/toolbar.tsx:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L11)

The button's title (text or element).

#### Inherited from

[`ToolButtonProps`](ToolButtonProps.md).[`title`](ToolButtonProps.md#title)

***

### visible?

> `optional` **visible**: `boolean` \| () => `boolean`

Defined in: [src/ui/widgets/toolbar.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.tsx#L23)

Whether the button is visible; may be a function evaluated on update.

#### Inherited from

[`ToolButtonProps`](ToolButtonProps.md).[`visible`](ToolButtonProps.md#visible)
