# Entity Assignment Tracking

Understanding Serenity's entity system (Rows) is crucial. It's not the same as the `Entity Framework` or similar `ORMs`. 

It's designed to closely resemble SQL within the constraints of C#, offering operations like partial selects and partial updates. Thus, it relies on assignment tracking and checks for consistency.

## Assignment Tracking

By default, any entity created via its constructor has assignment tracking enabled. This means Serenity keeps track of assigned and unassigned fields.

For this example, we'll use Northwind's [CustomerRow](https://github.com/serenity-is/common-features/blob/master/src/Serenity.Demo.Northwind/Modules/Customer/CustomerRow.cs), defined in the common-features repository:

```cs
var customer = new CustomerRow();
```

At this point, the `customer` entity has assignment tracking turned on by default, which you can verify using the `IRow` interface:

```csharp
Console.WriteLine(((IRow)customer).TrackAssignments) // true
```

Let's set the CustomerID and CompanyName properties:

```csharp
customer.CustomerID = "ABCD1";
customer.CompanyName  = "ABCD Company 1";
```

The `customer` entity keeps track of assigned fields. You can check this using the `IRow` interface methods:

```csharp
((IRow)customer).IsAssigned(CustomerRow.Fields.CustomerID) // true
((IRow)customer).IsAssigned(CustomerRow.Fields.CompanyName) // true
((IRow)customer).IsAssigned(CustomerRow.Fields.City) // false
((IRow)customer).IsAssigned(CustomerRow.Fields.Country) // false
```

Note that this differs from simply checking for null values. Even if a field is assigned `null`, it would still be considered assigned:

```csharp
customer.Country = null;
((IRow)customer).IsAssigned(CustomerRow.Fields.Country) // true
((IRow)customer).IsAssigned(CustomerRow.Fields.City) // false
```

Let's create an entity this way and insert it directly via entity connection extensions (e.g., not via the Create service):

```csharp
customer.CustomerID = "ABCD1";
customer.CompanyName  = "ABCD Company 1";
connection.Insert(customer);
```

The produced SQL would be:

```sql
INSERT INTO Customers (CustomerID, CompanyName) VALUES ('ABCD1', 'ABCD Company 1')
```

Note that the INSERT statement does not include unassigned fields like Country or City.

And if we set Country to null:

```csharp
var customer = new CustomerRow();
customer.CustomerID = "ABCD1";
customer.CompanyName  = "ABCD Company 1";
customer.Country = null;
connection.Insert(customer);
```

The INSERT statement would include the Country field:

```sql
INSERT INTO Customers (CustomerID, CompanyName, Country) VALUES ('ABCD1', 'ABCD Company 1', null)
```

Why do we care if a field is included in the INSERT statement if it is going to be NULL anyway?

The question is, what if it is not actually going to be NULL? For example, some fields might have defaults in the database side. Let's assume the Country column has a default value of `USA` in the SQL DB.

In the first sample, if we checked the inserted record in the DB, the Country field would be `USA`, while in the second sample, it would be `NULL`, assuming the column allows null values.

This is especially critical for numeric fields with a `0` default value. If we included every column in the insert statement, such columns would result in having null values, or the DB would raise an error if the columns do not allow nulls.

This assignment tracking feature becomes even more critical for updates.

Let's say we already have a record in the DB with ID 5, and we just want to update its `City` field. Serenity entity system allows updating records without having to load them first, just like SQL does:

```csharp
var customer = new CustomerRow();
customer.ID = 5;
customer.City = "California";
connection.UpdateById(customer);
```

The generated SQL statement looks like:

```sql
UPDATE Customers 
    SET City = 'California'
WHERE
    ID = 5
```

Note that Serenity included only the assigned columns in `SET` statements. It did not include ID and used it in the `WHERE` instead, as `UpdateById` extension can't be used to update a record's ID.

This is very different from what you would need to do in `Entity Framework`, for example:

```cs
using (var db = new MyDBContext());
var customer = db.Customers.Single(c => c.ID == 5);
customer.City = "California";
db.SaveChanges();
```

You would need to first `load` the entity into the DB context, effectively creating two copies of the customer entity. One that you get back as `customer`, and another internal one, which is a copy of the `customer` entity.

```sql
-- It is a bit more complex than this but close
UPDATE Customers 
    SET City = 'California'
WHERE
    ID = 5
```

Using this copy, when you try to save your changes, Entity Framework `compares all the properties` of your `customer` and the `original customer` and generates a similar update statement. So, Entity Framework also does assignment/change tracking but in a different way than ours.

It has to work this way, e.g., by creating original copies behind the scenes, as there is no other feasible way to perform assignment/change tracking on POCO (plain old) classes.

Note that the aim here is not to claim one is better than the other. We are just trying to explain how it works and how it is different from the common way you might think.

Let's try to do it the same way with Serenity rows and see what happens:

```csharp
// NEVER DO THIS!
var customer = connection.ById<CustomerRow>(5);
customer.City = "California";
connection.UpdateById(customer); 
```

The generated SQL statement becomes:

```sql
UPDATE Customers 
    SET
        CustomerID = 'ABCD1',    
        CompanyName = 'ABCD Company 1',
        ContactName = 'John Doe',
        ContactTitle = 'Mr',
        Address = '123 Some Road...',
        City = 'California', -- this is the only one we intended
        Region = '...',
        PostalCode = '...',
        Country = 'USA',
        -- ...
        -- ...
        -- ... whole lot of other table fields
        -- ...
        -- ...
WHERE
    ID = 5
```

So the SET statement includes all the table fields, not just the one we updated. What is happening here?

Remember that Assignment tracking is ON for any entity by default. This also applies to entities returned from extension methods like `ById`, `List`, `First`, etc.

So the `customer` entity returned by the `ById` extension has `IsAssigned = true` for all the table fields (note that it selects only table fields by default).

So, there is no way for the Serenity entity system to know the difference between `City` assigned by us and other fields that are assigned during SELECT `(ById)` as Serenity does not have an `original customer`.
It's highly recommended to avoid passing any entity returned from a select to update/insert methods.

This is crucial because you might inadvertently set values for fields that you didn't intend to update. For instance, you could end up updating log fields like CreatedBy, CreatedOn, UpdatedBy, and UpdatedOn with their existing values. Moreover, consider a scenario where another user modifies one of the fields between selecting the record and updating it yourself. For essential columns, this might not pose a significant issue, but imagine a scenario with a column like AccountBalance, where updating it to its previous value could conflict with another user's action.

So, how should you proceed if you need to set a field based on the existing value of another field? Let's say you want to set City to `California` if the country is `USA` and `Paris` if the country is `France`:

```csharp
var existing = connection.ById<CustomerRow>(5);
var customer = new CustomerRow();
customer.Id = existing.Id;
customer.City = existing.Country == "USA" ? "California" 
    : (existing.Country == "France" ? "Paris" : existing.City);
connection.UpdateById(customer); 
```

Once again, the update statement would be similar:

```sql
UPDATE Customers 
    SET City = 'Paris'
WHERE
    ID = 5
```

As a rule of thumb, never pass an entity returned from `ById`, `List`, and similar statements to an INSERT/UPDATE method. This principle also applies to Create/Update service handlers. For instance, avoid the following practice:

```csharp
// NEVER DO THIS!
var customer = connection.ById<CustomerRow>(5);
customer.City = "California";
new CustomerCreateHandler(....).Update(uow, {
    EntityId: customer.Id,
    Entity: customer
});
```

The handler will assume that you've assigned all those fields and will generate an update statement including all those table fields.

Instead, follow this approach if necessary:

```csharp
var existing = connection.ById<CustomerRow>(5);
var customer = new CustomerRow();
customer.Id = existing.Id;
customer.City = existing.Country == "USA" ? "California" 
    : (existing.Country == "France" ? "Paris" : existing.City);
connection.UpdateById(uow, {
    EntityId: customer.Id,
    Entity: customer
}); 
```

Another reason you should never pass such entities to Request handlers is that they have `track with checks ON`, which we'll cover next.

## Track With Checks

By default, all entities have `Assignment Tracking ON`. Additionally, entities returned from methods like `ById` also have `Track with Checks ON`.

This means that attempting to read a field that is not `SELECTED` will raise an error, such as:

```text
Country field on CustomerRow is read before being assigned a value! Make sure this field is selected in your SqlQuery......
```

In Serenity, you can select a subset of fields while loading an entity:

```cs
var customer = connection.ById<CustomerRow>(5, q => q
    .Select(CustomerRow.Fields.Id)
    .Select(CustomerRow.Fields.CustomerID)
    .Select(CustomerRow.Fields.City)
    .Select(CustomerRow.Fields.Region));
```

If you provide a query builder callback in the second argument, you will need to determine the set of fields that will be selected, instead of all the table fields, which is the default.

Therefore, when you attempt to read a field that you did not select:

```cs
if (customer.Country == 'USA') // throws!
```

You will receive the above error, reminding you that you did not select that field. Without this warning, it is easy to make mistakes, resulting in invalid states or code, as the `customer.Country` would be null in memory, even if it had the `USA` value in the DB, causing your `if` statement to not pass when it should.

By default, entities created directly, for example, via their constructor, do NOT have this check ON:

```cs
var customer = new Customer();
if (customer.Country == 'USA') // no error
```

You would need to manually enable it:

```cs
var customer = new Customer();
((IRow)customer).TrackWithChecks = true;
if (customer.Country == 'USA') // throws!
```

Note that once you assign a field, even a null value, it does not throw for that field anymore:

```cs
var customer = new Customer();
((IRow)customer).TrackWithChecks = true;
customer.Country = 'France';
customer.City = null;
if (customer.Country == 'USA') // no error
if (customer.City == 'California') // no error
if (customer.Region == 'A') // throws!
```

As `connection.ById`, `connection.List`, etc. extensions turn this on by default and load the table fields (e.g., not view fields, calculated fields, or unmapped fields) by default, they will only throw for non-table fields:

```cs
var customers = connection.List<CustomerRow>();
foreach (var customer in customers)
{
    if (customer.Country == 'USA') // no error
    if (customer.LastContactDate is null) // throws!
}
```

Note that `LastContactDate` is not a table field; it is a view field originating from the `CustomerDetails` table.

## Request Handlers (Create / Save) and Tracking

Request handlers have assignment tracking ON by default, but they have `Track with Checks OFF`.

For instance, if you attempt to read a field from `this.Row` or `this.Old` in your request handlers, it won't raise an error even if that field is not loaded.

There are several reasons for this decision. Firstly, request handlers predate the `TrackWithChecks` feature. Enabling it by default would potentially break many existing handlers that were coded before this tracking system was introduced.

Another reason is that even if you pass a subset of fields to a SAVE handler, it will load all the table fields of `this.Old` and `this.Row` for consistency. Therefore, the issue would only apply to non-table fields like view, calculated, or unmapped fields.

A save handler typically only checks or modifies values of table fields, akin to a regular database INSERT/UPDATE trigger, except for rare cases like UpdatableExtension, LinkingSetRelation, MasterDetailRelation, etc.

It's important to note that when you pass a row to a save handler via the Entity property:

```cs
// NEVER DO THIS!
customer = connection.ById<CustomerRow>(5);
customer.Country = 'Something';
connection.UpdateById(uow, {
    EntityId: customer.Id,
    Entity: customer
});
```

`this.Row` is a `clone` of the `customer` entity. Thus, if the `customer` has `TrackWithChecks ON`, `this.Row` will also have that setting enabled. However, as mentioned before, you should never pass an entity returned from entity extensions to a Save handler. Doing so may cause some handlers to fail, as they may have been written assuming `TrackWithChecks` is off for `this.Row`. Additionally, remember that you would be updating all the fields of the entity, not just the ones you assigned, so it's best to avoid it.