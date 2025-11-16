[corelib](../README.md) / QuickFilterItemData

# Interface: QuickFilterItemData\<TWidget\>

Defined in: [src/ui/datagrid/quickfilterbar.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L17)

## Type Parameters

### TWidget

`TWidget`

## Properties

### displayText()?

> `optional` **displayText**: (`w`, `l`) => `string`

Defined in: [src/ui/datagrid/quickfilterbar.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L18)

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

Defined in: [src/ui/datagrid/quickfilterbar.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L20)

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

Defined in: [src/ui/datagrid/quickfilterbar.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L19)

#### Parameters

##### w

`TWidget`

#### Returns

`any`
