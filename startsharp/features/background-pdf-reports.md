# Background Task to Generate PDF Reports

This is a sample background task that runs Order Detail Report every night at 01:30, generates its PDF, attaches it to an e-mail and sends it.

```cs
    public class OrderDetailSampleTask : DailyBackgroundTask
    {
        protected override TimeSpan GetRunAtTime()
        {
            // this task will run at 01:30 everyday
            return new TimeSpan(01, 30, 00);
        }

        protected override void InternalRun()
        {
            using (var connection = SqlConnections.NewFor<OrderRow>())
        //...
```

