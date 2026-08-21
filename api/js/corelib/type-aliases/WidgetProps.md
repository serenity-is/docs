[@serenity-is/corelib](../README.md) / WidgetProps

# Type Alias: WidgetProps\<P\>

> **WidgetProps**\<`P`\> = `object` & [`SNoInfer`](SNoInfer.md)\<`P`\>

Defined in: [src/ui/widgets/widgetutils.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L171)

Props accepted by all widgets, including the target element and common
element attributes.

## Type Declaration

### class?

> `optional` **class**: `string`

Optional CSS class(es) for the widget's DOM node.

### element?

> `optional` **element**: (`el`) => `void` \| `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| `string`

The element to bind the widget to, as an element, array-like, selector
 or a callback that receives the created element.

### id?

> `optional` **id**: `string`

Optional id for the widget's DOM node.

## Type Parameters

### P

`P`

The widget's specific options type.
