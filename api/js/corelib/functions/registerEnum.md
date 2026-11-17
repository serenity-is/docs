[@serenity-is/corelib](../README.md) / registerEnum

# Function: registerEnum()

> **registerEnum**(`enumType`, `name`, `optOrEnumKey?`): `void`

Defined in: [src/base/system.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L278)

Register an enum with the type system.

## Parameters

### enumType

`any`

Enum type to register

### name

`string`

Name to register the enum under

### optOrEnumKey?

Alternative enum key or options for the enum registration, including alternative key and icon classes.

`string` |

\{ `enumFlags?`: `boolean`; `enumIcons?`: `Record`\<`string` \| `number`, `string`\>; `enumKey?`: `string`; \}

Alternative enum key or options for the enum registration, including alternative key and icon classes.

#### enumFlags?

`boolean`

Whether the enum is a set of flags, like a [Flags] enum on the server side, whose values are OR-ed together

#### enumIcons?

`Record`\<`string` \| `number`, `string`\>

Icon classes for enum values, numeric or string

#### enumKey?

`string`

Enum key

## Returns

`void`
