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

Defined in: [src/ui/datagrid/quickfilter.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L53)

Extra CSS class applied to the filter item container.

***

### displayText()?

> `optional` **displayText**: (`w`, `label`) => `string`

Defined in: [src/ui/datagrid/quickfilter.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L59)

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

Defined in: [src/ui/datagrid/quickfilter.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L47)

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

Defined in: [src/ui/datagrid/quickfilter.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L41)

Callback invoked when the list request is prepared; may mutate the request.

#### Parameters

##### h

[`QuickFilterArgs`](QuickFilterArgs.md)\<`TWidget`\>

#### Returns

`void`

***

### init()?

> `optional` **init**: (`w`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L49)

Callback invoked after the widget instance is created for additional setup.

#### Parameters

##### w

`TWidget`

#### Returns

`void`

***

### loadState()?

> `optional` **loadState**: (`w`, `state`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L55)

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

Defined in: [src/ui/datagrid/quickfilter.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L45)

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

Defined in: [src/ui/datagrid/quickfilter.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L57)

Persists widget state for grid settings.

#### Parameters

##### w

`TWidget`

#### Returns

`any`

***

### separator?

> `optional` **separator**: `boolean`

Defined in: [src/ui/datagrid/quickfilter.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L51)

When true, a visual separator is rendered before this filter.

***

### title?

> `optional` **title**: `string`

Defined in: [src/ui/datagrid/quickfilter.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L43)

Title / label shown for the filter.

***

### type?

> `optional` **type**: \{(`options?`): `TWidget`; `prototype`: `TWidget`; \} \| `PromiseLike`\<\{(`options?`): `TWidget`; `prototype`: `TWidget`; \}\>

Defined in: [src/ui/datagrid/quickfilter.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L39)

Widget constructor used to create the filter editor, or a promise for it when the type has to be loaded.
In that case a placeholder widget that only holds a value is used until the type is loaded, so
[handler](#handler), [loadState](#loadstate), [saveState](#savestate) and [displayText](#displaytext) may be called with it,
while [element](#element) and [init](#init) are only called for the actual widget.
