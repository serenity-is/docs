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
5. ListRequestHandler.Process method 
    
We'll cover how grids build a list request in another chapter. Let's 
