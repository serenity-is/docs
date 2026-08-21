[@serenity-is/corelib](../README.md) / CustomAttribute

# Abstract Class: CustomAttribute

Defined in: [src/base/system.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L251)

Base class for all Serenity custom attributes (metadata attached to types).
Attributes are stored on `typeInfo.customAttributes` and queried via
[getCustomAttribute](../functions/getCustomAttribute.md) / [hasCustomAttribute](../functions/hasCustomAttribute.md).

## Extended by

- [`EnumKeyAttribute`](EnumKeyAttribute.md)
- [`EditorAttribute`](EditorAttribute.md)
- [`CloseButtonAttribute`](CloseButtonAttribute.md)
- [`ElementAttribute`](ElementAttribute.md)
- [`AdvancedFilteringAttribute`](AdvancedFilteringAttribute.md)
- [`MaximizableAttribute`](MaximizableAttribute.md)
- [`OptionAttribute`](OptionAttribute.md)
- [`PanelAttribute`](PanelAttribute.md)
- [`ResizableAttribute`](ResizableAttribute.md)
- [`StaticPanelAttribute`](StaticPanelAttribute.md)

## Constructors

### Constructor

> **new CustomAttribute**(): `CustomAttribute`

#### Returns

`CustomAttribute`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/base/system.ts:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L252)
