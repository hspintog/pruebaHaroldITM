using Microsoft.Extensions.Logging;
using pruebaHaroldITM.Functions.Functions;
using pruebaHaroldITM.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace pruebaHaroldITM.Test.Test
{
    public class ScheduleFunctionTest
    {
        
        [Fact]
        public void ScheduleFunction_Should_Log_Message()
        {
            //arrenge
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreaccount1/reports"));
            ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);
            //act
            ScheduledFunction.Run(null, mockTodos, logger);
            string message = logger.Logs[0];
            //assert
            Assert.Contains("Deleting completed", message);
        }
    }
}
