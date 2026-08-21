[@serenity-is/corelib](../README.md) / QuickFilterBarOptions

# Interface: QuickFilterBarOptions

Defined in: [src/ui/datagrid/quickfilterbar.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L14)

Options for the [QuickFilterBar](../classes/QuickFilterBar.md) widget.

## Properties

### filters

> **filters**: [`QuickFilter`](QuickFilter.md)\<[`Widget`](../classes/Widget.md)\<`any`\>, `any`\>[]

Defined in: [src/ui/datagrid/quickfilterbar.tsx:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L16)

Quick filter definitions to render in the bar.

***

### getTitle()?

> `optional` **getTitle**: (`filter`) => `string`

Defined in: [src/ui/datagrid/quickfilterbar.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L18)

Optional callback that returns the display title for a filter.

#### Parameters

##### filter

[`QuickFilter`](QuickFilter.md)\<[`Widget`](../classes/Widget.md)\<`any`\>, `any`\>

#### Returns

`string`

***

### idPrefix?

> `optional` **idPrefix**: `string`

Defined in: [src/ui/datagrid/quickfilterbar.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L20)

Prefix used for generated element ids; defaults to the widget unique name.
