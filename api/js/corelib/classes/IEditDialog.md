[@serenity-is/corelib](../README.md) / IEditDialog

# Abstract Class: IEditDialog

Defined in: [src/interfaces/ieditdialog.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ieditdialog.ts#L6)

Type token for dialogs that can load an entity by id or instance.

## Constructors

### Constructor

> **new IEditDialog**(): `IEditDialog`

#### Returns

`IEditDialog`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/interfaces/ieditdialog.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ieditdialog.ts#L7)

## Methods

### load()

> **load**(`entityOrId`, `done`, `fail?`): `PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`any`\>\>

Defined in: [src/interfaces/ieditdialog.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ieditdialog.ts#L18)

Loads an entity into the dialog.

#### Parameters

##### entityOrId

`any`

Entity instance or primary key value.

##### done

() => `void`

Callback invoked after successful load.

##### fail?

(`p1`) => `void`

Optional callback invoked on failure.

#### Returns

`PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`any`\>\>

Promise-like for the retrieve response.
