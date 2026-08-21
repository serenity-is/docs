[@serenity-is/corelib](../README.md) / editorTypeInfo

# Function: editorTypeInfo()

> **editorTypeInfo**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

Defined in: [src/base/system.ts:625](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L625)

Creates [EditorTypeInfo](../type-aliases/EditorTypeInfo.md) for an editor class. Like [classTypeInfo](classTypeInfo.md) but automatically adds [EditorAttribute](../classes/EditorAttribute.md).

## Type Parameters

### TypeName

`TypeName`

String-literal editor type name.

## Parameters

### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

Fully-qualified editor name (e.g. `"MyApp.MyEditor"`).

### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and extra attributes.

## Returns

[`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

An [EditorTypeInfo](../type-aliases/EditorTypeInfo.md) to assign to `[Symbol.typeInfo]`.
