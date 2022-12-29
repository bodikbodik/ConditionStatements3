using System;
using NUnit.Framework;
using ConditionStatements3;

namespace ConditionStatementTests
{
    public class Tests
    {
        [TestCase(5, 6, 11, 5, 6,11)]
        [TestCase(21, 28, 5, 5, 28,28)]
        [TestCase(-3120, -562, -754, -3120,-562,-562)]
        [TestCase(-40,-7, 14,-40,-7,14)]
        public void Task1_ContainsCorrectNumbers(int a, int b, int c, int expectedA, int expectedB, int expectedC)
        { 
            var (i1, i2, i3) = Tasks.Task1(a, b, c);

            Assert.AreEqual(expectedA, i1, "Variable A contains incorrect value.");
            Assert.AreEqual(expectedB, i2, "Variable B contains incorrect value.");
            Assert.AreEqual(expectedC, i3, "Variable C contains incorrect value.");
        }
        
        [TestCase(46, 85, 112, 92, 170, 224)]
        [TestCase(2, 14,8, -2,-14,-8)]
        [TestCase(-8, -1, 12, -16,-2,24)]
        [TestCase(-5,-7, -2, 5,7,2)]
        public void Task2_ContainsCorrectNumbers(int a, int b, int c, int expectedA, int expectedB, int expectedC)
        {
            var (i1, i2, i3) = Tasks.Task2( a,  b,  c);

            Assert.AreEqual(expectedA, i1, "Variable A contains incorrect value.");
            Assert.AreEqual(expectedB, i2, "Variable B contains incorrect value.");
            Assert.AreEqual(expectedC, i3, "Variable C contains incorrect value.");
        }
        
        [TestCase(25, 40, 125, 50,80,250)]
        [TestCase(12, -8, -23, 24,-16,-46)]
        [TestCase(20,-10, 7, -20,10,-7)]
        [TestCase(-5,-71, -118, -10,-142,-236)]
        public void Task3_ContainsCorrectNumbers(int a, int b, int c, int expectedA, int expectedB, int expectedC)
        {
            var ( i1,  i2,  i3) = Tasks.Task3( a,  b, c);

            Assert.AreEqual(expectedA, i1, "Variable A contains incorrect value.");
            Assert.AreEqual(expectedB, i2, "Variable B contains incorrect value.");
            Assert.AreEqual(expectedC, i3, "Variable C contains incorrect value.");
        }
    }
}

