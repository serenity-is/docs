# Background Task System

You might want to run some process periodically, e.g. daily, or every three hours. 

Even though you could use Scheduled Tasks or Windows Services, it would require manual configuration in every server you install your application, and
they come with their own set of problems like being hard to manage, code duplication etc.

StartSharp includes a background task system for your web applications. 

Even though it is not as feature filled as some other choices like HangFire (https://www.hangfire.io/), 
it gets the job done without having to learn too much.

```cs
namespace StartSharp.Common.Services
{
    using Entities;
    using Serenity;
    using Serenity.Data;
    using System;

    public class MailingBackgroundTask : PeriodicBackgroundTask
    {
        protected override TimeSpan GetInterval()
        {
            var config = Config.Get<MailingServiceSettings>();
            return TimeSpan.FromSeconds(config.Interval);
        }

        protected override void InternalRun()
        {
            var env = Config.Get<EnvironmentSettings>();
            var config = Config.Get<MailingServiceSettings>();

            if (!config.Enabled)
                return;

            using (var connection = SqlConnections.NewFor<MailRow>())
            {
                var m = MailRow.Fields;

                var mailList = connection.List<MailRow>(q => q
                    .Take(config.BatchSize)
                    .Select(m.MailId)
                    //...
```

We implemented our next feature, Batch Mail Queue on this task system.
