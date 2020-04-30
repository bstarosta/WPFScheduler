using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WPFScheduler;

namespace WPFSchedulerTests
{
    [TestFixture]
    public class DateTimeHelperTests
    {
        [Test]
        public void ShouldReturnCorrectDateTime()
        {
            DateTime expectedDateTime = new DateTime(2020,5,12,12,15,0);
            DateTime dateTime = DateTimeHelper.addTimeToDate(new DateTime(2020, 5, 12), "12", "15");
            Assert.AreEqual(expectedDateTime, dateTime);
        }
    }
}
