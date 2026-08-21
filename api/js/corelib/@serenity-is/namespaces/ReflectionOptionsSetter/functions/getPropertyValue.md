[@serenity-is/corelib](../../../../README.md) / [ReflectionOptionsSetter](../README.md) / getPropertyValue

# Function: getPropertyValue()

> **getPropertyValue**(`o`, `property`): `any`

Defined in: [src/ui/widgets/reflectionoptionssetter.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/reflectionoptionssetter.ts#L18)

Gets a property value via `get_<property>` or direct field access.

## Parameters

### o

`any`

Target object.

### property

`string`

Property name (PascalCase or camelCase).

## Returns

`any`

Property value, or undefined if not found.
