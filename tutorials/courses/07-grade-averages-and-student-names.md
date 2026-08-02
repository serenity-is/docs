# Grade Averages and Student Names

## Calculate the Average Automatically

Right now `Average` is a plain input, so a user can type anything into it — which invites mistakes. Let's compute it on the server from `Midterm` and `Final` instead.

## Step 1 — Remove the Average field from the form

Open `GradesForm.cs` and remove the `Average` property, so the form ends with `Midterm` and `Final`:

```csharp
public int StudentId { get; set; }
public int CourseId { get; set; }
public int TermId { get; set; }
public decimal Midterm { get; set; }
public decimal Final { get; set; }
```
## Step 2 — Calculate the average in GradesRow

Add this method to `GradesRow.cs`:

```csharp
public void CalculateAverage()
{
    if (Midterm != null && Final != null)
        Average = (Midterm + Final) / 2;
}
```
## Step 3 — Call it from the SaveHandler

Override `BeforeSave` in `GradesSaveHandler.cs` so the average is calculated before the record is saved:

```csharp
protected override void BeforeSave()
{
    base.BeforeSave();

    Row.CalculateAverage();
}
```
That's it — from now on the average is computed automatically, so users can't enter an inconsistent value.

## Show the Student's Full Name in Grades

The Grades screen currently shows only the student's first name (Sergen generated a `StudentFirstName` field from the join). Let's show the full name instead:

- Remove `StudentFirstName` from `GradesRow.cs`.
- Link a `FullName` field from `StudentsRow` into `GradesRow` instead.
- Update `GradesColumns.cs` accordingly.

### Update GradesRow.cs

Remove `StudentFirstName` and add a `FullName` field:
```csharp
[DisplayName("Full Name"), Origin(jStudent, nameof(StudentsRow.FullName))]
public string FullName 
{ 
    get => fields.FullName[this]; 
    set => fields.FullName[this] = value; 
}
```
```csharp
// Declaration in the Fields class
public StringField FullName;
```

### Update GradesColumns.cs

Add a `FullName` column to `GradesColumns.cs` and remove the old `StudentFirstName` property:

```csharp
public string FullName { get; set; }
```
### Link StudentId to FullName

Point `StudentId` at `FullName` so the student column shows the full name:
```csharp
[DisplayName("Student"), NotNull, ForeignKey(typeof(StudentsRow)), LeftJoin(jStudent), TextualField(nameof(FullName))]
[ServiceLookupEditor(typeof(StudentsRow), Service = "CourseDB/Students/List")]
public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }
```
And move the `NameProperty`/`QuickSearch` in `StudentsRow` to the `FullName` field:
```csharp
[DisplayName("Full Name"), Size(201), NotNull, NameProperty, QuickSearch]
public string FullName { get => fields.FullName[this]; set => fields.FullName[this] = value; }
```
The Student column in the Grades screen now shows the full name.

![FullName column in the Grades screen](./img/full_name_field.png)

Before we add the Excel/PDF export buttons, let's add quick filtering — handy for filtering exactly the data you want to export.
