using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class Cyclometer
    {
        [TestMethod]
        public void TestForTotalDistance()
        {
            var cyclists = new Cyclist[] { new Cyclist("Andrei", new int[]{ 2, 3, 4, 2, 1, 6, 5}, 12), new Cyclist("Mihai",  new int[] { 2, 3, 4, 2, 5 }, 12), new Cyclist("Marina", new int[] { 2, 3, 4, 2, 6, 5 }, 11)};
            Assert.AreEqual(2230.53, CalculateTotalDistance(cyclists),1e-2);
        }

       /* [TestMethod]
        public void TestForMaximumSpeedForACyclist()
        {
            var cyclists = new Cyclist[] { new Cyclist("Andrei", new int[] { 2, 3, 4, 2, 1, 6, 5 }, 12), new Cyclist("Mihai",  new int[] { 2, 3, 4, 2, 5 }, 11) };
            Assert.AreEqual(226.19, CalculateMaximumSpeedForACyclist(cyclists[0]),1e-2);
        }*/

        [TestMethod]
        public void TestForTheCyclistWithMaxSpeed()
        {
            var cyclists = new Cyclist[] { new Cyclist("Andrei",  new int[] { 2, 3, 4, 2, 1, 6, 5 }, 12), new Cyclist("Mihai",  new int[] { 2, 3, 4, 2, 5 }, 11) };
            var second = 6;
            Assert.AreEqual("Andrei", CalculateMaxSpeed(cyclists,out second));
        }

     /*   [TestMethod]
        public void TestForTheSecondWithMaxSpeed()
        {
            var cyclists = new Cyclist[] { new Cyclist("Andrei",  new int[] { 2, 3, 4, 2, 1, 6, 5 }, 12), new Cyclist("Mihai",  new int[] { 2, 3, 4, 2, 5 }, 11) };
            Assert.AreEqual(6, CalculateMaxSecond(cyclists));
        }*/

        [TestMethod]
        public void TestForTheAverageSpeed()
        {
            var cyclists = new Cyclist[] { new Cyclist("Andrei",  new int[] { 2, 3, 4, 2, 1, 6, 5 }, 12), new Cyclist("Mihai", new int[] { 2, 3, 4, 2, 5 }, 11) };
            Assert.AreEqual(cyclists[0], FindOutTheCyclistWithTheBestAverageSpeed(cyclists));
        }

        struct Cyclist
        {
            public string name;
            public int[] noRotations;
            public double diameter;

           public Cyclist(string name, int[] rotations, double diameter)
            {
                this.name = name;
                noRotations = rotations;
                this.diameter = diameter;
            }
        }

        double CalculateTotalDistance(Cyclist[] cyclists)
        {
            double totalDistance = 0;
            for (int i = 0; i < cyclists.Length; i++)
                totalDistance += CalculateDistancePerCyclist(cyclists[i]);
            return totalDistance;
        }

        private static double CalculateDistancePerCyclist(Cyclist cyclists)
        {
            double circumference = Math.PI * cyclists.diameter;
            double distance = 0;
            for (int j = 0; j < cyclists.noRotations.Length; j++)
                distance += cyclists.noRotations[j]*circumference;
            return distance;
        }

        double CalculateMaximumSpeedForACyclist(Cyclist cyclists, out int maxSecond)// string option, )
        {
            double circumference = Math.PI * cyclists.diameter;
            double distance = cyclists.noRotations[0] * circumference;
            double maxSpeed = CalculateDistancePerCyclist(cyclists);
            maxSecond = 1;
            for (int i = 1; i < cyclists.noRotations.Length; i++)
            {
                distance = cyclists.noRotations[i] * circumference;
                double speed = distance / 1;
                if (speed > maxSpeed)
                {
                    maxSpeed = speed;
                    maxSecond = i + 1;
                } 
            }
           // if (string.Equals(option, "Speed"))
                return maxSpeed;
          // else
               // return maxSecond;
        }

        string CalculateMaxSpeed(Cyclist[] cyclists,out int maximumSecond)
        {
            double[] maxSpeeds = new double[cyclists.Length];
            int[] maxSeconds = new int[cyclists.Length];
            int cyclistNo = 0;
            maximumSecond = 0;
            for (int i = 0; i < cyclists.Length; i++)
            {
                maxSpeeds[i] = CalculateMaximumSpeedForACyclist(cyclists[i], out maximumSecond);
                maxSeconds[i] = maximumSecond;
            }
            cyclistNo = CalculateMax(maxSpeeds);
            maximumSecond = maxSeconds[cyclistNo];
            return cyclists[cyclistNo].name;
        }

      /*  double CalculateMaxSecond(Cyclist[] cyclists)
        {
            double[] maxSpeeds = new double[cyclists.Length];
            double[] maxSeconds = new double[cyclists.Length];
            int cyclistNo = 0;
            for (int i = 0; i < cyclists.Length; i++)
            {
                maxSpeeds[i] = CalculateMaximumSpeedForACyclist(cyclists[i], "Speed");
                maxSeconds[i] = CalculateMaximumSpeedForACyclist(cyclists[i], "Second");
            }
            cyclistNo = CalculateMax(maxSpeeds);
            return maxSeconds[cyclistNo] ;
        }*/

        Cyclist FindOutTheCyclistWithTheBestAverageSpeed(Cyclist[] cyclists)
        {
            int cyclistNo = 0;
            double[] averageSpeeds = new double[cyclists.Length];
            for (int i = 0; i < averageSpeeds.Length; i++)
                averageSpeeds[i] = CalculateDistancePerCyclist(cyclists[i]) / cyclists[i].noRotations.Length;
            cyclistNo = CalculateMax(averageSpeeds);
            return cyclists[cyclistNo];
        }

        private static int CalculateMax( double[] averageSpeeds)
        {
            int max=0;
            double maxAverageSpeed = averageSpeeds[0];
            for (int i = 1; i < averageSpeeds.Length; i++)
            {
                if (averageSpeeds[i] > maxAverageSpeed)
                    max = i;
            }
            return max;
        }
    }
}
