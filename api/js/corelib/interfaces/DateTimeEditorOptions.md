[@serenity-is/corelib](../README.md) / DateTimeEditorOptions

# Interface: DateTimeEditorOptions

Defined in: [src/ui/editors/datetimeeditor.tsx:515](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L515)

Options for the [DateTimeEditor](../classes/DateTimeEditor.md).

## Properties

### endHour?

> `optional` **endHour**: `any`

Defined in: [src/ui/editors/datetimeeditor.tsx:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L519)

Ending hour for the time select (0-23).

***

### inputOnly?

> `optional` **inputOnly**: `boolean`

Defined in: [src/ui/editors/datetimeeditor.tsx:533](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L533)

Whether to render as a plain input without picker UI.

***

### intervalMinutes?

> `optional` **intervalMinutes**: `any`

Defined in: [src/ui/editors/datetimeeditor.tsx:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L521)

Interval in minutes between time options.

***

### maxValue?

> `optional` **maxValue**: `string`

Defined in: [src/ui/editors/datetimeeditor.tsx:525](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L525)

Maximum allowed date-time as an ISO string.

***

### minValue?

> `optional` **minValue**: `string`

Defined in: [src/ui/editors/datetimeeditor.tsx:523](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L523)

Minimum allowed date-time as an ISO string.

***

### seconds?

> `optional` **seconds**: `boolean`

Defined in: [src/ui/editors/datetimeeditor.tsx:531](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L531)

Whether to include seconds in the time picker.

***

### sqlMinMax?

> `optional` **sqlMinMax**: `boolean`

Defined in: [src/ui/editors/datetimeeditor.tsx:535](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L535)

Whether to apply SQL min/max date bounds.

***

### startHour?

> `optional` **startHour**: `any`

Defined in: [src/ui/editors/datetimeeditor.tsx:517](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L517)

Starting hour for the time select (0-23).

***

### useUtc?

> `optional` **useUtc**: `boolean`

Defined in: [src/ui/editors/datetimeeditor.tsx:529](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L529)

Whether to store and display values in UTC.

***

### yearRange?

> `optional` **yearRange**: `string`

Defined in: [src/ui/editors/datetimeeditor.tsx:527](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/datetimeeditor.tsx#L527)

Year range for the date picker (e.g. "-100:+50").
