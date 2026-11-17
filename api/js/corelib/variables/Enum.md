[@serenity-is/corelib](../README.md) / Enum

# Variable: Enum

> `const` **Enum**: `object`

Defined in: [src/base/system.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L363)

Enum utilities

## Type Declaration

### getIconClass()

> **getIconClass**: (`enumType`, `value`) => `string`

Get the icon class for a specific enum value.

#### Parameters

##### enumType

`any`

Enum type

##### value

Enum value, numeric or string

`string` | `number`

#### Returns

`string`

Icon class name or undefined if not found

### getValues()

> **getValues**: \<`T`\>(`enumType`) => `T`[]

Returns all values of an enum as an array, in their declaration order. A numeric enum returns its numeric
values, a string enum returns the string values of its members.

#### Type Parameters

##### T

`T` = `any`

#### Parameters

##### enumType

`any`

Enum object to enumerate.

#### Returns

`T`[]

Array of enum values. It is typed as `any[]` by default, and can be narrowed with a type
argument, e.g. `Enum.getValues<WidgetCategory>(WidgetCategory)`.

### isStringEnum()

> **isStringEnum**: (`enumType`) => `boolean`

Checks whether an enum has string members, i.e. whether it is generated from a StringEnum. The kind is
recorded when the enum is registered; before that, the members are inspected.

#### Parameters

##### enumType

`any`

Enum type

#### Returns

`boolean`

True when the members of the enum are strings

### toString()

> **toString**: (`enumType`, `value`) => `string`

Convert an enum value to a string containing enum names.

#### Parameters

##### enumType

`any`

Enum type

##### value

Enum value

`string` | `number`

#### Returns

`string`
