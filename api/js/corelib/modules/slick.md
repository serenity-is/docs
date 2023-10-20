[@serenity-is](../README.md) / [Modules](../modules.md) / slick

# Module: slick

## Table of contents

### Namespaces

- [AggregateFormatting](slick.AggregateFormatting.md)
- [Aggregators](slick.Aggregators.md)

### Classes

- [RemoteView](../classes/slick.RemoteView.md)

### Interfaces

- [Formatter](../interfaces/slick.Formatter.md)
- [GroupInfo](../interfaces/slick.GroupInfo.md)
- [PagerOptions](../interfaces/slick.PagerOptions.md)
- [PagingInfo](../interfaces/slick.PagingInfo.md)
- [PagingOptions](../interfaces/slick.PagingOptions.md)
- [RemoteViewOptions](../interfaces/slick.RemoteViewOptions.md)
- [SummaryOptions](../interfaces/slick.SummaryOptions.md)

### Type Aliases

- [CancellableViewCallback](slick.md#cancellableviewcallback)
- [Format](slick.md#format)
- [RemoteViewAjaxCallback](slick.md#remoteviewajaxcallback)
- [RemoteViewFilter](slick.md#remoteviewfilter)
- [RemoteViewProcessCallback](slick.md#remoteviewprocesscallback)

## Type Aliases

### CancellableViewCallback

Ƭ **CancellableViewCallback**<`TEntity`\>: (`view`: [`RemoteView`](../classes/slick.RemoteView.md)<`TEntity`\>) => `boolean` \| `void`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`view`): `boolean` \| `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `view` | [`RemoteView`](../classes/slick.RemoteView.md)<`TEntity`\> |

##### Returns

`boolean` \| `void`

#### Defined in

[src/slick/remoteview.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L37)

___

### Format

Ƭ **Format**<`TItem`\>: (`ctx`: `FormatterContext`<`TItem`\>) => `string`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Type declaration

▸ (`ctx`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`<`TItem`\> |

##### Returns

`string`

#### Defined in

[src/slick/slicktypes.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L4)

___

### RemoteViewAjaxCallback

Ƭ **RemoteViewAjaxCallback**<`TEntity`\>: (`view`: [`RemoteView`](../classes/slick.RemoteView.md)<`TEntity`\>, `options`: `JQueryAjaxSettings`) => `boolean` \| `void`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`view`, `options`): `boolean` \| `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `view` | [`RemoteView`](../classes/slick.RemoteView.md)<`TEntity`\> |
| `options` | `JQueryAjaxSettings` |

##### Returns

`boolean` \| `void`

#### Defined in

[src/slick/remoteview.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L38)

___

### RemoteViewFilter

Ƭ **RemoteViewFilter**<`TEntity`\>: (`item`: `TEntity`, `view`: [`RemoteView`](../classes/slick.RemoteView.md)<`TEntity`\>) => `boolean`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`item`, `view`): `boolean`

##### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TEntity` |
| `view` | [`RemoteView`](../classes/slick.RemoteView.md)<`TEntity`\> |

##### Returns

`boolean`

#### Defined in

[src/slick/remoteview.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L39)

___

### RemoteViewProcessCallback

Ƭ **RemoteViewProcessCallback**<`TEntity`\>: (`data`: [`ListResponse`](../interfaces/q.ListResponse.md)<`TEntity`\>, `view`: [`RemoteView`](../classes/slick.RemoteView.md)<`TEntity`\>) => [`ListResponse`](../interfaces/q.ListResponse.md)<`TEntity`\>

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`data`, `view`): [`ListResponse`](../interfaces/q.ListResponse.md)<`TEntity`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`ListResponse`](../interfaces/q.ListResponse.md)<`TEntity`\> |
| `view` | [`RemoteView`](../classes/slick.RemoteView.md)<`TEntity`\> |

##### Returns

[`ListResponse`](../interfaces/q.ListResponse.md)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L40)
