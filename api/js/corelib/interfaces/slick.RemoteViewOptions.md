[@serenity-is](../README.md) / [Modules](../modules.md) / [slick](../modules/slick.md) / RemoteViewOptions

# Interface: RemoteViewOptions

[slick](../modules/slick.md).RemoteViewOptions

## Table of contents

### Properties

- [autoLoad](slick.RemoteViewOptions.md#autoload)
- [contentType](slick.RemoteViewOptions.md#contenttype)
- [dataType](slick.RemoteViewOptions.md#datatype)
- [errorMsg](slick.RemoteViewOptions.md#errormsg)
- [filter](slick.RemoteViewOptions.md#filter)
- [getItemMetadata](slick.RemoteViewOptions.md#getitemmetadata)
- [groupItemMetadataProvider](slick.RemoteViewOptions.md#groupitemmetadataprovider)
- [idField](slick.RemoteViewOptions.md#idfield)
- [inlineFilters](slick.RemoteViewOptions.md#inlinefilters)
- [localSort](slick.RemoteViewOptions.md#localsort)
- [method](slick.RemoteViewOptions.md#method)
- [onAjaxCall](slick.RemoteViewOptions.md#onajaxcall)
- [onProcessData](slick.RemoteViewOptions.md#onprocessdata)
- [onSubmit](slick.RemoteViewOptions.md#onsubmit)
- [params](slick.RemoteViewOptions.md#params)
- [rowsPerPage](slick.RemoteViewOptions.md#rowsperpage)
- [seekToPage](slick.RemoteViewOptions.md#seektopage)
- [sortBy](slick.RemoteViewOptions.md#sortby)
- [url](slick.RemoteViewOptions.md#url)

## Properties

### autoLoad

• `Optional` **autoLoad**: `boolean`

#### Defined in

[src/slick/remoteview.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L7)

___

### contentType

• `Optional` **contentType**: `string`

#### Defined in

[src/slick/remoteview.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L9)

___

### dataType

• `Optional` **dataType**: `string`

#### Defined in

[src/slick/remoteview.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L10)

___

### errorMsg

• `Optional` **errorMsg**: `string`

#### Defined in

[src/slick/remoteview.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L25)

___

### filter

• `Optional` **filter**: `any`

#### Defined in

[src/slick/remoteview.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L11)

___

### getItemMetadata

• `Optional` **getItemMetadata**: (`p1?`: `any`, `p2?`: `number`) => `any`

#### Type declaration

▸ (`p1?`, `p2?`): `any`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1?` | `any` |
| `p2?` | `number` |

##### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L24)

___

### groupItemMetadataProvider

• `Optional` **groupItemMetadataProvider**: `GroupItemMetadataProvider`

#### Defined in

[src/slick/remoteview.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L22)

___

### idField

• `Optional` **idField**: `string`

#### Defined in

[src/slick/remoteview.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L8)

___

### inlineFilters

• `Optional` **inlineFilters**: `boolean`

#### Defined in

[src/slick/remoteview.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L21)

___

### localSort

• `Optional` **localSort**: `boolean`

#### Defined in

[src/slick/remoteview.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L15)

___

### method

• `Optional` **method**: `string`

#### Defined in

[src/slick/remoteview.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L20)

___

### onAjaxCall

• `Optional` **onAjaxCall**: [`RemoteViewAjaxCallback`](../modules/slick.md#remoteviewajaxcallback)<`any`\>

#### Defined in

[src/slick/remoteview.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L23)

___

### onProcessData

• `Optional` **onProcessData**: [`RemoteViewProcessCallback`](../modules/slick.md#remoteviewprocesscallback)<`any`\>

#### Defined in

[src/slick/remoteview.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L19)

___

### onSubmit

• `Optional` **onSubmit**: [`CancellableViewCallback`](../modules/slick.md#cancellableviewcallback)<`any`\>

#### Defined in

[src/slick/remoteview.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L13)

___

### params

• `Optional` **params**: `any`

#### Defined in

[src/slick/remoteview.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L12)

___

### rowsPerPage

• `Optional` **rowsPerPage**: `number`

#### Defined in

[src/slick/remoteview.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L17)

___

### seekToPage

• `Optional` **seekToPage**: `number`

#### Defined in

[src/slick/remoteview.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L18)

___

### sortBy

• `Optional` **sortBy**: `any`

#### Defined in

[src/slick/remoteview.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L16)

___

### url

• `Optional` **url**: `string`

#### Defined in

[src/slick/remoteview.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L14)
