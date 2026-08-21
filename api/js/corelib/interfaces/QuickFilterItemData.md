[@serenity-is/corelib](../README.md) / QuickFilterItemData

# Interface: QuickFilterItemData\<TWidget\>

Defined in: [src/ui/datagrid/quickfilterbar.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L27)

Per-item data attached to a quick filter element for state persistence and display.

## Type Parameters

### TWidget

`TWidget`

Widget type that backs the quick filter.

## Properties

### displayText()?

> `optional` **displayText**: (`w`, `l`) => `string`

Defined in: [src/ui/datagrid/quickfilterbar.tsx:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L29)

Returns the human-readable text for the active filter display.

#### Parameters

##### w

`TWidget`

##### l

`string`

#### Returns

`string`

***

### loadState()?

> `optional` **loadState**: (`w`, `state`) => `void`

Defined in: [src/ui/datagrid/quickfilterbar.tsx:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L33)

Restores persisted widget state.

#### Parameters

##### w

`TWidget`

##### state

`any`

#### Returns

`void`

***

### saveState()?

> `optional` **saveState**: (`w`) => `any`

Defined in: [src/ui/datagrid/quickfilterbar.tsx:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L31)

Persists the widget state for grid settings.

#### Parameters

##### w

`TWidget`

#### Returns

`any`
