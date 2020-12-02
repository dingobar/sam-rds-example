using System;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace StockChecker
{
    public class Function
    {

        private static readonly Random rand = new Random((Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);

        public void FunctionHandler(ILambdaContext context)
        {
            var dbc = new DatabaseContext("dummy");
            dbc.BulkUpsertVesselSignalData(null);
        }
    }
}
