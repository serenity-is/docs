# ListRequestHandler


This is the base class that handles List requests from client side, e.g. from grids.

Let's first sample when and how this class handles list requests:

1. First a list request must be triggered from client side. Possible options are:
    
    a) You open a list page that contains a grid. Right after your grid object is created it builds up a ListRequest object, based on currently visible columns, initial sort order, filters etc. and submits it to server side.
    
    b) User clicks on a column header to sort, clicks paging buttons or refresh button to trigger same events in option A.
    
    c) You might manually call a list service using XYZService.List method.
    
2. A service request (AJAX) to MVC XYZController (in file XYZEndpoint.cs) arrives at server.
3. XYZEndpoint calls XYZRepository.List method with retrieved ListRequest object.
4. XYZRepository.List method creates a subclass of ListRequestHandler (MyListHandler) and invokes its Process method with ListRequest.
5. ListRequestHandler.Process method builds up a dynamic SQL query, based on ListRequest, metadata in its entity type (Row) and other information and executes it.
6. ListRequestHandler.Process returns a ListResponse with Entities member that contains rows to be returned.
    
We'll cover how grids build and submit a list request in another chapter. Let's focus on ListRequestHandler for now.


## List Request Object

First we should have a look at what members a ListRequest object have:

```cs
  public class ListRequest : ServiceRequest, IIncludeExcludeColumns
  {
      public int Skip { get; set; }
      public int Take { get; set; }
      public SortBy[] Sort { get; set; }
      public string ContainsText { get; set; }
      public string ContainsField { get; set; }
      [JsonConverter(typeof(JsonSafeCriteriaConverter))]
      public BaseCriteria Criteria { get; set; }
      public bool IncludeDeleted { get; set; }
      public bool ExcludeTotalCount { get; set; }
      public Dictionary<string, object> EqualityFilter { get; set; }
      public ColumnSelection ColumnSelection { get; set; }
      [JsonConverter(typeof(JsonStringHashSetConverter))]
      public HashSet<string> IncludeColumns { get; set; }
      [JsonConverter(typeof(JsonStringHashSetConverter))]
      public HashSet<string> ExcludeColumns { get; set; }
  }
```


### ListRequest.Skip and ListRequest.Take Parameters

These options are used for paging and similar to Skip and Page extensions in LINQ. 

There is one little difference about Take. If you Take(0), LINQ will return you zero records, while Serenity will return ALL records. There is no point in calling a LIST service and requesting 0 records.

So, SKIP and TAKE has default values of 0, and they are simply ignored when 0 / undefined.

```cs
// returns all customers as Skip and Take are 0 by default 
CustomerService.List(new ListRequest
{
}, response => {});
```

If you have a grid that has page size 50 and switch to page number 4, SKIP will be 200 while TAKE is 50.

```cs
// returns customers between row numbers 201 and 250 (in some default order)
CustomerService.List(new ListRequest
{
    Skip = 200,
    Take = 50
}, response => {});
```

These parameters are converted to relevant SQL paging statements based on SQL dialect. 

### ListRequest.SortBy Parameter

This parameter takes an array of columns to sort results on. Sorting is performed by generating SQL.

SortBy parameter expects a list of *SortBy* objects:

```cs
[JsonConverter(typeof(JsonSortByConverter))]
public class SortBy
{
    public SortBy()
    {
    }

    public SortBy(string field)
    {
        Field = field;
    }

    public SortBy(string field, bool descending)
    {
        Field = field;
        Descending = descending;
    }

    public string Field { get; set; }
    public bool Descending { get; set; }
}
```

When calling a List method of XYZRepository server side to sort by Country then City descending, you might do it like this:

```cs
new CustomerRepository().List(connection, new ListRequest
{
    SortBy = new[] { 
        new SortBy("Country"),
        new SortBy("City", descending: true)
    }
});
```


