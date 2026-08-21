[@serenity-is/corelib](../README.md) / SettingStorage

# Interface: SettingStorage

Defined in: [src/ui/datagrid/datagrid-persistence.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L17)

Minimal storage abstraction used for grid persistence.
Implementations may be synchronous (localStorage) or asynchronous.

## Methods

### getItem()

> **getItem**(`key`): `string` \| `Promise`\<`string`\>

Defined in: [src/ui/datagrid/datagrid-persistence.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L23)

Retrieves a stored value by key.

#### Parameters

##### key

`string`

Storage key.

#### Returns

`string` \| `Promise`\<`string`\>

Stored value or a promise that resolves to it.

***

### setItem()

> **setItem**(`key`, `value`): `void` \| `Promise`\<`void`\>

Defined in: [src/ui/datagrid/datagrid-persistence.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-persistence.ts#L30)

Persists a value under the given key.

#### Parameters

##### key

`string`

Storage key.

##### value

`string`

Value to store.

#### Returns

`void` \| `Promise`\<`void`\>

Void or a promise that resolves when the write completes.
