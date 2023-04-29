[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/slick](../modules/corelib_slick.md) / RemoteViewOptions

# Interface: RemoteViewOptions

[corelib/slick](../modules/corelib_slick.md).RemoteViewOptions

## Table of contents

### Properties

- [autoLoad](corelib_slick.RemoteViewOptions.md#autoload)
- [contentType](corelib_slick.RemoteViewOptions.md#contenttype)
- [dataType](corelib_slick.RemoteViewOptions.md#datatype)
- [errorMsg](corelib_slick.RemoteViewOptions.md#errormsg)
- [filter](corelib_slick.RemoteViewOptions.md#filter)
- [getItemMetadata](corelib_slick.RemoteViewOptions.md#getitemmetadata)
- [groupItemMetadataProvider](corelib_slick.RemoteViewOptions.md#groupitemmetadataprovider)
- [idField](corelib_slick.RemoteViewOptions.md#idfield)
- [inlineFilters](corelib_slick.RemoteViewOptions.md#inlinefilters)
- [localSort](corelib_slick.RemoteViewOptions.md#localsort)
- [method](corelib_slick.RemoteViewOptions.md#method)
- [onAjaxCall](corelib_slick.RemoteViewOptions.md#onajaxcall)
- [onProcessData](corelib_slick.RemoteViewOptions.md#onprocessdata)
- [onSubmit](corelib_slick.RemoteViewOptions.md#onsubmit)
- [params](corelib_slick.RemoteViewOptions.md#params)
- [rowsPerPage](corelib_slick.RemoteViewOptions.md#rowsperpage)
- [seekToPage](corelib_slick.RemoteViewOptions.md#seektopage)
- [sortBy](corelib_slick.RemoteViewOptions.md#sortby)
- [url](corelib_slick.RemoteViewOptions.md#url)

## Properties

### autoLoad

• `Optional` **autoLoad**: `boolean`

#### Defined in

[src/slick/remoteview.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;7)

___

### contentType

• `Optional` **contentType**: `string`

#### Defined in

[src/slick/remoteview.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;9)

___

### dataType

• `Optional` **dataType**: `string`

#### Defined in

[src/slick/remoteview.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;10)

___

### errorMsg

• `Optional` **errorMsg**: `string`

#### Defined in

[src/slick/remoteview.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;25)

___

### filter

• `Optional` **filter**: `any`

#### Defined in

[src/slick/remoteview.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;11)

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

[src/slick/remoteview.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;24)

___

### groupItemMetadataProvider

• `Optional` **groupItemMetadataProvider**: `GroupItemMetadataProvider`

#### Defined in

[src/slick/remoteview.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;22)

___

### idField

• `Optional` **idField**: `string`

#### Defined in

[src/slick/remoteview.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;8)

___

### inlineFilters

• `Optional` **inlineFilters**: `boolean`

#### Defined in

[src/slick/remoteview.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;21)

___

### localSort

• `Optional` **localSort**: `boolean`

#### Defined in

[src/slick/remoteview.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;15)

___

### method

• `Optional` **method**: `string`

#### Defined in

[src/slick/remoteview.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;20)

___

### onAjaxCall

• `Optional` **onAjaxCall**: [`RemoteViewAjaxCallback`](../modules/corelib_slick.md#remoteviewajaxcallback)<`any`\>

#### Defined in

[src/slick/remoteview.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;23)

___

### onProcessData

• `Optional` **onProcessData**: [`RemoteViewProcessCallback`](../modules/corelib_slick.md#remoteviewprocesscallback)<`any`\>

#### Defined in

[src/slick/remoteview.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;19)

___

### onSubmit

• `Optional` **onSubmit**: [`CancellableViewCallback`](../modules/corelib_slick.md#cancellableviewcallback)<`any`\>

#### Defined in

[src/slick/remoteview.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;13)

___

### params

• `Optional` **params**: `any`

#### Defined in

[src/slick/remoteview.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;12)

___

### rowsPerPage

• `Optional` **rowsPerPage**: `number`

#### Defined in

[src/slick/remoteview.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;17)

___

### seekToPage

• `Optional` **seekToPage**: `number`

#### Defined in

[src/slick/remoteview.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;18)

___

### sortBy

• `Optional` **sortBy**: `any`

#### Defined in

[src/slick/remoteview.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;16)

___

### url

• `Optional` **url**: `string`

#### Defined in

[src/slick/remoteview.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;14)
