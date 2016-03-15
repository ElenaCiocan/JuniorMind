using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class Cyclometer
    {
        [TestMethod]
        public void TestForNoOfTotalRotations()
        {
            var cyclists = new Cyclist[] { new Cyclist("Andrei",7, new int[]{ 2, 3, 4, 2, 1, 6, 5}, 12), new Cyclist("Mihai", 5, new int[] { 2, 3, 4, 2, 5 }, 12), new Cyclist("Marina",6, new int[] { 2, 3, 4, 2, 6, 5 }, 11), new Cyclist("Alina",7, new int[] { 2, 3, 4, 2, 1, 6, 5 }, 13) };
            Assert.AreEqual(84, CalculateNoOfRotations(cyclists));
        }

        [TestMethod]
        public void TestForMaximumSpeedForACyclist()
        {
            var cyclists = new Cyclist[] { new Cyclist("Andrei", 7, new int[] { 2, 3, 4, 2, 1, 6, 5 }, 12), new Cyclist("Mihai", 5, new int[] { 2, 3, 4, 2, 5 }, 11) };
            Assert.AreEqual(226.19, CalculateMaximumSpeedForACyclist(cyclists[0],"Speed"),1e-2);
        }

        [TestMethod]
        public void TestForTheCyclistWithMaxSpeed()
        {
            var cyclists = new Cyclist[] { new Cyclist("Andrei", 7, new int[] { 2, 3, 4, 2, 1, 6, 5 }, 12), new Cyclist("Mihai", 5, new int[] { 2, 3, 4, 2, 5 }, 11) };
            Assert.AreEqual("Andrei", CalculateMaxSpeed(cyclists));
        }

        [TestMethod]
        public void TestForTheSecondWithMaxSpeed()
        {
            var cyclists = new Cyclist[] { new Cyclist("Andrei", 7, new int[] { 2, 3, 4, 2, 1, 6, 5 }, 12), new Cyclist("Mihai", 5, new int[] { 2, 3, 4, 2, 5 }, 11) };
            Assert.AreEqual(6, CalculateMaxSecond(cyclists));
        }

        struct Cyclist
        {
            public string name;
            public int noSeconds;
            public int[] noRotations;
            public double diameter;

           public Cyclist(string name,int seconds, int[] rotations, double diameter)
            {
                this.name = name;
                noSeconds = seconds;
                noRotations = rotations;
                this.diameter = diameter;
            }
        }

        int CalculateNoOfRotations(Cyclist[] cyclists)
        {
            int noOfTotalRotations = 0;
            for (int i = 0; i < cyclists.Length; i++)
                noOfTotalRotations += CalculateNoOfRotationsPerCyclist(cyclists[i]);
            return noOfTotalRotations;
        }

        private static int CalculateNoOfRotationsPerCyclist(Cyclist cyclists)
        {
            int noOfRotations = 0;
            for (int j = 0; j < cyclists.noSeconds; j++)
                noOfRotations += cyclists.noRotations[j];
            return noOfRotations;
        }

        double CalculateMaximumSpeedForACyclist(Cyclist cyclists, string option)
        {
            double diameter = Math.PI * cyclists.diameter;
            double distance = cyclists.noRotations[0] * diameter;
            double maxSpeed = distance / 1;
            int maxSecond = 1;
            for (int i = 1; i < cyclists.noSeconds; i++)
            {
                distance = cyclists.noRotations[i] * diameter;
                double speed = distance / 1;
                if (speed > maxSpeed)
                {
                    maxSpeed = speed;
                    maxSecond = i + 1;
                } 
            }
            if (string.Equals(option, "Speed"))
                return maxSpeed;
            else
                return maxSecond;
        }

        string CalculateMaxSpeed(Cyclist[] cyclists)
        {
            double[] maxSpeeds = new double[cyclists.Length];
            int cyclistNo = 0;
            for (int i = 0; i < cyclists.Length; i++)
                maxSpeeds[i] = CalculateMaximumSpeedForACyclist(cyclists[i],"Speed");
            double max = maxSpeeds[0];
            for (int i = 1; i < maxSpeeds.Length; i++)
            {
                if (maxSpeeds[i] > max)
                    cyclistNo = i;
            }
            return cyclists[cyclistNo].name;
        }

        double CalculateMaxSecond(Cyclist[] cyclists)
        {
            double[] maxSpeeds = new double[cyclists.Length];
            double[] maxSeconds = new double[cyclists.Length];
            int cyclistNo = 0;
            for (int i = 0; i < cyclists.Length; i++)
            {
                maxSpeeds[i] = CalculateMaximumSpeedForACyclist(cyclists[i], "Speed");
                maxSeconds[i] = CalculateMaximumSpeedForACyclist(cyclists[i], "Second");
            }
            double max = maxSpeeds[0];
            for (int i = 1; i < maxSpeeds.Length; i++)
            {
                if (maxSpeeds[i] > max)
                    cyclistNo = i;
            }
            return maxSeconds[cyclistNo] ;
        }
    }
}
