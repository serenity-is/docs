[@serenity-is/corelib](../README.md) / CreateWidgetParams

# Interface: CreateWidgetParams\<TWidget, P\>

Defined in: [src/ui/widgets/widget.ts:380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L380)

Parameters for [Widget.create](../classes/Widget.md#create).

## Type Parameters

### TWidget

`TWidget` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

The widget type to create.

### P

`P`

The widget's options type.

## Properties

### container?

> `optional` **container**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/ui/widgets/widget.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L386)

The container to append the widget's element to.

***

### element()?

> `optional` **element**: (`e`) => `void`

Defined in: [src/ui/widgets/widget.ts:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L388)

Callback invoked with the created element.

#### Parameters

##### e

[`Fluent`](Fluent.md)

#### Returns

`void`

***

### init()?

> `optional` **init**: (`w`) => `void`

Defined in: [src/ui/widgets/widget.ts:390](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L390)

Callback invoked after the widget is initialized.

#### Parameters

##### w

`TWidget`

#### Returns

`void`

***

### options?

> `optional` **options**: `P` & `object`

Defined in: [src/ui/widgets/widget.ts:384](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L384)

The options to pass to the widget.

#### Type Declaration

##### class?

> `optional` **class**: `string`

Optional CSS class(es) for the widget's DOM node.

##### element?

> `optional` **element**: `string` \| `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`el`) => `void`

The element to bind the widget to, as an element, array-like, selector
 or a callback that receives the created element.

##### id?

> `optional` **id**: `string`

Optional id for the widget's DOM node.

***

### type?

> `optional` **type**: \{(`options?`): `TWidget`; `prototype`: `TWidget`; \}

Defined in: [src/ui/widgets/widget.ts:382](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L382)

The widget type to instantiate.

#### Parameters

##### options?

`P`

#### Returns

`TWidget`

#### prototype

> **prototype**: `TWidget`
