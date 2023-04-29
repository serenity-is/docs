[@serenity-is](../README.md) / [Modules](../modules.md) / corelib/slick

# Module: corelib/slick

This is the main entry point for `@serenity-is/corelib/slick` module. This module mainly contains 
some Serenity specific extensions for sleekgrid like `RemoteView`.

The types from this module are available by importing from "@serenity-is/corelib/slick" module:

```ts
import { RemoteView } from "@serenity-is/corelib/slick";
export class MyCustomView extends RemoveView {
}
```
  
> When using classic namespaces instead of the ESM modules, the types and functions in this module are directly available from the global `Slick` namespace.
> e.g. `Slick.RemoveView`

## Table of contents

### Namespaces

- [AggregateFormatting](corelib_slick.AggregateFormatting.md)
- [Aggregators](corelib_slick.Aggregators.md)

### Classes

- [RemoteView](../classes/corelib_slick.RemoteView.md)

### Interfaces

- [Formatter](../interfaces/corelib_slick.Formatter.md)
- [GroupInfo](../interfaces/corelib_slick.GroupInfo.md)
- [PagerOptions](../interfaces/corelib_slick.PagerOptions.md)
- [PagingInfo](../interfaces/corelib_slick.PagingInfo.md)
- [PagingOptions](../interfaces/corelib_slick.PagingOptions.md)
- [RemoteViewOptions](../interfaces/corelib_slick.RemoteViewOptions.md)
- [SummaryOptions](../interfaces/corelib_slick.SummaryOptions.md)

### Type Aliases

- [CancellableViewCallback](corelib_slick.md#cancellableviewcallback)
- [Format](corelib_slick.md#format)
- [RemoteViewAjaxCallback](corelib_slick.md#remoteviewajaxcallback)
- [RemoteViewFilter](corelib_slick.md#remoteviewfilter)
- [RemoteViewProcessCallback](corelib_slick.md#remoteviewprocesscallback)

## Type Aliases

### CancellableViewCallback

Ƭ **CancellableViewCallback**<`TEntity`\>: (`view`: [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TEntity`\>) => `boolean` \| `void`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`view`): `boolean` \| `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `view` | [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TEntity`\> |

##### Returns

`boolean` \| `void`

#### Defined in

[src/slick/remoteview.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;37)

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

[src/slick/slicktypes.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#line&#x3D;4)

___

### RemoteViewAjaxCallback

Ƭ **RemoteViewAjaxCallback**<`TEntity`\>: (`view`: [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TEntity`\>, `options`: `JQueryAjaxSettings`) => `boolean` \| `void`

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`view`, `options`): `boolean` \| `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `view` | [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TEntity`\> |
| `options` | `JQueryAjaxSettings` |

##### Returns

`boolean` \| `void`

#### Defined in

[src/slick/remoteview.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;38)

___

### RemoteViewFilter

Ƭ **RemoteViewFilter**<`TEntity`\>: (`item`: `TEntity`, `view`: [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TEntity`\>) => `boolean`

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
| `view` | [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TEntity`\> |

##### Returns

`boolean`

#### Defined in

[src/slick/remoteview.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;39)

___

### RemoteViewProcessCallback

Ƭ **RemoteViewProcessCallback**<`TEntity`\>: (`data`: [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TEntity`\>, `view`: [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TEntity`\>) => [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TEntity`\>

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Type declaration

▸ (`data`, `view`): [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TEntity`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TEntity`\> |
| `view` | [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TEntity`\> |

##### Returns

[`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;40)
