[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / RemoteViewOptions

# Interface: RemoteViewOptions

## Table of contents

### Properties

- [autoLoad](RemoteViewOptions.md#autoload)
- [contentType](RemoteViewOptions.md#contenttype)
- [dataType](RemoteViewOptions.md#datatype)
- [errorMsg](RemoteViewOptions.md#errormsg)
- [filter](RemoteViewOptions.md#filter)
- [getItemMetadata](RemoteViewOptions.md#getitemmetadata)
- [groupItemMetadataProvider](RemoteViewOptions.md#groupitemmetadataprovider)
- [idField](RemoteViewOptions.md#idfield)
- [inlineFilters](RemoteViewOptions.md#inlinefilters)
- [localSort](RemoteViewOptions.md#localsort)
- [method](RemoteViewOptions.md#method)
- [onAjaxCall](RemoteViewOptions.md#onajaxcall)
- [onProcessData](RemoteViewOptions.md#onprocessdata)
- [onSubmit](RemoteViewOptions.md#onsubmit)
- [params](RemoteViewOptions.md#params)
- [rowsPerPage](RemoteViewOptions.md#rowsperpage)
- [seekToPage](RemoteViewOptions.md#seektopage)
- [sortBy](RemoteViewOptions.md#sortby)
- [url](RemoteViewOptions.md#url)

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

• `Optional` **onAjaxCall**: [`RemoteViewAjaxCallback`](../modules.md#remoteviewajaxcallback)<`any`\>

#### Defined in

[src/slick/remoteview.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L23)

___

### onProcessData

• `Optional` **onProcessData**: [`RemoteViewProcessCallback`](../modules.md#remoteviewprocesscallback)<`any`\>

#### Defined in

[src/slick/remoteview.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L19)

___

### onSubmit

• `Optional` **onSubmit**: [`CancellableViewCallback`](../modules.md#cancellableviewcallback)<`any`\>

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
