[@serenity-is/corelib](../README.md) / PropertyGridOptions

# Interface: PropertyGridOptions

Defined in: [src/ui/widgets/propertygrid.tsx:1071](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L1071)

Options for configuring a [PropertyGrid](../classes/PropertyGrid.md).

## Properties

### idPrefix?

> `optional` **idPrefix**: `string`

Defined in: [src/ui/widgets/propertygrid.tsx:1073](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L1073)

Optional id prefix used for field element ids.

***

### items

> **items**: [`PropertyItem`](PropertyItem.md)[]

Defined in: [src/ui/widgets/propertygrid.tsx:1075](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L1075)

The property items to render as fields.

***

### localTextPrefix?

> `optional` **localTextPrefix**: `string`

Defined in: [src/ui/widgets/propertygrid.tsx:1077](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L1077)

Optional local text prefix used to localize captions and hints.

***

### mode?

> `optional` **mode**: [`PropertyGridMode`](../enumerations/PropertyGridMode.md)

Defined in: [src/ui/widgets/propertygrid.tsx:1081](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L1081)

The grid mode; defaults to [PropertyGridMode.insert](../enumerations/PropertyGridMode.md#insert).

***

### value?

> `optional` **value**: `any`

Defined in: [src/ui/widgets/propertygrid.tsx:1079](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L1079)

Optional initial value to load into the editors.
