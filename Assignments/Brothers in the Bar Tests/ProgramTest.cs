namespace Brothers_in_the_Bar_Tests
{
    using Brothers_in_the_Bar;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ProgramTest
    {
        private Type programType;
        private object instance;

        [SetUp]
        public void SetUp()
        {
            this.programType = typeof(Program);
            this.instance = Activator.CreateInstance(programType);
        }

        [Test]
        public void ValidateAreAllOutputsCorrect()
        {
            var getSameCupsCounterMethod = programType.GetMethod("SameCupsCounter");
            Dictionary<int[], int> inputAndResult = new Dictionary<int[], int>()
            {
                { new int[] { 1, 1, 2, 3, 3, 3, 2, 2, 1, 1 }, 3 },
                { new int[] { 1, 1, 2, 1, 2, 2, 1, 1 }, 0 },
                { new int[] { 1, 1, 1, 2, 2, 2, 1, 1, 1 }, 3 },
                { new int[] { 1, 1, 2, 1, 2, 1, 1, 1 }, 1 },
                { new int[] { 1, 1, 2 }, 0 },
                { new int[] { 1, 1 }, 0 },
                { new int[] { 1 }, 0 },
                { new int[] {  }, 0 },
            };

            foreach (var keyValuePair in inputAndResult)
            {
                var actualResult = getSameCupsCounterMethod.Invoke(instance, new object[] { keyValuePair.Key });
                Assert.AreEqual(actualResult, keyValuePair.Value);
            }
        }
    }
}
