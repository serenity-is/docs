[@serenity-is/corelib](../README.md) / QuickFilter

# Interface: QuickFilter\<TWidget, P\>

Defined in: [src/ui/datagrid/quickfilter.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L30)

Definition for a single quick filter rendered in the grid toolbar.

## Type Parameters

### TWidget

`TWidget` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

Widget type that provides the filter UI.

### P

`P`

Props/options type for the widget.

## Properties

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/ui/datagrid/quickfilter.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L48)

Extra CSS class applied to the filter item container.

***

### displayText()?

> `optional` **displayText**: (`w`, `label`) => `string`

Defined in: [src/ui/datagrid/quickfilter.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L54)

Returns human-readable text for the active filter display.

#### Parameters

##### w

`TWidget`

##### label

`string`

#### Returns

`string`

***

### element()?

> `optional` **element**: (`e`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L42)

Optional callback to customize the filter container element.

#### Parameters

##### e

[`Fluent`](Fluent.md)

#### Returns

`void`

***

### field?

> `optional` **field**: `string`

Defined in: [src/ui/datagrid/quickfilter.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L32)

Field name associated with the quick filter.

***

### handler()?

> `optional` **handler**: (`h`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L36)

Callback invoked when the list request is prepared; may mutate the request.

#### Parameters

##### h

[`QuickFilterArgs`](QuickFilterArgs.md)\<`TWidget`\>

#### Returns

`void`

***

### init()?

> `optional` **init**: (`w`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L44)

Callback invoked after the widget instance is created for additional setup.

#### Parameters

##### w

`TWidget`

#### Returns

`void`

***

### loadState()?

> `optional` **loadState**: (`w`, `state`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L50)

Restores persisted filter state into the widget.

#### Parameters

##### w

`TWidget`

##### state

`any`

#### Returns

`void`

***

### options?

> `optional` **options**: `P` & `object`

Defined in: [src/ui/datagrid/quickfilter.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L40)

Options passed to the widget constructor; merged with [WidgetProps](../type-aliases/WidgetProps.md).

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

### saveState()?

> `optional` **saveState**: (`w`) => `any`

Defined in: [src/ui/datagrid/quickfilter.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L52)

Persists widget state for grid settings.

#### Parameters

##### w

`TWidget`

#### Returns

`any`

***

### separator?

> `optional` **separator**: `boolean`

Defined in: [src/ui/datagrid/quickfilter.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L46)

When true, a visual separator is rendered before this filter.

***

### title?

> `optional` **title**: `string`

Defined in: [src/ui/datagrid/quickfilter.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L38)

Title / label shown for the filter.

***

### type?

> `optional` **type**: \{(`options?`): `TWidget`; `prototype`: `TWidget`; \}

Defined in: [src/ui/datagrid/quickfilter.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L34)

Widget constructor used to create the filter editor.

#### Parameters

##### options?

`P`

#### Returns

`TWidget`

#### prototype

> **prototype**: `TWidget`
