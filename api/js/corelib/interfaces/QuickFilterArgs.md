[@serenity-is/corelib](../README.md) / QuickFilterArgs

# Interface: QuickFilterArgs\<TWidget\>

Defined in: [src/ui/datagrid/quickfilter.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L8)

Arguments passed to a quick filter handler when a list request is prepared.

## Type Parameters

### TWidget

`TWidget`

The widget type that backs the quick filter.

## Properties

### active?

> `optional` **active**: `boolean`

Defined in: [src/ui/datagrid/quickfilter.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L20)

Whether the filter is currently considered active.

***

### equalityFilter?

> `optional` **equalityFilter**: `any`

Defined in: [src/ui/datagrid/quickfilter.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L16)

Equality filter value derived from the widget, if any.

***

### field?

> `optional` **field**: `string`

Defined in: [src/ui/datagrid/quickfilter.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L10)

Field name the filter is bound to.

***

### handled?

> `optional` **handled**: `boolean`

Defined in: [src/ui/datagrid/quickfilter.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L22)

When set, the framework skips default equality-filter handling.

***

### request?

> `optional` **request**: [`ListRequest`](ListRequest.md)

Defined in: [src/ui/datagrid/quickfilter.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L14)

Current list request being built; handler may mutate criteria.

***

### value?

> `optional` **value**: `any`

Defined in: [src/ui/datagrid/quickfilter.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L18)

Canonical value of the filter.

***

### widget?

> `optional` **widget**: `TWidget`

Defined in: [src/ui/datagrid/quickfilter.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L12)

Widget instance for the quick filter, if created.
