[@serenity-is/corelib](../README.md) / PropertyGridOptions

# Interface: PropertyGridOptions

Defined in: [src/ui/widgets/propertygrid.tsx:798](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L798)

Options for configuring a [PropertyGrid](../classes/PropertyGrid.md).

## Properties

### idPrefix?

> `optional` **idPrefix**: `string`

Defined in: [src/ui/widgets/propertygrid.tsx:800](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L800)

Optional id prefix used for field element ids.

***

### items

> **items**: [`PropertyItem`](PropertyItem.md)[]

Defined in: [src/ui/widgets/propertygrid.tsx:802](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L802)

The property items to render as fields.

***

### localTextPrefix?

> `optional` **localTextPrefix**: `string`

Defined in: [src/ui/widgets/propertygrid.tsx:804](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L804)

Optional local text prefix used to localize captions and hints.

***

### mode?

> `optional` **mode**: [`PropertyGridMode`](../enumerations/PropertyGridMode.md)

Defined in: [src/ui/widgets/propertygrid.tsx:808](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L808)

The grid mode; defaults to [PropertyGridMode.insert](../enumerations/PropertyGridMode.md#insert).

***

### value?

> `optional` **value**: `any`

Defined in: [src/ui/widgets/propertygrid.tsx:806](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L806)

Optional initial value to load into the editors.
