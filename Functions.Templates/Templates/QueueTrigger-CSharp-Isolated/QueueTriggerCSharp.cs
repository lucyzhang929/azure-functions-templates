using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class QueueTriggerCSharp
    {
        [Function("QueueTriggerCSharp")]
        public static void Run([QueueTrigger("PathValue", Connection = "ConnectionValue")] string myQueueItem,
            FunctionContext context)
        {
            var logger = context.GetLogger("QueueTriggerCSharp");
            logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}