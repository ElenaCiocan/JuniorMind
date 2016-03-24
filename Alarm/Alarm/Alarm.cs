using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class Alarm
    {
        [TestMethod]
        public void TestForTheAlarm()
        {
            Alarms[] alarms = {
                new Alarms { hour = 7, day = DaysOfTheWeek.Monday | DaysOfTheWeek.Tuesday | DaysOfTheWeek.Wednesday | DaysOfTheWeek.Thursday | DaysOfTheWeek.Friday },
                new Alarms { hour = 8, day = DaysOfTheWeek.Saturday | DaysOfTheWeek.Sunday }
            };
            Assert.AreEqual(true, VerifyTheAlarm(8, DaysOfTheWeek.Saturday, alarms));
            Assert.AreEqual(false, VerifyTheAlarm(7, DaysOfTheWeek.Sunday, alarms));

        }

        [Flags]
        enum DaysOfTheWeek
        {
            Monday=1,
            Tuesday=2,
            Wednesday=4,
            Thursday=8,
            Friday=16,
            Saturday=32,
            Sunday=64
        }

        struct Alarms
        {
           public int hour;
            public DaysOfTheWeek day;

            public Alarms(int hour, DaysOfTheWeek day)
            {
                this.hour = hour;
                this.day = day;
            }
        }

        bool VerifyTheAlarm(int hour, DaysOfTheWeek day, Alarms[] allAlarms)
        {
            for (int i = 0; i < allAlarms.Length; i++)
            {
                if( ((day & allAlarms[i].day) !=0) && ((hour & allAlarms[i].hour) !=0))
                    return true;
            }
            return false;
        }
    }
}
