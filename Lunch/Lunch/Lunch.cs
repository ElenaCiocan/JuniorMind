using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void TestForTheFirstMeeting()
        {
            Assert.AreEqual(12, CalculateDayOfMeeting(4,6));
        }

        public int CalculateDayOfMeeting(int firstPersonDay, int secondPersonDay)
        {
            int meetingDay=0,i;
            int product = firstPersonDay * secondPersonDay;
            for (i = 1; i <= product; i++)
            {
                if ((i % firstPersonDay == 0) && (i % secondPersonDay == 0))
                {
                    meetingDay = i;
                    break;
                }
            }
            return meetingDay;
        }
    }
}
