[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / registerEditor

# ~~Function: registerEditor()~~

> **registerEditor**(`nameOrIntf?`, `intf2?`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L44)

Registers an editor class.

## Parameters

### nameOrIntf?

Full type name or interface list.

`string` | [`InterfaceType`](../../../../type-aliases/InterfaceType.md)[]

### intf2?

[`InterfaceType`](../../../../type-aliases/InterfaceType.md)[]

Additional interfaces.

## Returns

Class decorator.

> (`target`, `_context?`): `void`

### Parameters

#### target

`Function`

#### \_context?

`any`

### Returns

`void`
