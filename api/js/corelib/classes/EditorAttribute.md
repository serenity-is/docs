[@serenity-is/corelib](../README.md) / EditorAttribute

# Class: EditorAttribute

Defined in: [src/base/system.ts:549](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L549)

Attribute that marks a class as a Serenity editor.
Added automatically by [registerEditor](../functions/registerEditor.md) / [editorTypeInfo](../functions/editorTypeInfo.md). Can also be applied manually via `classTypeInfo`.

## Extends

- [`CustomAttribute`](CustomAttribute.md)

## Constructors

### Constructor

> **new EditorAttribute**(): `EditorAttribute`

#### Returns

`EditorAttribute`

#### Inherited from

[`CustomAttribute`](CustomAttribute.md).[`constructor`](CustomAttribute.md#constructor)

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/base/system.ts:550](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L550)

#### Overrides

[`CustomAttribute`](CustomAttribute.md).[`[typeInfo]`](CustomAttribute.md#typeinfo)
